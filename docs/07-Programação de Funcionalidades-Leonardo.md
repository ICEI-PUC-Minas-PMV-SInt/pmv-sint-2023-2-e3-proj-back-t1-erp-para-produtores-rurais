# Programação de Funcionalidades

## Leonardo - Responsável pela página de Insumos.

Abaixo serão apresentadas testes de execuções do projeto de exemplo referente a segunda etapa do projeto.
Todo o código do exemplo que foi executado pode ser encontrado [neste repositório](https://github.com/LeonardoAlves7/projeto-puc.git).

O objetivo deste exemplo foi criar um projeto utilizando o ASP.Net Core MVC com auxilio do entity framework. A utilização das camadas Model, View e Control, a interação entre elas, sendo ao final possivel realizar as operações do método CRUD.

- ### (1) Criação da tabela Veículos, Contendo a classe veículo e as suas proprieades, que são de Id, Nome, Placa, Ano de fabricação e Ano do Modelo de veículos. A propriedade Id, definida como chave primária.

<p align="center">
<img src="/docs/img/Leonardo/1.png">
</p>

- ### (2) - Criação da classe de contexto do banco de dados. Através da classe de configuração AppDbContext ligadado ao DbContext utilizando o entity framework. E definindo o banco de dados.

<p align="center">
<img src="/docs/img/Leonardo/2.png">
</p>

- ### (3) - add-migration. geração da tabela veículos no banco de dados.

<p align="center">
<img src="/docs/img/Leonardo/3.png">
</p>

- ### (4) - Definindo a variavel context no controller em que recebe os dados do veículo da lista de veículos (Model) que será retornado para a View que fará o retorno dos dados. (Index).

<p align="center">
<img src="/docs/img/Leonardo/4.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/4a.png">
</p>

- ### (5) - Criação dos dados. Duas funções Create, uma que exibirá o formulário da página (get) e outra que receberá os dados preenchidos (post). Se as informações inseridas forem válidas, serão adicionadas na lista de dados e salvos no banco de dados. Ao adicionar os dados e adicionar, eles serão acrescentados ao banco de dados.

<p align="center">
<img src="/docs/img/Leonardo/5.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/5b.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/5c.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/5d.png">
</p>

- ### (6) - Edição de dados no controller. Através do Id (chave primária) recupera os dados do banco de dados, criando um formulário de edição. Ao alterar as informações, salva as mudanças e as redireciona para a lista inicial (index).

<p align="center">
<img src="/docs/img/Leonardo/6.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/6b.png">
</p>

- ### (7) - Implementação da funcionalidade de visualizar dados. Através da id, busca os dados e os retorna para a view.

<p align="center">
<img src="/docs/img/Leonardo/7.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/7a.png">
</p>

- ### (8) - Finalizando o método CRUD, adicionando a funcionalidade Delete. Recupera os dados através da id, apresenta na tela e dá ao usuário a opção de apagá-los (get). Ao confirmar, as informações recolhidas serão apagadas e a alteração será salva (post) e o usuário será redirecinado ao index.

<p align="center">
<img src="/docs/img/Leonardo/8.png">
</p>

<p align="center">
<img src="/docs/img/Leonardo/8a.png">
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
