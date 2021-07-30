*PROJETO Xsys Solutions* 
::::::::::::::::::::::::::::::::::::::::::::
	API RESTfull .NET Core 5.0
::::::::::::::::::::::::::::::::::::::::::::

fiz com o Enable OpenAPI Support para visão grafica pelo SWAGGER.
utilizei também o Postman(extensão do google) para testes.

PACKAGES:
Microsoft.EntityFrameWorkCore	(ultima versão)
Microsoft.EntityFrameworkCore.Tools	(ultima versão)
Microsoft.EntityFrameworkCore.Design	(ultima versão)
Pomelo.EntityFrameworkCore.MySql	(ultima versão)
*Pomelo que me permitiu a ligação do API com o banco de dados* 

::::::::::::::::::::::::::::::::::::::::::::::::::::::
			USO
ao abrir o visual studio va para (appsettings.json)
e defina sua conexão com o banco de dados.
(*server*,*port*,database,*user*,*password*) *MySQL*

após ter feito isso va para o visual
studio>ferramentas>gerenciador de pacotes NuGet>console do gerenciador de pacotes.

com o servidor do MySQL aberto digite no console "add-migration Inicial"
 onde sera feito a criação e passagem de dados para o banco de dados.
*MANDAREI O ARQUIVO COM UM FEITO COMO "Inicialk" PARA VIZUALIZAÇÃO RAPIDA.

apos isso digite "update-database" no console para atualização de dados.

va para o MySQL e estara la os dados.



::::::::::::::::::::::::::::::::::::::::::::::::::::::

		PASTAS E SIGNIFICADOS

Data: entidade de dominio "Produto.cs"
      classe de contexto "AppDbContext.cs"

Controllers: controlador de comandos "ProdutosController.cs"
      
Migrations: onde foi feito a criação e migração de dados para o banco de dados.

::::::::::::::::::::::::::::::::::::::::::::::::::::::


MADE BY: Felipe Corbanezi ✣


