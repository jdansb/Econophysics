using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            int N = 500;
            int L = 10;
            double M = 100.0 * N;
            double[,] E = new double[N, L];
            var A = new int[N];
            var Erro = new double[N];
            double[,] D = new double[N, L];
            var m = new double[N];
            double[] l = { 1.0 / 1.0, 1.0 / 1.2, 1.0 / 1.4, 1.0 / 1.6, 1.0 / 1.8, 1.0 / 2.0, 1.0 / 2.2, 1.0 / 2.4, 1.0 / 2.6, 1.0 / 3.8 };
            double[] c = { 1.0 / 20, 1.0 / 20, 1.0 / 20, 1.0 / 20, 1.0 / 20, 1.0 / 20, 1.0 / 20, 1.0 / 20, 1.0 / 20, 1.0 / 20 }; 
            List<double>[] trocas = new List<double>[L];
            for (int i = 0; i < trocas.Length; i++)
            { trocas[i] = new List<double>(); }
            Random rnd = new Random(0);
            int[] trabalhadores = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < L; j++)
                {
                    D[i, j] = 0.0;
                    E[i, j] = 0.0;
                }
                m[i] = M / N;
                A[i] = rnd.Next(L);
            }

            for (int step = 0; step < 500000; step++)
            {
                for (int i = 0; i < N; i++)
                {
                    //P1
                    int k = A[i];
                    trabalhadores[k]++;
                    //C1
                    E[i, k] += l[k];
                    for (int j = 0; j < L; j++)
                    {
                        D[i, j] += c[j];
                        int consumo = Math.Min((int)D[i, j], (int)E[i, j]);
                        D[i, j] -= consumo;
                        E[i, j] -= consumo;
                    }
                }
                //E1
                List<int> Nres = new List<int>();
                for (int i = 0; i < L; i++)
                { Nres.Add(i); }
                var Tentativa = new int[N];
                for (int i = 0; i < N; i++)
                { Tentativa[i] = L * 250; }
                while (Nres.Count > 0)
                {
                    int k = rnd.Next(Nres.Count);
                    int j = Nres[k];
                    List<int> compradores = new List<int>();
                    List<int> vendedores = new List<int>();
                    for (int i = 0; i < N; i++)
                    {
                        if ((int)E[i, j] > (int)D[i, j] && Tentativa[i] > 0)
                        { vendedores.Add(i); }
                        if ((int)E[i, j] < (int)D[i, j] && Tentativa[i] > 0)
                        { compradores.Add(i); }
                    }
                    if (vendedores.Count == 0 || compradores.Count == 0)
                    { Nres.Remove(j); }
                    else
                    {
                        int buy = compradores[rnd.Next(compradores.Count)];
                        int sell = vendedores[rnd.Next(vendedores.Count)];
                        double pbuy = rnd.NextDouble() * m[buy];
                        double psell = rnd.NextDouble() * m[sell];
                        double minimo = Math.Min(pbuy, psell);
                        double maximo = Math.Max(pbuy, psell);
                        double preco = rnd.NextDouble() * (maximo - minimo) + minimo;
                        Tentativa[buy]--;
                        Tentativa[sell]--;
                        if (m[buy] >= preco)
                        {
                            m[buy] -= preco;
                            m[sell] += preco;
                            E[buy, j]++;
                            E[sell, j]--;
                            trocas[j].Add(preco);

                        }
                        else { falhas[j]++; }
                    }

                }

                //S1
                if (step % 40 == 0)
                {
                    double e = 0;
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < L; j++)
                        {
                            e += D[i, j] * D[i, j];
                        }
                        e = Math.Sqrt(e);
                        if (e > Erro[i])
                        {
                            int k = A[i];
                            while (k == A[i])
                            { k = rnd.Next(L); }

                            A[i] = k;
                        }
                        Erro[i] = e;

                    }
                }
                if (step % 50000 == 0)
                {
                    for (int i = 0; i < L; i++)
                    {
                        double media = 0; 
                        foreach (var valor in trocas[i])
                        { media += valor; }
                        media /= trocas[i].Count;
                        double trabalhadoresMedia = trabalhadores[i] / 50000;
                        Console.WriteLine($"{step} | Preço Médio {i}: {media} | Trabalhadores {trabalhadoresMedia}");
                        trocas[i].Clear();
                        trabalhadores[i] = 0;
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
