# API de chamados de suporte técnico em CSharp

API REST para gerenciamento de chamados de suporte técnico, desenvolvida com C# e ASP.NET Core.

O projeto tem como objetivo praticar o desenvolvimento de APIs REST, a persistência de dados e a organização de aplicações back-end utilizando tecnologias do ecossistema .NET.

**Status:** Em desenvolvimento 🚧

## Objetivo

Desenvolver uma API que permita registrar, consultar e gerenciar chamados de suporte técnico, simulando um sistema utilizado por uma equipe de atendimento.

## Tecnologias

- **C#** — linguagem de programação.
- **ASP.NET Core Web API** — desenvolvimento dos endpoints HTTP.
- **Entity Framework Core** — acesso e mapeamento dos dados.
- **SQLite** — banco de dados relacional.
- **Swagger / OpenAPI** — documentação e testes da API.
- **Git e GitHub** — versionamento e hospedagem do projeto.

## Funcionalidades planejadas

- [ ] Criar chamados de suporte.
- [ ] Listar todos os chamados.
- [ ] Consultar um chamado por identificador.
- [ ] Atualizar informações de um chamado.
- [ ] Alterar o status de um chamado.
- [ ] Excluir chamados.
- [ ] Validar os dados recebidos pela API.
- [ ] Persistir os dados em um banco SQLite.
- [ ] Documentar e testar os endpoints.

## Dados de um chamado

Cada chamado deverá conter as seguintes informações:

| Campo | Descrição |
|---|---|
| `Id` | Identificador único do chamado |
| `Titulo` | Resumo do problema |
| `Descricao` | Detalhes da solicitação |
| `Solicitante` | Nome de quem abriu o chamado |
| `Prioridade` | Baixa, Média ou Alta |
| `Status` | Aberto, Em andamento ou Resolvido |
| `DataAbertura` | Data de criação |
| `DataAtualizacao` | Data da última alteração, quando houver |

## Endpoints planejados

| Método HTTP | Endpoint | Descrição |
|---|---|---|
| `POST` | `/api/chamados` | Criar chamado |
| `GET` | `/api/chamados` | Listar chamados |
| `GET` | `/api/chamados/{id}` | Consultar chamado por ID |
| `PUT` | `/api/chamados/{id}` | Atualizar chamado |
| `PATCH` | `/api/chamados/{id}/status` | Alterar status |
| `DELETE` | `/api/chamados/{id}` | Excluir chamado |

*Os endpoints serão implementados e testados progressivamente durante o desenvolvimento.*

## 📁 Estrutura do projeto

A estrutura prevista para a aplicação é:

```text
ChamadosApi/
├── Controllers/
│   └── ChamadosController.cs
├── Data/
│   └── AppDbContext.cs
├── DTOs/
├── Models/
├── Properties/
├── Program.cs
├── appsettings.json
└── README.md
```

## Como executar

Após a configuração e implementação inicial do projeto:

1. Instale o .NET SDK compatível com a aplicação.
2. Clone este repositório.
3. Entre na pasta do projeto.
4. Restaure as dependências.
5. Execute a aplicação.


A URL local da API e a documentação Swagger serão informadas após a configuração e execução da aplicação.

## Conceitos praticados

Este projeto busca desenvolver conhecimentos em:

- Desenvolvimento de APIs REST.
- Métodos HTTP e códigos de status.
- Programação orientada a objetos com C#.
- Modelagem de entidades e DTOs.
- Persistência de dados com SQLite.
- Entity Framework Core e migrações.
- Validação de dados e tratamento de erros.
- Organização de código e versionamento com Git.

## Próximos passos

O desenvolvimento será dividido em etapas, começando pela configuração do ambiente e criação do projeto, seguida pela modelagem dos dados, implementação dos endpoints, testes e documentação final.


Este projeto desenvolvido para fins de aprendizado e construção de portfólio em desenvolvimento back-end com C# e .NET.

