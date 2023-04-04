<div><h1> Bom este é um projeto em C#<img "width="40" height="30" src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-plain.svg""> e se trata de uma
livraria (biblioteca) </h1></div>
<div><p>Este foi um exemplo para apredenzidado onde foram usados os conceitos de orientação a obejtos, foram feitos alguns CRUDs, integração com wevView, e 
programação em camadas (BLL,DTO,DAO).</p>
<p>Este é um dos projetos antigos que estou pegando para corrigir os problemas deixados, e aplicar melhorias. </p></div>
<hr>
<div align="center"><h2>Breve visão das telas do projeto.</h2><img src="https://github.com/OVinicius1995/Projeto_livraria_POO/blob/Atual/assets/Livraria_final_2.gif"></div>

<hr>

<p> Vou tentar explicar um pouco sobre este projeto, bom o projeto de livraria surgiu inicial para ser um estoque de livros visando aplicar o conceito de CRUDs (create, update,delete), porem mais uma vez tive a ideia de ampliar um pouco e colocar também uma opção de venda de livros. </p>



<p> Dito isso e após apresentar o exterior do proejto irei apresentar apresentar um pouco da beleza interior do mesmo ​:sweat_smile:​. Conforme falado anteriormente o sistema foi pensando (num escopo até antigo) de programação em 3 camadas (Bll, DTO, DAL).
<ul>
   <li>Por tanto temos a camada [BLL](https://github.com/OVinicius1995/Projeto_livraria_POO/blob/master/Livraria_BLL.cs) onde é inserido a camada de regra de negocio (ou seja onde ficam as operações do CRUD)	</li>
   <li>Na sequência vem a camda de dados [DTO](https://github.com/OVinicius1995/Projeto_livraria_POO/blob/master/livraria_DTO.cs) camada que é responsável por encapsular os dados capturando os mesmo, deixando os dados privado, e liberando os dados somente para os herdeiros e às instanciações.</li>
<li>E por ultimo porem não menos importante vem a camada [DAL](https://github.com/OVinicius1995/Projeto_livraria_POO/blob/master/DAO_MySql.cs) esta é a camada onde é feito a conexão com a base de dados.
    </li>
    <li>
        Base de dados [Schema](https://github.com/OVinicius1995/Projeto_livraria_POO/blob/Atual/assets/livraria.sql)
    </li>
</ul>
</p>


<p>
    Em pesquisas feitas recentemente acabei por ver que essa forma de desenvolvimento já é considerada ultrapassada, porem foi a forma como surgiu o projeto. Pra mim o importante é a usabilidade do cliente, facilidade de manutenção no código, e a programação em objetos que conta com os pilares principais (Abstração, Encapsulamento, Herança, Polimorfismo).
</p>
<div align="center"><h2>UML</h2><img height="620" width="935" src="https://github.com/OVinicius1995/Projeto_livraria_POO/blob/Atual/assets/DEER_Livraria.png"></div>



<div align="center"><h2>DEER</h2><img height="620" width="935" src="https://github.com/OVinicius1995/Projeto_livraria_POO/blob/Atual/assets/DEER_Livraria.png"></div>
