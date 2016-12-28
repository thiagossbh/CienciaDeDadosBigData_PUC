## Coleta de dados do Twitter ##

Trabalho prático realizado para avaliar o conhecimento obtido na disciplina de Banco de Dados Não Relacionais do curso de Pós Graduação em Ciência de dados e Big Data da PUC Minas.
<br/>Professor: [Gabriel Coutinho](https://github.com/gcouti)


### Missão: ###
Coletar informações de redes sociais ou importar dados externos armazenando-os em um banco de dados NoSQL.
Extrair Informações do tipo:
<br/>•	Termos mais frequentes.
<br/>•	Volume X dia.
<br/>•	Volume X hora do dia
<br/>
### Hardware: ###
O trabalho foi realizado em um Notebook de domestico com a seguinte configuração:
<br/>•	Processador Intel Core I7.
<br/>•	8GB de memória RAM DDR3.
<br/>•	1 TB de HD.
<br/>•	Windows 7 64 bits.
<br/>
### Contexto e aplicação: ###
O professor nos deu liberdade para escolher a fonte da informação e o assunto.
<br/>Optei por coletar dados do Twitter devido a facilidade em encontrar na web informações sobre a APi.
<br/>Sou apaixonado por motocicletas e por este motivo resolvi fazer uma busca de assuntos relacionados a motos, utilizando como palavras chave:
<br/> “moto”, “motocicleta”, “motociclista”, “motoboy”, “viagem de moto”, e também as marcas “Honda”, “Yamaha”, “kawasaki”, “Suzuki”, “harley”, “harley Davidson”, “harleydavidson”, “dafra” e “BMW”.
<br/>
### Metodologia: ###
Trabalho com plataforma Microsoft há mais de 7 anos e tenho conhecimento em programação em C# geralmente utilizando o Visual Studio, sendo assim o processamento foi realizado da seguinte forma:
<br/>•	Coleta dos dados utilizando o [Microsoft Visual Studio 2015](https://www.visualstudio.com/pt-br/vs/), foi criada um “Console Application” utilizando linguagem C#.
<br/>•	A aplicação foi integrada com o [MongoDB](https://www.mongodb.com/)utilizando o [“MongoDriver”](https://www.nuget.org/packages/MongoDB.Driver).
<br/>•	Foi utilizado a biblioteca [Tweetinvi](https://tweetinvi.codeplex.com/) para coleta dos dados do Twitter.
<br/>•	Foi utilizado o [Robomongo](https://robomongo.org/) para interagir com a base de dados MongoDB.
<br />
### Vamos ao código ###

Utilizando o Microsoft Visual Studio 2015 criei um "Console Application" (File --> New Project --> ).
<p align="center"><img src="Imagens/CriacaoConsole.png" /></p>

### Resultados: Tempo de execução das consultas, informações extraídas. ###
<br />

### Conclusões: Considerações sobre o trabalho ###
