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


## Modelagem baseada em agentes (MBA)

De forma geral, um modelo é sempre uma abstração da realidade — uma representação simplificada que preserva uma equivalência adequada para determinadas situações, podendo ser visto como uma visão substitutiva da realidade, com o objetivo de facilitar o raciocínio.

Uma vez que, por meio dos modelos, buscamos simular a realidade, a eficiência de um modelo depende da correta tradução da realidade para o modelo. Por isso, é importante refletir sobre o modelo antes mesmo do ato de modelagem começar. É necessário identificar as variáveis relevantes para o problema que será abordado e definir a linguagem que será utilizada, pois a elaboração do modelo depende desses pontos cruciais[^3].

Uma vez que o modelo é uma simplificação da realidade, é possível que uma mesma realidade seja modelada de diferentes formas, já que nenhum modelo é a realidade em si. Um exemplo é a forma mais tradicional de modelos científicos na física: os modelos baseados em equações diferenciais — em português, modelo baseado em equações (MBE); em inglês, *equation-based model (EBM)*. Outra forma de modelagem, que tem se tornado cada vez mais popular, são os modelos baseados em agentes (MBA) — em inglês, agent-based models (ABM). Essa é uma abordagem de modelagem computacional na qual a dinâmica de um sistema complexo é representada em termos dos agentes e de suas interações.

Os agentes são indivíduos computacionais autônomos que possuem propriedades e regras de comportamento que regem sua interação com outros agentes e com o ambiente. Lembrando que sistemas complexos são definidos como sistemas compostos por múltiplos elementos individuais que interagem entre si e apresentam um comportamento que não pode ser previsto apenas a partir dos próprios elementos. O resultado dessas interações é o surgimento de um fenômeno emergente. O fenômeno emergente possui necessariamente duas características essenciais:
1. **Irredutibilidade**: As estruturas que emergem não podem ser deduzidas apenas das propriedades dos elementos individuais, pois surgem das interações entre eles. Ou seja, são propriedades do sistema como um todo, e não dos elementos isolados que o compõem.
2. **Auto-organização**: O fenômeno surge espontaneamente, sem a presença de um coordenador central.
3. A emergência pode, assim, ser compreendida como o processo que mantém a estrutura do sistema.

A proposta central da modelagem baseada em agentes é a de que a maioria dos fenômenos do mundo real pode ser efetivamente modelada com três elementos: agentes, um ambiente e uma descrição das interações agente-agente e agente-ambiente. O objetivo desse tipo de modelagem é, então, criar agentes e regras que gerem o comportamento desejado — que, no nosso contexto, são os descritos por leis estatísticas. Uma vez criado, esse sistema pode ser utilizado para obter um melhor entendimento do fenômeno modelado, por meio da experimentação com diferentes regras e propriedades, visando testar diferentes hipóteses.

Há 8 principais usos para um modelo baseado em agentes[^4]:

1. **Descrição**: descreve de maneira simplificada um sistema do mundo real.
2. **Esclarecimento**: aponta os principais mecanismos envolvidos em um fenômeno.
3. **Experimentação**: pode ser executado repetidamente, permitindo variar os parâmetros para observar seus efeitos no comportamento do sistema como um todo e nos resultados gerados.
4. **Previsão de fontes de analogia**: é possível encontrar similaridades com outras simplificações, mesmo que estejam modelando fenômenos aparentemente muito diferentes.
5. **Comunicação / Educação**: pode ser utilizado para que pessoas explorem e compreendam melhor determinados fenômenos, mesmo sem dominar todos os detalhes do modelo, facilitando o aprendizado.
6. **Prover peças centrais para o diálogo científico**: também chamado de "objeto com que pensar", quando comparado com modelos textuais, elimina ambiguidades de interpretação e permite discutir, de forma mais objetiva, quais mecanismos são relevantes para gerar determinado comportamento — por meio da remoção ou adição controlada de mecanismos no modelo.
7. **Experimento mental**: não precisa necessariamente representar um fenômeno do mundo real; pode ser restrito a um experimento conceitual.
8. **Projeção de padrões futuros**: a partir da descrição de padrões passados, espera-se que seja possível explicar ou antecipar padrões futuros que possam surgir.

Uma vez que o MBE é a abordagem com a qual físicos e cientistas, em geral, estão mais habituados a modelar sistemas, torna-se natural fazermos uma rápida comparação entre ambas as estratégias de modelagem: MBE (modelo baseado em equações) e MBA (modelo baseado em agentes). O primeiro ponto é que os MBAs podem modelar populações heterogêneas de agentes com facilidade, enquanto os MBEs geralmente partem da hipótese de homogeneidade. Em muitas áreas, no entanto, a heterogeneidade desempenha um papel central no comportamento do sistema.

