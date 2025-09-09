1. [Statistical approximation of the law of value (ABM)](https://github.com/jdansb/Econophysics/blob/main/files/aproximacao_estatistica_da_lei_do_valor_ABM.ipynb) 
2. [Statistical approximation of the law of value (EBM)](https://github.com/jdansb/Econophysics/blob/main/files/Statistical_approximation_of_the_law_of_value_(EBM).ipynb)
3. [Social Architecture of Capitalism](https://github.com/jdansb/Econophysics/blob/main/files/social_architecture.ipynb) *in progress*
4. [Possible Measure of Labor Content](https://github.com/jdansb/Econophysics/blob/main/files/medida_do_trabalho_contido.ipynb)
5. [A Probabilistic Framework for Labor](https://github.com/jdansb/Econophysics/blob/main/files/Probabilistic_Framework.ipynb) *in progress*
6. Labor Content: Properties and Postulates
7. Some Universal Patterns in Income Distribution: An Econophysics Approach
8. On the Statistical Physics of Wealth Distribution
9. ??
----

# Statistical Laws, Agent-Based Modeling, and Econophysics
My intention in this section is to provide a general overview of how research in this field is conducted and, to some extent, what motivates its existence. For those who wish to delve deeper, virtually every book in the area begins by offering a historical contextualization of the field’s development. Below, I highlight three works that I consider particularly useful for those seeking an introduction to the subject:

- **Classical Econophysics** (Cottrell, Cockshott, Michaelson, and Wright): An introduction to econophysics itself, with an emphasis on the attempt to reconcile classical physics methods with economic theory.  
- **Statistical Laws in Complex Systems** (Altmann): Discusses how research is conducted in complex systems that exhibit statistical laws as emergent properties — a typical feature of studies in econophysics.  
- **An Introduction to Agent-Based Modeling** (Wilensky and Rand): Presents the fundamentals of agent-based modeling, the primary computational approach used to construct microscopic models aimed at reproducing the statistical laws observed in the complex systems under investigation.  

Other readings I consider useful include *Laws of Chaos: A Probabilistic Approach to Political Economy* (Farjoun and Machover), *How Labor Powers the Global Economy* (Farjoun, Machover, and Zchariah), and *Agent-Based Models, Macroeconomic Scaling Laws and Sentiment Dynamics* (Lin Lin).

We can also mention other well-known works, such as *Essentials of Econophysics Modelling* (Slanina) and *Econophysics: An Introduction* (Sinha, Chatterjee, Chakraborti, and Chakrabarti), as well as a Brazilian work authored by an economist: *[Economia da complexidade: Econofísica](https://fernandonogueiracosta.wordpress.com/wp-content/uploads/2024/09/fernando-nogueira-da-costa-economia-da-complexidade-ou-econofisica-ago-2024.pdf)* (Fernando Nogueira da Costa)[^1].

## Statistical Laws

We begin the discussion from a more general perspective, addressing the relationship between statistical laws and complex systems[^2]. Currently, research in various fields treats their objects of study as complex systems, in which statistical laws appear as emergent properties. This is the case in econophysics, where we understand the economic system as a complex system, from which statistical laws (also known as stylized facts) emerge. Although often perceived as disconnected, these studies typically employ a common approach.

This pattern in the way investigations are conducted in different specific cases is a clear indication that this set of cases actually constitutes a research field with its own scientific methodology. The scientific importance of the process of identifying patterns is universally recognized — a fundamental step in research in physics, as traditionally understood.

Thus, the first connection we can establish between econophysics and the traditional way of doing science lies in the centrality of the pattern-identification process. Quetelet, for instance, in the 19th century, sought to identify patterns in data related to births, age at marriage, criminal activities, and mortality rates.

Before proceeding, it is necessary to define what a complex system is: Complex systems are composed of numerous microscopic components that interact with each other, giving rise to nontrivial phenomena at macroscopic scales. These phenomena, which cannot be found in the individual components of the system, are called emergent phenomena, i.e., properties that arise from the interaction of the system's components. In physics, gases can be cited as an example of a complex system, with pressure as an emergent property. The pressure of a gas is not merely the sum of the "pressure contained" in each particle, but rather the result of the interactions among the particles that constitute the gas.

Within the context of complex systems, these patterns are typically described not by deterministic laws, but by statistical laws. These statistical laws, in turn, should be understood as emergent properties with inherent statistical characteristics, which can be produced at the macroscopic scale from microscopic models of complex systems.

A statistical law must possess two characteristics to truly deserve the designation. First, it must be a mathematical law that different systems exhibit in order to genuinely qualify as a *law*. Second, it must necessarily have a statistical nature. That is, the law manifests itself in terms of statistical quantities (e.g., distributions, probabilities, averages, etc.), values that can only be obtained from a large number of measurements.

Having defined the object of study (complex systems that exhibit a statistical law as an emergent property), we can characterize a standard method of investigation:  
1. Initially, the description of patterns observed in the system through statistical laws;  
2. Subsequently, the development and use of microscopic models capable of generating these macroscopic laws.

This approach to science represents a new paradigm in the investigation of social reality. Statistical laws are functions with few parameters, proposed to describe large sets of data across different scenarios. This allows not only for a summary of the data but also for analytical analyses and opens the possibility for theoretical investigation. Studies of statistical laws should not be regarded as mere curiosities; their investigation aims to reveal the most fundamental properties of the system under study.

In the tradition of social physics, statistical laws were viewed as analogous to the empirical laws of physics. Thus, the term "social physics" was associated with the search for law-like behaviors in society, and the idea that there existed laws relating to society — just as Newtonian mechanics related to the motion of the planets — was shared by many at the end of the 17th century. The expectation of social physics was that it would evolve as a discipline in a manner similar to the historically developed progression of classical mechanics: observations → empirical laws → universal laws.

In other words, the community first makes a large set of observations and is able to extract various specific empirical laws from these observations. Then, from these empirical laws, it becomes possible to abstract more general laws that explain both the empirical laws for different specific cases and the observed data. Examples of empirical laws include those of Kepler and Galileo; as a universal law, we have Newton. Although there is no very clear definition, we can think of the difference as lying in scope: while empirical laws have a more limited validity, a universal law provides a more fundamental and comprehensive description of reality, being capable of explaining multiple empirical laws.

From this perspective, statistical laws would play the role of empirical laws, serving as the crucial intermediate step between empirical observations and the development of universal laws. However, this simplistic analogy overlooks the fundamental statistical nature of statistical laws, which are essentially different from Kepler’s law. Nonetheless, a positive aspect of this naive view, retained in contemporary applications of statistical laws, is the expectation that they connect observations to more general theoretical models — even if these models are not necessarily based on equations.

This more general model can be either conceptual or computational (for example, an agent-based model, as we will see below). Occupying the position of a "universal law," we can seek more general microscopic (or conceptual) models capable of reproducing (or explaining) not just a single statistical law, but several.

It is primarily the combined use of statistical laws and microscopic models of complex systems that characterizes the investigation of wealth distribution in econophysics as it is practiced today. There are three changes in the way social physics was approached that deserve highlighting, which were caused by the adoption of the complex systems approach:

1. Not viewing statistical laws as a mere effect of independent random influences, expected to appear in isolated parts of the system, but rather as an emergent property of a complex system.  
2. The interest in the laws goes beyond practical applications or philosophical discussions; they serve as motivations and justifications for the proposition of mechanistic models of the system's microscopic foundations.  
3. The theoretical explanation of the laws does not follow the classical mechanics paradigm, but that of statistical mechanics, i.e., based on probabilistic models.


### Formalization

A statistical law (in complex systems) is a function that:  
1. Has been proposed to describe a large number of observations across different scenarios (universality);  
2. Is elementary or a composition of elementary functions with a small number of parameters and dimensions (simplicity);  
3. Plays an important role within a theory or model (theoretical connection).

Typically, a statistical law applies to a dataset and describes either the frequency of occurrence of something or the relationship between two properties of the observed system. Universality expresses our intention that the law should be valid for all similar cases, not limited to a few specific instances. Simplicity can be expressed mathematically, indicating that the dimensionality of the functions should be much smaller than the number of observations. There is an implicit idea that one should seek the smallest possible number of parameters to achieve simplicity — we do not simply aim to fit a curve to the data. Finally, these laws play a central role by serving as a theoretical connection between the observed data and microscopic models, which should provide a mechanistic explanation of the law and/or be used within a more general theory regarding the foundations of the system.

Before concluding this section, a brief justification for why we hold the idea that something can be generalized as statistical laws is in order. This stems from the observation that different statistical laws appear to be motivated, justified, applied, and studied in a similar manner. In general, the reasoning with statistical laws follows a sequence of three connected steps.

* **Definition and Validation**: We begin with an empirical analysis. The initial step is inevitably analogous to all science: the examination of a large set of observations. It is at this stage that we detect patterns in the data and propose a statistical law. It is also at this stage that we test the validity of the proposed law on other datasets. Evidently, this step undergoes various reformulations, generalizations, modifications, and all manner of traditional scientific processes.

From this step, the next two steps occur in parallel; that is, once the statistical law proposed in the previous step is established, there are two paths to pursue:

* **Explanation of the Law**: Explaining the statistical law involves the development of a generative model, that is, a model capable of generating a distribution that obeys the statistical law. Once the statistical law is considered empirically valid, an obvious question to investigate is its origin. To this end, we propose simple mechanistic models that generate observations satisfying the statistical laws.

* **Consequences of the Law**: A second question that arises after considering the statistical law valid is what the consequences of this law are. This involves extrapolating its implications beyond what has been observed so far — that is, predictions based on the law itself, its relationship with other laws, its use as a constraint in other models, and so on. The predictive capacity of a law is frequently regarded as the primary objective in traditional research.

Essentially, what we do is associate a statistical (macroscopic) law necessarily with a generative (microscopic) model, adopting this method as the standard approach. We can then note that investigations in this area have three fundamental elements:  
1. A complex system to be investigated;  
2. A statistical law emerging from this system;  
3. A generative model capable of reproducing the statistical law at the macroscopic level from microscopic rules.

I adopt, as the concept for modeling the generative model, agent-based modeling. Therefore, we will address this concept in the next section. It is also worth briefly noting that this modern approach to doing science becomes feasible only when there is sufficient data about societies to allow the proposal and testing of statistical laws, and sufficient computational power to implement the models. In other words, it is necessarily a product of our time.


## Agent-Based Modeling (ABM)

In general, a model is always an abstraction of reality — a simplified representation that preserves an appropriate equivalence for certain situations, and can be seen as a substitute view of reality, aimed at facilitating reasoning.

Since our goal through models is to simulate reality, the efficiency of a model depends on the accurate translation of reality into the model. Therefore, it is important to reflect on the model even before the act of modeling begins. It is necessary to identify the relevant variables for the problem at hand and to define the language that will be used, as the construction of the model depends on these crucial points[^3].

Since a model is a simplification of reality, it is possible for the same reality to be modeled in different ways, given that no model is reality itself. One example is the most traditional form of scientific models in physics: models based on differential equations — *equation-based model (EBM)*. Another modeling approach, which has become increasingly popular, is *agent-based modeling (ABM)*. This is a computational modeling approach in which the dynamics of a complex system are represented in terms of agents and their interactions.

Agents are autonomous computational individuals that possess properties and behavioral rules governing their interactions with other agents and the environment. Recall that complex systems are defined as systems composed of multiple individual elements that interact with each other and exhibit behavior that cannot be predicted solely from the properties of the individual elements. The result of these interactions is the emergence of an emergent phenomenon. An emergent phenomenon necessarily possesses two essential characteristics:

1. **Irreducibility**: The structures that emerge cannot be deduced solely from the properties of the individual elements, as they arise from the interactions among them. In other words, they are properties of the system as a whole, not of the isolated elements that compose it.  
2. **Self-organization**: The phenomenon arises spontaneously, without the presence of a central coordinator.  Emergence can thus be understood as the process that maintains the system's structure.

The central proposal of agent-based modeling is that most real-world phenomena can be effectively modeled with three elements: agents, an environment, and a description of agent-agent and agent-environment interactions. The objective of this type of modeling is to create agents and rules that generate the desired behavior — in our context, the behaviors described by statistical laws. Once created, this system can be used to gain a better understanding of the modeled phenomenon through experimentation with different rules and properties, aiming to test various hypotheses.


There are eight main uses for an agent-based model[^4]:

1. **Description**: Provides a simplified representation of a real-world system.  
2. **Clarification**: Highlights the main mechanisms involved in a phenomenon.  
3. **Experimentation**: Can be run repeatedly, allowing the variation of parameters to observe their effects on the overall system behavior and the outcomes generated.  
4. **Prediction of analogy sources**: Enables the identification of similarities with other simplifications, even if they model seemingly very different phenomena.  
5. **Communication / Education**: Can be used to allow people to explore and better understand certain phenomena, even without mastering all the details of the model, facilitating learning.  
6. **Providing core pieces for scientific dialogue**: Also called a "thinking object," when compared to textual models, it eliminates interpretational ambiguities and allows for a more objective discussion of which mechanisms are relevant to generating a given behavior — through controlled removal or addition of mechanisms in the model.  
7. **Thought experiment**: Does not necessarily need to represent a real-world phenomenon; it can be limited to a conceptual experiment.  
8. **Projection of future patterns**: Based on the description of past patterns, it is expected to be possible to explain or anticipate future patterns that may emerge.


Since EBMs are the approach with which physicists and scientists, in general, are most accustomed to modeling systems, it becomes natural to make a brief comparison between the two modeling strategies: EBM (equation-based model) and ABM (agent-based model). The first point is that ABMs can easily model heterogeneous populations of agents, whereas EBMs generally assume homogeneity. In many fields, however, heterogeneity plays a central role in the behavior of the system.

Another advantage of the ABM approach is that, while modeling with equations requires a good phenomenological understanding of the internal mechanisms of the system of interest, ABMs only require knowledge of the rules at the individual level — which is generally more straightforward to obtain. A major risk in the modeling process, in general, is modeling the effects rather than the causes. Due to the more direct individual-level approach of ABMs, we start precisely from the idea of modeling the interactions among agents so that the emergent phenomenon of interest is a result of the system. This allows us, naturally, to focus on the causes to understand the effects.

The outputs of an ABM also tend to be more detailed, as they are not limited to the system level but also include information at the individual level. Agent-based modeling allows for maintaining a history of interactions among agents, and this history can be used for agents to adjust their behaviors and strategies based on past events. This makes the approach a very useful tool for modeling complex interactions among adaptive agents. Due to the way ABMs are constructed, new interaction rules can be added, removed, or modified with relative ease.

Another important difference is that, while an ABM naturally represents discrete results often with fluctuations, an EBM provides a continuous and noise-free representation. Naturally, there are situations in which the cost of building an ABM outweighs its benefits. More detailed results are obtained with more complex models, which require greater computational power. In general, ABMs are computationally heavier than EBMs, as the latter are relatively simple, often consisting of a small set of equations that can be solved numerically or even analyzed around equilibrium points. Generally, if the problem involves a large number of homogeneous agents, a more precise solution can be obtained more quickly using an equation-based approach. Therefore, such a problem may be better modeled by this category of models.

As can be seen, agent-based modeling is more a conceptual framework for constructing a model than a strict recipe. The choice between ABM and EBM depends on what and how we want to model; there is no method that is intrinsically superior to the other. Within the context we are discussing we are interested in microscopic-level modeling capable of generating the statistical law as an emergent property of the system. In this way, using an ABM is more appropriate.

Once a satisfactory model is constructed, one of the most important roles of modeling is simulation, as it allows us to determine how closely the model approximates reality. Once an acceptable level of fidelity is achieved for the aspect the model aims to represent, we can create situations that are difficult to observe and study in the real world, allowing the model to also serve as a decision-making tool.

Before proceeding, it is worth noting that these models are always suggestive. That is, they only demonstrate that a given phenomenon is not inconsistent with the consequences of the computable logic of our model. We cannot know whether there exists an even simpler model that can reproduce the same phenomenon, but we can know that a more complex model is not necessary[^5].

## Econophysics

Once we understand the relationship between complex systems and statistical laws, and grasp the concept of modeling used to generate generative models, we can briefly discuss what econophysics is.

Auguste Comte, at the beginning of the 19th century, was responsible for coining the term "social physics" as an explicit reference to the success of Newtonian mechanics. Although he later abandoned the term, it was later revived by his successors, particularly Adolphe Quetelet, an astronomer by training, who published an essay on social physics in 1835. Another influential intellectual in the development of the field was historian Henry Buckle, who introduced a statistical approach to the history of civilization.

Among this list of illustrious names, we can also mention Friedrich Engels[^6], who, still in the 19th century, postulated that, although each individual has personal will, the multiple individual wills existing in a society intersect and even conflict with one another. From the clash of these wills, we would obtain a state analogous to what is found in a nature devoid of consciousness. This observation opens up the possibility of modeling social phenomena with tools analogous to those used in the natural sciences.

At the same time as Quetelet, Georg Graf considered applying the principles of classical mechanics specifically to economics. His knowledge of Newtonian physics was profound, and he contributed to various areas of science. A text of his from 1815 already presented what could be considered a chapter of an economics book, explicitly referring to classical mechanics — a revolutionary way of thinking for his time.

In the second half of the 19th century, a similar attempt was made by Vilfredo Pareto. Pareto also turned to economics armed with a solid understanding of Newtonian classical mechanics and with enthusiasm for describing social movements in the same way as the motion of planets was described. He even compared Kepler's laws to economic laws that were yet to be discovered. Pareto's law on the distribution of wealth became a fundamental piece of economic knowledge. However, his ambition to reduce economic laws to something analogous to Newton's laws remained incomplete.

Methods of probability and statistics first flourished among social scientists investigating quantitative regularities in the functioning of society. Only later did physics move from the determinism of Newtonian mechanics toward the probabilistic description of ideal gases, thereby adopting the existing statistical tools. It is remarkable how these concepts, initially developed outside physics, ended up directly influencing the development of the discipline itself. If, today, physicists resort to the analogy between molecules and humans to investigate social questions, Boltzmann had a similar — but inverted — analogy in mind when investigating gases, drawing inspiration from society to analyze a typically physical phenomenon. In a passage from his 1872 article, he mentions:

> “Molecules are like many individuals, each having a variety of states of motion, and the properties of gases remain unchanged only because the number of these molecules, which on average have a given state of motion, is constant.”

In the history of the development of econophysics, a decisive milestone in the discussion of the interaction between physics and economics was the introduction of the concept of fractals by Benoit B. Mandelbrot. Another significant moment was the conference scheduled to take place in Moscow in 1974, organized by figures such as Kenneth Arrow (Nobel laureate in economics) and Hans Bethe (Nobel laureate in physics). Although the event was canceled, it played an important role in transferring ideas and the language of physics to other areas of human knowledge. Its manuscripts survived, and some were later published, directly influencing the future development of econophysics.

Following this event, further attempts to integrate physics with other disciplines began to flourish even more intensely. Between the 1970s and 1980s, complexity science gained enormous popularity, with the Santa Fe Institute playing an active role in this process. It was in this context that complex systems theory began to be systematically applied to economics. Nobel laureate physicist P. W. Anderson became deeply involved in this line of research, actively promoting the use of physics methods in social and economic problems. In 1991, the journal *Physica A* published what is today considered the first paper that can truly be attributed to the newly born field of econophysics.


But what exactly econophysics is remains an open question — there is no clear consensus. According to Slanina, it is not a simple blend of natural sciences and economics, nor an interdisciplinary science between economics and physics[^7]. He prefers to call it transdisciplinary, as the goal is not to occupy a position between disciplines, but rather to find principles that hold true in both. In other words, it is a search for common principles, shared tools, and equivalent consequences.

Another relevant point for the discussion is how econophysicists direct their efforts. Econophysics is not limited to taking a fragment of theoretical physics and reinterpreting it in the language of economics. A 2022 report[^8] on social physics adopts a broader definition than that of Slanina: social physics is a collection of research topics aimed at solving social problems, in which scientists with formal training in physics have contributed and continue to contribute significantly. Although broader definitions often generate debate, this is a pragmatic definition, based on the idea that what physicists actually do defines what physics is.

The enormous success of physics over the past century has led scientists from other disciplines to attempt to formulate quantitative methods similar to those of physics. In general, this resulted in a proliferation of mathematical and physical models across various fields of knowledge. And if we are to use methods analogous to those of physics, who better than physicists themselves to contribute? Thus, this collection of topics focusing on social problems, with physicists as the main professionals involved, is called social physics.

Although social physics is not new, this trend has re-emerged with greater intensity in recent times. This is due not only to recent advances in the technology necessary for its implementation but also as a result of a slowdown in the rate of scientific progress in traditional physics, at least compared to the previous century. This phenomenon generates, on the one hand, a movement of physicists in search of a "new physics," and on the other, young scientists who have decided to apply their quantitative skills to other topics.

The themes of social physics often arise from reflection on what constitutes and sustains modern life, as well as what disrupts or threatens it. The prosperity of cities is, in many respects, tied to markets, and the economy has a profound impact on the development and planning of urban life. It is in this context that the field of econophysics emerges more specifically.

Unlike traditional economics, which is built upon a model of rational choice, econophysics stands out by initially borrowing the particle model from statistical physics to explain agent behavior. This form of modeling assumes that agents’ interests and preferences are not fixed but depend on interaction with other agents. In other words, econophysics places great emphasis on the agent's social environment.

Traditionally, econophysics has focused on issues such as the flow of money and financial markets, due to the availability of large datasets that allowed the effective application of tools and methods from statistical physics in these areas. Areas such as macroeconomics have historically not attracted the attention of econophysicists. However, with the growth of the field, increased data availability, and advances in computational power in recent years, econophysicists may play an important role in the future development of macroeconomics.

In conclusion, based on everything studied and discussed so far, econophysics can be understood as a methodology for investigating economic problems, which explains the ‘econo’ part of its name. Developed by physicists, it often applies methods inspired by techniques from physics, hence the ‘physics’ in the name. This methodology, especially when discussing wealth distribution, includes obtaining and verifying statistical laws and developing generative models (often based on agent-based modeling) capable of generating these statistical laws as an emergent phenomenon. Importantly, econophysics is not intended to propose an economic theory; rather, its focus is on providing quantitative tools and methods that support and complement existing theoretical frameworks. Furthermore, it can be noted that interdisciplinary endeavors of this nature contribute to bridging the natural sciences and the human sciences. As Karl Marx[^9] stated:

> “We know only one science, the science of history. History can be examined from two sides, divided into the history of nature and the history of humanity. The two sides, however, cannot be separated; as long as humanity exists, the history of nature and the history of humanity will condition each other.”


[^1]: There is also an interesting popular science article entitled *[The Physics of Human Particles](https://cienciahoje.periodicos.capes.gov.br/storage/acervo/ch/ch_342.pdf)* (Celia Anteneodo).  
[^2]: The full discussion can be found in the book [*Statistical Laws in Complex Systems*](https://arxiv.org/abs/2407.19874) (Altmann).  
[^3]: [*In Search of the Applicability of Artificial Societies in Educational Informatics*](https://lume.ufrgs.br/bitstream/handle/10183/12181/000617438.pdf?sequence=1&isAllowed=y) (Henrique Oliveira da Silva) and *[Combinatorial Optimization and Linear Programming: Models and Algorithms](https://web.ist.utl.pt/luis.tarrataca/classes/linear_programming/OtimizacaoCombinatoriaeProgramacaoLinear.pdf)* (Marco Goldbarg) serve as references for this discussion on models.  
[^4]: The full discussion can be found in the book *An Introduction to Agent-Based Modeling* (Wilensky and Rand).  
[^5]: Comment originally found in *Classical Econophysics* (Cottrell, Cockshott, Michaelson, and Wright).  
[^6]: *Anti-Dühring* (Friedrich Engels).  
[^7]: *Essentials of Econophysics Modelling* (Slanina).  
[^8]: *[Social Physics](https://www.sciencedirect.com/science/article/abs/pii/S037015732100404X)*.  
[^9]: *The German Ideology* (Friedrich Engels and Karl Marx).  
