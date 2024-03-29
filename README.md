# API-REST-CONTROLE-FACIL

Esse projeto é um sistema para controle de gastos pessoais, permitindo aos usuários registrar e gerenciar suas despesas de maneira eficiente e organizada. A aplicação proporciona uma interface intuitiva e funcionalidades robustas para facilitar o controle financeiro individual.

# Tecnologias Utilizadas:

![image](https://github.com/felipesphair/Controle-Facil-Api/assets/107360437/70412d11-cd60-4a8e-8c02-83d793896364)

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

USUARIO:

<img width="959" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/f9c83c06-d11f-4167-8e6a-01269ad12b2d">

<img width="959" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/672317ab-2ea7-428e-b5c9-7f1ea32fa16b">

<img width="959" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/ec9e6f25-b0ac-4f62-97a0-d57ee87a37b4">


NATUREZA DE LANÇAMENTO:

<img width="958" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/cf4ea92e-c7fe-4822-b3a0-53068afc23eb">

<img width="952" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/14b9d14b-6d9c-4225-bd33-6a787ddbd2f2">

A PAGAR:

<img width="960" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/7a0e3714-00c4-4dfd-8531-41655fe46815">

<img width="960" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/3f8a2841-07e4-4c0d-a244-233e57d381eb">

<img width="960" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/7a4a9f94-d144-4b9c-ba1e-6a0805d38dcf">

<img width="948" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/6fc4d18e-b90a-4881-a55d-4c50ac56ddd4">



A RECEBER: 

<img width="959" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/a2d5b9e0-20b0-46ee-9cd6-06a157c820d3">

<img width="950" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/76657622-9572-44a3-a676-e4415a0c4fee">

<img width="957" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/c608521a-3a1c-4ab6-a720-08e74e107d10">

<img width="960" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/acda5863-da01-48fa-9da6-4877aa7fea50">

<img width="960" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/d5e176f9-1896-47d6-8a7d-c3bf2eeade2f">

<img width="949" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/6a82db3b-725f-41f7-8dc3-e6a3d028da97">


# Exceptions:

Na API, implementamos três tipos de exceções:

1. BadRequestException: Utilizada para casos em que ocorrem envios de dados em formatos inválidos ou incorretos durante operações de adição e atualização.

   Implementado na lógica do valor:
   
   <img width="941" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/f11d27b3-2388-4e34-93a3-a0d5257d9705">


3. NotFoundException: Empregada quando não é possível encontrar o identificador (ID) especificado durante operações de obtenção por ID e exclusão.

   <img width="960" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/79e299f2-cf05-45c2-ba65-ad310d7cdd1c">

4. AuthenticationException: Reservada para situações em que ocorrem falhas durante o processo de autenticação, como credenciais de login inválidas.
   
   <img width="960" alt="image" src="https://github.com/felipesphair/API-REST-CONTROLE-FACIL/assets/107360437/b9023532-b0a6-4322-a92f-e227244539e8">


