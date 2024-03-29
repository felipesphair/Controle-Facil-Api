# API-REST-CONTROLE-FACIL

Esse projeto é um sistema para controle de gastos pessoais, permitindo aos usuários registrar e gerenciar suas despesas de maneira eficiente e organizada. A aplicação proporciona uma interface intuitiva e funcionalidades robustas para facilitar o controle financeiro individual.

# Tecnologias Utilizadas:

![image](https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/ee488639-783a-4b1f-a982-e858babd1f28)

- *C#*: Linguagem de programação principal utilizada para o desenvolvimento do sistema.
- *Net8*: Framework que fornece uma estrutura sólida para a construção de aplicativos, incluindo a implementação de APIs Restful.
- *EFCore7*: Entity Framework Core, uma ferramenta de mapeamento objeto-relacional (ORM) que simplifica a interação com o banco de dados PostgreSQL.
- *JWT (JSON Web Token)*: Protocolo utilizado para autenticação e autorização na aplicação, garantindo a segurança das informações dos usuários através da geração de tokens assinados digitalmente.
- *AutoMapper*: Biblioteca utilizada para simplificar o mapeamento entre objetos de diferentes tipos, facilitando a conversão de dados entre as entidades da aplicação e os modelos de dados utilizados para interação com o banco de dados.
- *Migrações*: Recurso fornecido pelo Entity Framework Core para controlar a evolução do esquema do banco de dados de forma automatizada, permitindo a criação e atualização das tabelas e relacionamentos conforme as alterações no modelo de dados da aplicação.
- *Interfaces Genéricas*: Conceito utilizado para criar componentes reutilizáveis e flexíveis, promovendo a modularidade e extensibilidade do código-fonte através da definição de contratos genéricos para a interação entre diferentes partes do sistema.
- *Injeção de Dependência*: Prática de programação utilizada para desacoplar as dependências entre os componentes da aplicação, facilitando a manutenção, teste e evolução do software ao permitir a substituição de implementações concretas por interfaces abstratas.

# Como rodar:

1. Baixe o .net 8.0 SDK no link: https://dotnet.microsoft.com/pt-br/download/dotnet/thank-you/sdk-8.0.203-windows-x64-installer;
2. Tenha o VsCode instalado;
3. Baixe o PostgreSQL 14 em uma versão estável;
4. Abra a pasta que instalou no VsCode;
5. Abra um terminal e rode o seguinte comando 'dotnet tool install --global dotnet-ef --version 7.0.0-*';
6. Rode o comando 'dotnet build' para compilar todo o codigo;
7. Vá até o caminho ControleFacil.Api pelo terminal com o seguinte comando 'cd src/ControleFacil.Api';
8. Rode o seguinte comando 'dotnet ef database update';
9. Para realmente rodar aperte F5 e pronto!

# Teste da api no LocalHost nos 4 serviços:

- Toda aplicação além de GetAllUsers e login estão bloqueados até você fazer login.
- Os 4 serviços tem CRUD.

1. USUARIO:

   <img width="883" alt="Captura de tela 2024-03-29 010352" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/67ff12c4-5006-4374-8080-a7b41aa88fe4">
   
   <img width="883" alt="Captura de tela 2024-03-29 010453" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/e3d36c84-6262-4605-b6a4-1bb067c2117e">
   
   <img width="883" alt="Captura de tela 2024-03-29 010528" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/8d57db34-3116-4de8-9d52-fd263109f014">


2. NATUREZA DE LANÇAMENTO:

   <img width="883" alt="Captura de tela 2024-03-29 011632" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/23698fbc-a23f-46fd-896a-ee834eda68f5">
   
   <img width="883" alt="Captura de tela 2024-03-29 011620" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/4be40b6a-f905-48d8-b757-7e9c7f9a95d1">


3. A PAGAR:

   <img width="883" alt="Captura de tela 2024-03-29 011911" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/258d038b-6588-41f4-b148-ce18864ba096">
   
   <img width="883" alt="Captura de tela 2024-03-29 012120" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/cb480fd2-2c0c-44f0-b7c5-088769f4b297">
   
   <img width="883" alt="Captura de tela 2024-03-29 012216" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/cb10b32f-85c6-4737-b0fc-9a4bfcdc9b3f">
   
   <img width="883" alt="Captura de tela 2024-03-29 012228" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/26978ca5-4412-4bfc-83f4-0d91a6909f84">



4. A RECEBER: 
   
   <img width="883" alt="Captura de tela 2024-03-29 012049" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/749cd0a8-9308-4083-9027-73f52f93bcb8">
   
   <img width="883" alt="Captura de tela 2024-03-29 012245" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/f850407d-5a12-430b-8009-adb5d5057288">
   
   <img width="883" alt="Captura de tela 2024-03-29 012317" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/50ada1c5-6f11-4dbc-844f-3cddb2b6df8d">
   
   <img width="883" alt="Captura de tela 2024-03-29 012330" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/76816829-dae2-4777-8875-5d485334cbd3">
   
   <img width="883" alt="Captura de tela 2024-03-29 012420" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/38015214-6a03-4099-b411-f014c782a5ca">
   
   <img width="883" alt="Captura de tela 2024-03-29 012437" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/24aa8430-fa5f-4487-8596-de9aa844b65f">


# Exceptions:

Na API, implementamos três tipos de exceções:

1. BadRequestException: Utilizada para casos em que ocorrem envios de dados em formatos inválidos ou incorretos durante operações de adição e atualização.

   Implementado na lógica do valor:

   <img width="883" alt="Captura de tela 2024-03-29 011440" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/2afd5293-3103-444e-8245-fd64e96bdbf2">


3. NotFoundException: Empregada quando não é possível encontrar o identificador (ID) especificado durante operações de obtenção por ID e exclusão.

   <img width="883" alt="Captura de tela 2024-03-29 010609" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/6964f91b-c2aa-411f-b08a-2c0d3e0f42d9">


4. AuthenticationException: Reservada para situações em que ocorrem falhas durante o processo de autenticação, como credenciais de login inválidas.
   
   <img width="883" alt="Captura de tela 2024-03-29 003441" src="https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/4484bd8c-e040-4c3f-a435-6530836ebf56">