Outra vantagem da abordagem MBA é que, enquanto para modelar com equações precisamos ter um bom conhecimento fenomenológico dos mecanismos internos do sistema de interesse, nos MBAs basta conhecermos as regras em nível individual — o que, em geral, é mais direto de se obter. Um grande risco no processo de modelagem, de modo geral, é modelarmos os efeitos em vez das causas. Pela natureza mais direta da abordagem em nível individual dos MBAs, partimos exatamente da ideia de modelar as interações entre os agentes, de modo que o fenômeno emergente de interesse seja o resultado do sistema. Isso nos permite, de forma natural, focar nas causas para compreender os efeitos.

Os resultados de um MBA também tendem a ser mais detalhados, uma vez que suas saídas não se limitam ao nível do sistema como um todo, mas também incluem informações no nível individual. A modelagem baseada em agentes permite manter um histórico das interações entre os agentes, e esse histórico pode ser usado para que o agente altere seus comportamentos e estratégias com base em eventos passados.  Isso torna a abordagem uma ferramenta muito útil para modelar interações complexas entre agentes adaptativos. Devido à forma como os ABMs são construídos, novas regras de interação podem ser adicionadas, removidas ou alteradas com relativa facilidade.

Outra diferença importante é que, enquanto um MBA representa resultados naturalmente discretos e frequentemente com flutuações, um MBE fornece uma representação contínua e sem ruído. Naturalmente, há situações em que o custo de construir um ABM excede seus benefícios. Resultados mais detalhados são obtidos com modelos mais complexos, que exigem maior poder de processamento. De maneira geral, ABMs são computacionalmente mais pesados do que EBMs, uma vez que estes últimos são relativamente simples, frequentemente consistindo em um pequeno conjunto de equações que podem ser resolvidas numericamente ou até mesmo analisadas em torno dos pontos de equilíbrio. Em geral, se o problema envolve um grande número de agentes homogêneos, será possível obter uma solução mais precisa e em menor tempo utilizando uma abordagem baseada em equações. Portanto, esse problema pode ser melhor modelado por essa categoria de modelos.
 
Como pode-se perceber, modelagem baseada em agentes é mais um conceito para a construção de um modelo que uma receita. Aescolha entre ABM e EBM depende de o que e como queremos modelar, não há um método intrinsecamente superior ao outro. Dentro do contexto que estamos discutindo, de sistemas complexos e leis estatísticas, estamos interessados em uma modelagem a nível microscópico que consiga ser capaz de gerar a lei estatística como uma propriedade emergente do sistema, desta forma nos é mais adequado utilizarmos ABM.

Como se pode perceber, a modelagem baseada em agentes é mais um conceito para a construção de um modelo do que uma receita pronta. A escolha entre ABM e EBM depende do que e como queremos modelar; não há um método intrinsecamente superior ao outro. Dentro do contexto que estamos discutindo, de sistemas complexos e leis estatísticas, nosso interesse é por uma modelagem a nível microscópico capaz de gerar a lei estatística como uma propriedade emergente do sistema.  Dessa forma, é mais adequado utilizarmos ABM.

Uma vez que construímos um modelo satisfatório, um dos papéis mais importantes da modelagem é a simulação, pois é por meio dela que podemos determinar o quanto o modelo se aproxima da realidade. A partir do momento em que alcançamos um grau de fidelidade aceitável no aspecto que o modelo se propõe a representar, podemos criar situações que são difíceis de serem observadas e estudadas no mundo real, de forma que o modelo possa ser utilizado também como ferramenta de tomada de decisão.

Antes de avançarmos, vale comentar que estes modelos são sempre sugestivos. Isto é, eles apenas demonstram que um dado fenômeno não é inconsistente com as consequências da lógica computável do nosso modelo. Não podemos saber se não há um modelo ainda mais simples que consiga reproduzir o mesmo fenômeno, mas podemos saber que não é preciso um modelo mais complexo [^5].

## Econofísica

Uma vez que entendemos a relação entre sistemas complexos e leis estatísticas, e compreendemos o conceito de modelagem utilizado para gerar os modelos generativos, podemos discutir rapidamente o que é a econofísica.

Augusto Comte, no começo do século 19, foi o responsável por cunhar o termo "física social" como uma referência explícita ao sucesso da mecânica newtoniana. Apesar de ter abandonado o termo posteriormente, ele foi recuperado mais tarde por seus sucessores, particularmente Adolphe Quételet, astrônomo por formação, que publicou em 1835 um ensaio sobre física social. Outro intelectual influente para o desenvolvimento da área foi o historiador Henry Buckle, responsável por apresentar uma abordagem estatística da história da civilização.

