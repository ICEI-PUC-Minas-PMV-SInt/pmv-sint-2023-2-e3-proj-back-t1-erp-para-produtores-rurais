# Programação de Funcionalidades

## Leonardo - Responsável pela página de Insumos.

Abaixo serão apresentadas a execução da página de insumos referente a terceira etapa do projeto.
Todo o código da página pode ser encontrado em [src/Página Insumos (Leonardo)](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e3-proj-back-t1-erp-para-produtores-rurais/tree/main/src/P%C3%A1gina%20Insumos%20(Leonardo)/pagina-insumos).

A página em questão trata-se da realização das tarefas de registro de insumos adquiridos pelo usuário. O insumo poderá ser registrado em uma lista, definindo sua descrição e quantidade, posteriormente sendo possivel também precificar a aquisição deste insumo espifico, o que gera para o usuário um detalhes dos dados, o que torna mais fácil de acompanhar suas atividades no campo. O código é realizado através do ASP.Net Core MVC com auxilio do entity framework. A utilização das camadas Model, View e Control, a interação entre elas, sendo ao final possivel realizar as operações do método CRUD.

- ###  A base do código é definida principalmente por duas tabelas, a Tabela de Insumos (imagem 1) e a Tabela de Gastos (imagem 2). A primeira tabela trata-se de registrar o insumo específico que foi adquirido pelo usuário, já a segunda tabela é utilizada para realizar a precifição daquele insumo específico que foi registrado pelo usuário.

<p align="center">
<img src="/docs/img/Leonardo/insumos-1.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/insumos-2.png">
</p>

- ###  Após a criação do Model (Tabelas de Insumos e Gastos) é definido o controller de cada tabela para que assim possamos gerar as Views e consequentemente as operação de CRUD. Vejamos na prática o registro e precificação de um insumo com as operações e Views já definidas:

<p align="center">
<img src="/docs/img/Leonardo/insumos-3.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/insumos-4.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/insumos-5.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/insumos-6.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/insumos-7.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/insumos-8.png">
</p>



# Victor B. - Responsável pela página de Login/Autenticação.

Irei colocar algumas imagens que representam a composição do sistema, imagens que mostram todo o processo de construção do sistema, desde a base ao final ou seja aquilo que é retornado ao usúario.

Vou deixar aqui o link de aonde se encontra o projeto, por falta de tempo optei em não colocar nenhuma funcionalidade a mais e nem criar algo relacionado ao oque seja proposto nas telas de autenticação/login ou seja o projeto está exatamente igual ao ensinado no microfundamento Web-BackEnd

Link: https://github.com/vbf1/app-backend.git

Telas e algumas explicações basicas de seus significados:

- ### Representação da Tabela da Classe Veiculos:

- ### Explicação: Na classe é definido as propriedades da classe, modificadores de acesso, o tipo se é String, number, etc, a classe e como se fosse a representação por escrito da estrutura do banco.

<p align="center">
<img src="/docs/img/Victor/table-veiculos.png

- ### Representação do CRUD da classe Veiculos:

- ### Explicação: O CRUD significa "C" Create : Criar novos Dados, "R" Ready: Ler Dados, "U" Update: Atualizar Dados, "D" Delete: Deletar Dados na imagem tem dois dos metodos o de "Criar" e o de "Editar" esses metodos sao definidos na camada de Controller, O controller e quem faz a comunicão da VIew com os dados que são solicitados do BackEnd.

<p align="center">
<img src="/docs/img/Victor/crud.png

- ### Representação da Migration da classe Veiculos:

- ### Explicação: Migration é a basicamente aonde fica o SQL ou seja o codigo que banco de dados intendi, o banco e criado através deste SQl, somente o que foi definido por meio do SQL que vai ser gerado no banco.

<p align="center">
<img src="/docs/img/Victor/migration-veiculos.png.png

- ### Representação da Tela que e retornada ao usuario que acessa o sistema:

- ### Explicação: Essa é uma das telas que é retornada ao um usúario interagir com o sistema.

<p align="center">
<img src="/docs/img/Victor/view.png" />

## Wender Santos - Responsavel pela página de produtos.

Abaixo colocarei imagens representando a composição do sistema criado usando o conhecimento adquirido no estudo da etapa 2 do projeto de desenvolvimento back-end.

Projeto pode ser encontrado no [seguinte repositório](https://github.com/wender-gs/puc-minas)

Foram usados os frameworks Next.JS e Prisma, como banco de dados escolhi usar o MongoDB. Usei de forma mais aberta o conceito da arquitetura MVC. Aonde usei o controller para criar uma classe que controle tudo referente aos usúarios, comunicando com o Banco de Dados por meio da API criada e retornando os resultados obtidos para a View encontrada na pasta PAGES.

- ### (1) Modelo que foi usado no banco de dados, aqui é o que seria a camada Model do MVC.

<div align="center">
  <img src="/docs/img/Wender/dataBaseModel.png" />
</div>

- ### (2) Abaixo segue como os dados ficam estruturados no banco de dados. No MongoDB é usado o formato JSON para armazenamento e controle dos dados, aonde cada item tem tem seu \_id como identificador único.

<div align="center">
  <img src="/docs/img/Wender/dataBaseStructure.png" />
</div>

- ### (3) Tendo o modelo criado e a estrutura preparada criamos o controller para comunicação com o DB, feito de forma simples somente para explicação.

<div align="center">
  <img src="/docs/img/Wender/userController.png" />
</div>

- ### (4) Aqui temos o código da API recebendo os dados das requisições feitas pelo controller e criando o usúario do exemplo.

<div align="center">
  <img src="/docs/img/Wender/createUserApi.png" />
</div>

- ### (5) Essa é o layout que as páginas irem herdar ao serem renderizadar.

<div align="center">
  <img src="/docs/img/Wender/layout.png" />
</div>

- ### (6) Essa é a página aonde o pode ser criado o usúario.

<div align="center">
  <img src="/docs/img/Wender/createUserPage.png" />
</div>
