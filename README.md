API Boilerplate - .NET 9
Este repositório contém uma API Boilerplate desenvolvida com .NET 9, utilizando PostgreSQL como banco de dados e documentação gerada automaticamente pelo Swagger.

Requisitos
.NET 9 SDK - Para rodar o projeto.
PostgreSQL - Para o banco de dados.
Ferramentas de migração - O projeto já inclui uma pasta de migrações para criar as tabelas padrão.
Como rodar a aplicação
1. Clonar o repositório
Clone este repositório para sua máquina local:

bash
Copiar código
git clone https://link-do-repositorio.git
cd nome-do-repositorio
2. Configurar o Banco de Dados
Antes de rodar a aplicação, você precisa configurar o banco de dados PostgreSQL.

Instale o PostgreSQL na sua máquina ou utilize um servidor PostgreSQL.
Crie um banco de dados com o nome de sua escolha.
Abra o arquivo appsettings.json na raiz do projeto e configure a string de conexão do PostgreSQL:
json
Copiar código
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Username=seu-usuario;Password=sua-senha;Database=nome-do-banco"
  }
}
3. Aplicar as Migrations
Se você já tem as migrações configuradas, você pode aplicar as migrations para criar as tabelas padrão no banco de dados.

Execute o comando a seguir para aplicar as migrations:

bash
Copiar código
dotnet ef database update
Este comando irá aplicar todas as migrações pendentes e criar as tabelas no banco de dados PostgreSQL.

4. Rodar a aplicação
Agora que o banco de dados está configurado e as migrações foram aplicadas, você pode rodar a API.

Execute o seguinte comando para iniciar o servidor:

bash
Copiar código
dotnet run
A aplicação será iniciada no endereço padrão: https://localhost:5001 ou http://localhost:5000.

5. Acessar a Documentação Swagger
Uma vez que a aplicação estiver rodando, você pode acessar a documentação Swagger para explorar os endpoints da API, basta acessar o localhot com /swagger ex: https://localhost:5001/swagger
