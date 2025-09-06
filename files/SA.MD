# Social Architecture of Capitalism

I don’t want to write too much about this model because I want you to access my  paper: [Inequality in a model of capitalist economy](https://arxiv.org/abs/2410.22369). Besides that, it is recommended to read:  
- [The social architecture of capitalism](https://www.sciencedirect.com/science/article/abs/pii/S0378437104010726): The original paper where the model was proposed (also included in chapter 13 of the book *Classical Econophysics*).  
- [Agent-Based Models, Macroeconomic Scaling Laws and Sentiment Dynamics](http://macau.uni-kiel.de/servlets/MCRFileNodeServlet/dissertation_derivate_00004144/thesis_linlin.pdf): A thesis discussing the model and some modifications.  
- [Implicit Microfoundations for Macroeconomics](https://papers.ssrn.com/sol3/papers.cfm?abstract_id=1726698#): A modification proposed by Ian Wright himself.  The

But I can say that, in general, the central result of this model is that the unequal structure of wealth distribution that emerges in capitalist societies is an intrinsic feature of how capitalism organizes the production and distribution of commodities, and not a punctual failure due to any external reason outside capitalism itself. Given this fact, we have only three options: 1) accept it, 2) try to mitigate it through reforms (e.g., wealth taxes), 3) replace it with a new mode of production.

The search of a first-principle model capable of elucidating the emergence and robustness of Pareto's law in various contexts is a central challenge in the field of Econophysics. Such a model would provide a fundamental understanding of the mechanisms that drive these distributions, transcending mere empirical observations to reveal the possible underlying principles.

In his seminal work "The Social Architecture of Capitalism",  Ian Wright explores the intricate dynamics that results in the self-organization of a capitalist society with a given distribution of wealth among its members. Using an agent-based model known as Social Architecture (SA) model, Wright provides a theoretical framework aiming to explain the ubiquitous presence of Pareto's law, which reflects that a small percentage of a population controls a large portion of a particular resource such as wealth or income. Wright's work offers insights into how individual interactions and institutional structures collectively shape economic distributions.  

## Model

The model implemented in this paper is the original SA proposed by Ian Wright. However, we have chosen a slightly different notation and terminology to align with those commonly used in econophysics and agent-based modeling.
The society consists of $N$ agents (labeled $i=1,\dots,N$), where each agent $i$ has a positive integer quantity $w_i(t)$ representing money which varies over time. An agent is not necessarily an individual, but can represent other economic entities.

The population size $N$ and the total wealth of the system $W= \sum_{i=1}^N w_i(t)$ are conserved, so the wealth per capita $\overline{w}=W/N$ is constant.
Agents can be in one of three classes: employees (working class), employers (capitalist class), or unemployed.
Then, each agent is characterized by an index $e_i\neq i$, which identifies their employer: $e_i = j$ if agent $j$ is the employer of agent $i$, and $e_i = 0$ if agent $i$ is unemployed or employer.
Therefore, at any time $t$,  the state of the entire economy is defined by the set of pairs $S(t) = \left\{ \left( w_i(t), e_i(t) \right) :1\leq i\leq N \right\}$. A firm  consists of a set of employees and an employer, which is the only owner of the firm.

In addition to the system size $N$ and the wealth per capita $\overline{w}$, there are two other parameters:
the minimum and maximum wages, $p_a$ and $p_b$, that each employee can receive. These four are the only parameters of the model.
Random selections (of agents, wealth aliquots, wages, etc.) are made uniformly, unless otherwise specified.

In the initial state, all agents have the same wealth ($w_i(0)={W}/N$) and are all unemployed ($e_i(0)=0$).
At each time step (which we set to be a month as in the original paper), the following six steps are executed $N$ times, to give each agent the opportunity to be active once per month on average.


1. **Agent selection**:

- An agent $i$ is randomly selected.

Then, the following rules are applied, being 3, 4 and 6 related to wealth exchanges, while rules 2 and 5 are related to changes of status.  


2. **Hiring** Only if $i$ is unemployed, then:
- A potential employer $j$ is selected from the set $H$  of all agents except the employees, with probability  $P (j)= w_{j}/\sum_{n\in H}w_{n}$.
-   If $ w_j \ge \overline{p}$  (average of the distribution from which the wage  is drawn), then: the agent $i$ is hired by $j$. Hence $j$ becomes an employer if it was previously unemployed.

3. **Expenditure** (on goods and services):

- A random integer $w$ in the range $\left[0,w_{k}\right]$ is selected for a random agent $k\neq i$.
 Then, the following transfer to the market value $V$ occurs:
 \begin{equation} \notag
 w_k  \to w_k-w, \quad V \to V+w.
 \end{equation}

4. **Market revenue** (from sales of goods and services):

- Only if $i$ is not unemployed, the following transfer from the market value occurs:   

\begin{eqnarray}   \notag
   && \;\;\;\;\;V \to V-w, \\  \notag
%   
&& \begin{cases}
  w_i\to w_i+w ,         &\mbox{if  $i$ is employer,}\\
  w_{e_i}\to w_{e_i}+w , &\mbox{if  $i$ is employee,}
\end{cases}
\end{eqnarray}

where $w$ is a random integer number $w\in \left[0,V\right]$. In all cases,  the quantity $w$ is counted as firm revenue $r_i$.

5. **Firing** Only if $i$ is an employer, then:

- The number $m$ of employees to be fired is defined according to the  formula
$ m=max(n_{i}-\frac{w_{i}}{\overline{p}},0)$,  where $n_i$ is the number of employees of agent $i$.
- A number $m$ of agents from the list of $i$'s employees are randomly selected to be fired.
-Furthermore,  if all the workers are fired, then the employer $i$ becomes an unemployed.


6. **Wage payment** Apply only when agent $i$ is an employer.
For each agent $j$ employed by $i$, the following transfer occurs  
 \begin{equation} \notag
 w_i  \to w_i-p, \quad w_j  \to w_j+p.
 \end{equation}

where $p$ is a discrete amount  randomly selected from the interval $[p_a,p_b]$, but if $p > w_i$, then a new wage $p$ is selected from the interval $[0,w_i]$.

## Simulation

I was going to write the code in Python, but since I already have it in C#, I’ll share it in C# for now, [here](https://github.com/jdansb/Econophysics/blob/main/files/SA_model.cs). Another day, when I have more time, I might translate the variable names (they’re in Portuguese) or even rewrite the code in Python.  

In the same way, I’ll also bring the main results of the paper [here](https://arxiv.org/html/2410.22369v2).

<div style="text-align: center;">
<img src="https://arxiv.org/html/2410.22369v2/extracted/6271380/facw-class.png" width="500">
</div>
This graph shows the complementary cumulative distribution (CCDF) of wealth, as well as its social composition.  

We can observe that up to approximately $10^3$ coins, capitalists make up less than 10\% of the agents holding such wealth. The vast majority of agents with wealth between 0 and $10^3$ are employees or unemployed.  

Above this threshold, the probability of finding an agent with that level of wealth decreases sharply, until only a small fraction concentrates amounts on the order of up to $10^5$ coins.  

Considering that this simulation involved approximately $10^5$ agents and an average wealth of 100 coins per capita, the total wealth in the system is about $10^7$ coins. This implies that, in the extreme, a single capitalist is capable of concentrating virtually all the available wealth.


<div style="text-align: center;">
<img src="https://arxiv.org/html/2410.22369v2/extracted/6271380/wealth.png" width="500">
</div>

This also becomes evident when we separate wealth by class.  Above $10^3$, there is basically no possibility of finding an agent who does not belong to the capitalist class.  Conversely, practically 100\% of capitalists hold a wealth of at least $10^2$.

<div style="text-align: center;">
<img src="https://arxiv.org/html/2410.22369v2/extracted/6271380/incomes.png" width="500">
</div>


The income distribution follows a pattern similar to wealth. When we distinguish between the source of income (revenue as a firm owner, or wage as an employee), we can notice that the pattern repeats.  

All these results are consistent with real-world data, which point to the existence of **two regimes** in the wealth distribution of society: an exponential distribution (Boltzmann-Gibbs-like) for the majority of the population with lower income, and a power-law distribution (Pareto-like) for the small fraction of the super-rich population with higher income.