Entre esta lista de ilustres nomes, podemos citar também Friedrich Engels[^6], ainda no século 19, postulou que, apesar de cada indivíduo ter sua vontade pessoal, as múltiplas vontades individuais existentes em uma sociedade se entrecruzam e até mesmo conflitam entre si. Do choque dessas vontades, obteríamos um estado análogo ao que encontramos na natureza desprovida de consciência. Essa constatação abre a possibilidade de modelarmos fenômenos sociais com ferramentas análogas às utilizadas nas ciências naturais.

Na mesma época de Quételet, Georg Graf contemplou aplicar os princípios da mecânica clássica especificamente à economia. Seu conhecimento da física newtoniana era profundo, e ele contribuiu para diversas áreas da ciência.  Um texto seu de 1815 já apresentava o que poderia ser considerado um capítulo de um livro de economia, referindo-se explicitamente à mecânica clássica — uma forma de pensar revolucionária para sua época.

Na segunda metade do século 19, uma tentativa similar foi feita por Vilfredo Pareto. Pareto também se voltou à economia munido de um bom conhecimento da mecânica clássica newtoniana e com entusiasmo em descrever movimentos sociais da mesma forma que se descrevia o movimento dos planetas. Ele chegou a comparar as leis de Kepler a leis econômicas que ainda estariam por ser descobertas. A lei de Pareto sobre a distribuição da riqueza tornou-se uma peça fundamental do conhecimento econômico. No entanto, sua ambição de reduzir as leis econômicas a algo análogo às leis de Newton perma

Os métodos de probabilidade e estatística floresceram primeiro entre os cientistas sociais que investigavam regularidades quantitativas no funcionamento da sociedade.  Somente em um segundo momento a física se move do determinismo da física newtoniana em direção à descrição probabilística dos gases ideais, apropriando-se então das ferramentas estatísticas já existentes. É notável como esses conceitos, desenvolvidos inicialmente fora da física, acabaram por influenciar diretamente o próprio desenvolvimento da disciplina. Se, nos dias atuais, os físicos recorrem à analogia entre moléculas e humanos para investigar questões sociais, Boltzmann tinha em mente uma analogia similar — mas invertida — ao investigar os gases, inspirando-se na sociedade para analisar um fenômeno tipicamente físico. Em um trecho de seu artigo de 1872, ele menciona:

> “As moléculas são como muitos indivíduos, tendo os mais diversos estados de movimento, e as propriedades dos gases permanecem inalteradas só porque o número destas moléculas, que em média têm um dado estado de movimento, é constante.”

Na história do desenvolvimento da econofísica, um marco decisivo na discussão sobre a interação entre física e economia foi a introdução do conceito de fractais por Benoit B. Mandelbrot. Outro momento relevante foi a conferência programada para ocorrer em Moscou em 1974, cuja organização incluía nomes como Kenneth Arrow (laureado em economia) e Hans Bethe (laureado em física).  Apesar de ter sido cancelado, o evento desempenhou um papel significativo na transferência de ideias e da linguagem da física para outras áreas do conhecimento humano. Seus manuscritos sobreviveram, e alguns foram publicados posteriormente, influenciando diretamente o desenvolvimento futuro da econofísica.

Após esse evento, outras tentativas de integrar a física com outras disciplinas começaram a florescer ainda mais intensamente. Entre as décadas de 1970 e 1980, a ciência da complexidade ganhou enorme popularidade, com o Instituto Santa Fé desempenhando um papel ativo nesse processo.  Foi nesse contexto que a teoria de sistemas complexos começou a ser aplicada de forma sistemática à economia. O físico laureado P. W. Anderson passou a se envolver profundamente com essa linha de pesquisa, promovendo ativamente o uso de métodos da física em problemas sociais e econômicos. Em 1991, a revista *Physica A* publicou o que hoje é considerado o primeiro artigo que pode ser verdadeiramente atribuído ao recém-nascido campo da econofísica.

Mas o que é exatamente econofísica ainda é uma questão em aberto — não há um consenso claro. Para Slanina, ela não é uma simples mistura entre as ciências naturais e a economia, tampouco uma ciência interdisciplinar entre economia e física[^7].  Ele prefere chamá-la de transdisciplinar, pois o objetivo não é ocupar um lugar entre as disciplinas, mas sim encontrar princípios que sejam verdadeiros em ambas. Ou seja, trata-se de uma busca por princípios comuns, ferramentas compartilhadas e consequências equivalentes.

Outro ponto relevante para a discussão é a forma como os econofísicos direcionam seus esforços. A econofísica não se resume a pegar um fragmento da física teórica e reinterpretá-lo na linguagem da economia. Um relatório[^8] de 2022 sobre física social adota uma definição mais ampla que a de Slanina: física social é uma coleção de tópicos de pesquisa voltados para a resolução de problemas sociais, nos quais cientistas com formação formal em física têm contribuído e continuam a contribuir significativamente. Embora definições mais abertas frequentemente gerem debate, trata-se aqui de uma definição pragmática, baseada na ideia de que o que os físicos realmente fazem é o que define o que é física.

