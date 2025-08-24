using System;
using System.Collections.Generic; // Lists
using System.IO; 		          // File
using System.Text;          	  // Use of StringBuilder

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            // System parameters and variables
            //int[] NN = new int[] { 12800 };// 25, 50,100, 200,400,800,1600,3200,6400,12800, 25600,51200,102400;   // Number of agents 

            //ii < NN.Length
            for (int ii = 0; ii < 10; ii++)
            {
                int N = 1000;                             // Number of agents
                int M = 100;                              // Initial money
                int anos = 1000;                          // Duration of the simulation in years
                int tmax = anos * 12 * N;                 // Duration of the simulation in steps
                var Agentes = new int[N + 1];             // i -> index, j-> value. j is the boss of i, -1: employer, 0: unemployed, j: employee of j
                var Riquezas = new int[N + 1];            // Wealth list
                var Salarios = new int[N + 1];            // Income list
                var Lucros = new int[N + 1];              // Profit list
                List<int> empregadores = new List<int>(); // List of employers
                List<int> desempregados = new List<int>();// List of unemployed agents
                int smin = 10;                            // Minimum wage
                int smax = 90;                            // Maximum wage
                int smed = (smin + smax) / 2;             // Average wage
                int seed = ii;

                // Code setup
                Random rnd = new Random(seed);            // Initialize random numbers

                // For results analysis
                int ano = 0;                              // Current year
                StringBuilder texto = new StringBuilder();// Text to be written
                StringBuilder arquivo = new StringBuilder();// File to be written
                arquivo.AppendFormat("{0:d}-{1:d}-{2:d}-{3:d}-{4:d}.txt", N, M, smin, smax, seed);

                // Initial wealth distribution and connections
                for (int i = 1; i <= N; i++)
                {
                    Riquezas[i] = M;                 // Assign initial wealth to agent i
                    Agentes[i] = 0;                  // All agents start without relations
                    desempregados.Add(i);            // All agents start unemployed
                }
                Riquezas[0] = 0;                     // Market wealth

                // Simulation
                for (int i = 0; i < tmax; i++)
                {
                    int a; int b;       // Store the indices of the main active agent (a) and the interacting agent (b)

                    // 1 - Selection +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    // An agent a is selected randomly
                    a = rnd.Next(N) + 1;  // We ignore agent 0, which is the market itself

                    // 2 - Hiring ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    // If agent A is unemployed then:
                    if (Agentes[a] == 0)
                    {
                        // If there is more than one potential employer (someone else besides himself), select one
                        if (empregadores.Count > 0 || (desempregados.Count > 1)) // We need him not to be the only unemployed
                        {
                            b = a;                              // Look for another agent
                            bool continuar = true;              // a) A potential employer B is selected among all potential agents
                            while (b == a)                      // Repeat until selecting someone different from A
                            {
                                // Accumulated wealth lists
                                List<int> riq_emp = new List<int>(); List<int> riq_des = new List<int>();
                                int riqd = 0; int riqe = 0; int k = 0;          // Auxiliary variables
                                for (int j = 0; j < desempregados.Count; j++)   // Cumulative wealth of unemployed
                                { riqd += Riquezas[desempregados[j]]; riq_des.Add(riqd); }
                                for (int j = 0; j < empregadores.Count; j++)    // Cumulative wealth of employers
                                { riqe += Riquezas[empregadores[j]]; riq_emp.Add(riqe); }
                                if (riqd + riqe == 0)
                                { break; }
                                else if (rnd.Next(1, riqd + riqe + 1) <= riqe)  // Decide if employer or unemployed was selected
                                {                                               // If it was an employer
                                    k = rnd.Next(1, riqe + 1);                  // Draw a number smaller than the total wealth
                                    for (int j = 0; j < riq_emp.Count; j++)     // Iterate through employers
                                    { if (k <= riq_emp[j])                      // If the number is within this employer’s wealth
                                        {
                                            b = empregadores[j];                // Assign employer
                                            break;                              // Exit loop
                                        }
                                    }
                                }
                                else                                            // If not an employer, then it was an unemployed
                                {
                                    if (riqd + riqe == Riquezas[a]) { continuar=false;Console.WriteLine("Oops!");break; } // If the only possible is the agent himself, ignore

                                    k = rnd.Next(1, riqd + 1);
                                    for (int j = 0; j < riq_des.Count; j++)
                                    {
                                        if (k <= riq_des[j])
                                        {
                                            b = desempregados[j];
                                            break;
                                        }
                                    }
                                }
                            }

                            // b) If B has more wealth than the average salary, then B hires A
                            if (smed <= Riquezas[b] && continuar)
                            {
                                Agentes[a] = b;                     // Then A becomes an employee of B
                                desempregados.Remove(a);            // Remove A from unemployed
                                if (Agentes[b] != -1)               // Check if B is already an employer
                                {
                                    desempregados.Remove(b);        // If not, B becomes one
                                    empregadores.Add(b);
                                    Agentes[b] = -1;
                                }
                            }
                        }
                    }

                    // 3 - Spending +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    // Another agent B is randomly selected
                    b = a;
                    while (b == a) { b = rnd.Next(N) + 1; }
                    int m = rnd.Next(Riquezas[b] + 1);  // A fraction of B's wealth is selected randomly
                    Riquezas[0] += m;                   // Transfer to market reserve
                    Riquezas[b] -= m;

                    // 4 - Firms +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    // If A is not unemployed then:
                    if (Agentes[a] != 0)
                    {
                        // a) A random revenue is selected from the market
                        m = rnd.Next(Riquezas[0] + 1);
                        Riquezas[0] -= m;                           // Remove from market

                        // b) If A is an employee: revenue goes to their employer
                        if (Agentes[a] > 0)                     // A is employed
                        {
                            b = Agentes[a];                     // Employer index
                            Riquezas[b] += m;                   // Transfer wealth
                            Lucros[b] += m;                     // Save income increase
                        }
                        // c) If A is an employer: revenue goes directly to A
                        else if (Agentes[a] < 0)
                        {
                            Riquezas[a] += m;
                            Lucros[a] += m;
                        }
                        else { Console.WriteLine("Should not enter here"); }
                    }

                    // 5 - Firing ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    // If A is an employer:
                    if (Agentes[a] == -1)
                    {
                        // a) Select the number of employees u to fire:
                        int u = 0;                                  // Number of necessary layoffs
                        List<int> trabalhadores = new List<int>();  // List of employees  
                        for (int j = 1; j <= N; j++) { if (Agentes[j] == a) { trabalhadores.Add(j); } }
                        while ((trabalhadores.Count - u) * smed > Riquezas[a]) { u += 1; } // While expected wages exceed wealth, increase layoffs
                                                                                           // b) Randomly select U employees of A and fire them
                        while (u > 0) // Clear the list of people to be fired
                        {
                            b = rnd.Next(trabalhadores.Count);      // Index of worker to fire
                            m = trabalhadores[b];                   // ID of worker
                            desempregados.Add(m);                   // Add to unemployed
                            trabalhadores.Remove(m);                // Remove from employee list
                            Agentes[m] = 0;                         // Break connection
                            u -= 1;                                 // Decrease counter
                        }
                        
                        if (trabalhadores.Count == 0)               // If no employees remain
                        {                                           // a becomes unemployed
                            empregadores.Remove(a);
                            desempregados.Add(a);
                            Agentes[a] = 0;
                        }
                        else                                        // If employees remain, wages must be paid
                        {
                            // 6 - Wages ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                            // a) For each agent B employed by A, transfer a certain amount of wealth
                            for (int j = 0; j < trabalhadores.Count; j++)
                            {
                                b = trabalhadores[j];               // Worker index
                                m = rnd.Next(smin, smax + 1);       // Random salary
                                m = (m <= Riquezas[a]) ? m : rnd.Next(Riquezas[a] + 1); // If m > wealth of A, take a fraction
                                Riquezas[b] += m;                   // Deposit wage in B
                                Salarios[b] += m;                   // Save income increase
                                Riquezas[a] -= m;                   // Deduct from A's wealth
                            }
                        }
                    }

                    // Annual data collection
                    if ((i + 1) % (12 * N) == 0)  // For monthly: N; For yearly: 12*N
                    {
                        //Console.WriteLine("N: {0} - Year {1}", N, ano);
                        ano += 1;
                        texto.Clear();
                        for (int j = 1; j <= N; j++)
                        { texto.AppendFormat("{0:d} {1:d} {2:d} {3:d} {4:d} {5:d}\n", Riquezas[j], Agentes[j], ano, Salarios[j], Lucros[j], j); Salarios[j] = 0; Lucros[j] = 0; }
                        File.AppendAllText(arquivo.ToString(), texto.ToString());
                    }
                }
            }
        }
    }
}
