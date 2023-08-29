# Especificações do Projeto

 A descrição dos problemas e os pontos mais relevantes a serem tratados neste projeto, se deu com base em uma análise geral sobre o gerenciamento do agronegócio e entrevista com uma representante da área que atende a produtores rurais, onde foi abordado e discutido pontos negativos de um agronegócio sem o sistema ERP. Todas as informações levantadas nesta análise foram aplicadas na forma de personas e histórias de usuários. 

## Personas

Pedro Paulo tem 26 anos, é arquiteto recém-formado e autônomo. Pensa em se desenvolver profissionalmente através de um mestrado fora do país, pois adora viajar, é solteiro e sempre quis fazer um intercâmbio. Está buscando uma agência que o ajude a encontrar universidades na Europa que aceitem alunos estrangeiros.

Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

Os requisitos são declarações vinculadas de forma objetiva sobre o que o sistema deve fazer e como será feito, divididas em: 

> Funcionais: são requisitos de funcionalidades, o que o software deverá fazer, interações entre o autor (usuário) e o sistema; 

> Não funcionais: são requisitos que determinam como o software irá fazer, especificando qualidades, normas padrões, restrições e necessidade. São requisitos que não necessariamente são ditos ou mesmo sentidos pelo cliente/usuário no seu uso. 

### Requisitos Funcionais

A tabela a seguir apresenta os Requisitos funcionais do projeto identificando a prioridade em que os mesmos devem ser entregues: 

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O sistema deve conter uma Interface simples e acessível | ALTA | 
|RF-002| O sistema deve conter uma área reservada ao registro de compras e despesas (formulários para cadastro)    | ALTA |
|RF-003| O sistema deve conter uma área que controle o registro de estoque de insumos (formulários para estoque)    | ALTA |
|RF-004| O sistema deve conter uma área que controle o registro de estoque e dos produtos (formulários para estoque)   | ALTA |
|RF-005| O sistema deve apresentar solução que o mantenha funcional durante o período que se encontrar offline    | MÉDIA |
|RF-006| O sistema deverá dispor de recursos voltados para produtores rurais.   | ALTA |
|RF-007| O sistema deve apresentar uma página onde o usuário poderá se logar no software (Tela de Login).  | BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deverá fazer uso da web storage, mantendo os dados armazenados em client-side.  | ALTA | 
|RNF-002| O sistema deve ser tratado de forma modular.  |  ALTA | 
|RNF-003| O sistema deverá ser responsivo facilitando a visualização em aparelho mobile de forma adequada.  |  MÉDIA |
|RNF-004| Hospedagem do aplicativo  |  MÉDIA |


## Restrições

As principais restrições limitam o prazo, a qualidade e o escopo do projeto, necessitam de objetividade para exercer o que é proposto adequadamente. Assim, estão expostas a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