O enorme sucesso da física ao longo do último século levou cientistas de outras disciplinas a tentar formular métodos quantitativos similares aos da física.  De maneira geral, isso resultou em uma proliferação de modelos matemáticos e físicos em diversas áreas do conhecimento. E então, se vamos utilizar métodos análogos aos da física, quem melhor do que os próprios físicos para contribuir?  Dessa forma, opta-se por chamar de física social essa coleção de tópicos que têm por objeto de estudo problemas sociais, com físicos como os principais profissionais envolvidos. 

Apesar de a física social não ser algo novo, essa tendência ressurge com mais intensidade nos tempos atuais. Isso ocorre não apenas devido aos avanços recentes na tecnologia necessária para sua implementação, mas também como resultado de uma diminuição no ritmo do progresso científico da física tradicional, ao menos em comparação com o século anterior. Esse fenômeno gera, por um lado, o movimento de físicos em busca de uma "nova física", e por outro, o de jovens cientistas que decidiram empregar suas habilidades quantitativas em outros tópicos.

Os temas da física social muitas vezes surgem de uma reflexão sobre o que constitui e sustenta o modo de vida moderno, e também sobre o que o perturba ou ameaça. A prosperidade das cidades está, em muitos aspectos, atrelada aos mercados, e a economia tem um impacto profundo no desenvolvimento e no planejamento da vida urbana. É nesse contexto que emerge, de forma mais específica, o campo da econofísica.

Diferentemente da economia tradicional, que está construída sobre um modelo de escolhas racionais, a econofísica se destaca por, inicialmente, tomar emprestado o modelo de partículas da física estatística para explicar o comportamento dos agentes. Essa forma de modelagem assume que os interesses e preferências dos agentes não são fixos, mas dependem da interação com outros agentes. Colocando de outra forma, a econofísica coloca uma grande ênfase no ambiente social do agente.
 
A econofísica tradicionalmente tem focado em questões como o fluxo de dinheiro e os mercados financeiros, devido à existência de um grande conjunto de dados disponíveis, que permitiu a aplicação eficaz de ferramentas e métodos da física estatística nessas áreas. Áreas como a macroeconomia historicamente não atraíram a atenção dos econofísicos. Porém, com o crescimento da área, o aumento da disponibilidade de dados e o avanço do poder computacional nos últimos anos, os econofísicos podem desempenhar um papel importante no futuro do desenvolvimento da macroeconomia.


Além disso, pode-se mencionar que empreendimentos interdisciplinares dessa natureza contribuem para aproximar as ciências naturais** e as ciências humanas. Como disse Karl Marx[^9]: 

> "Conhecemos uma única ciência, a ciência da história. A história pode ser examinada de dois lados, dividida em história da natureza e história dos homens. Os dois lados não podem, no entanto, ser separados; enquanto existirem homens, história da natureza e história dos homens se condicionarão reciprocamente."

Lembrando que, por história da natureza, segundo o próprio autor, referimo-nos às ciências da natureza.

[^1]: Também há um artigo de divulgação científica interessante intitulado *[A física das partículas humanas](https://cienciahoje.periodicos.capes.gov.br/storage/acervo/ch/ch_342.pdf)* (Celia Anteneodo).
[^2]: A discussão completa pode ser encontrada no livro [*Statistical Laws in Complex Systems*](https://arxiv.org/abs/2407.19874) (Altmann).
[^3]: [*Em busca da Aplicabilidade de Sociedades Artificiais em Informática Educativa*](https://lume.ufrgs.br/bitstream/handle/10183/12181/000617438.pdf?sequence=1&isAllowed=y) (Henrique Oliveira da Silva) e *[Otimização combinatória e programação linear: Modelos e algoritmos](https://web.ist.utl.pt/luis.tarrataca/classes/linear_programming/OtimizacaoCombinatoriaeProgramacaoLinear.pdf)* (Marco Goldbarg) servem de referência para esta discussão sobre modelos.
[^4]: A discussão completa pode ser encontrada no livro *An Introduction to Agent-Based Modeling* (Wilensky e Rand).
[^5]: Comentário originalmente encontrado no *Classical Econophysics* (Cottrell, Cockshott, Michaelson e Wright).
[^6]: *Anti-Dühring* (Friedrich Engels).
[^7]: *Essentials of Econophysics Modelling* (Slanina)
[^8]: *[Social physics](https://www.sciencedirect.com/science/article/abs/pii/S037015732100404X)*.
[^9]: *A ideologia Alemã* (Friedrich Engels e Karl Marx)
