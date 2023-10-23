# Programação de Funcionalidades

## Leonardo - Responsável pela página de Insumos.

Abaixo serão apresentadas testes de execuções do projeto de exemplo referente a segunda etapa do projeto.
Todo o código do exemplo que foi executado pode ser encontrado [neste repositório](https://github.com/LeonardoAlves7/projeto-puc.git).

O objetivo deste exemplo foi criar um projeto utilizando o ASP.Net Core MVC com auxilio do entity framework. A utilização das camadas Model, View e Control, a interação entre elas, sendo ao final possivel realizar as operações do método CRUD.

- ### (1)  Criação da tabela Veículos, Contendo a classe veículo e as suas proprieades, que são de Id, Nome, Placa, Ano de fabricação e Ano do Modelo de veículos. A propriedade Id, definida como chave primária.

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

# 

# xxxx


