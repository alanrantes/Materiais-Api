# Materials API | ASP.NET Core Minimal API + SQL Server

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=flat&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white)
![Postman](https://img.shields.io/badge/Postman-FF6C37?style=flat&logo=postman&logoColor=white)

<p align="justify">
API REST para gerenciamento de produtos, desenvolvida em C# com ASP.NET Core utilizando o padrão de Minimal API e integrada ao SQL Server por meio do Entity Framework Core.

O projeto implementa operações completas de CRUD (Create, Read, Update e Delete), com foco na prática de desenvolvimento backend moderno, explorando a construção de APIs de forma simplificada, manipulação de dados em banco relacional e boas práticas de organização de código.
</p>

---

## 🛠️ Tecnologias

- C#
- ASP.NET Core (Minimal API)
- Entity Framework Core
- SQL Server
- Postman

---

## 🚀 Funcionalidades

- Cadastro de produtos com os seguintes campos:
  - Nome
  - Código
  - Preço
  - Descrição
  - Quantidade em estoque
  - Avaliação
  - Categoria

- Operações completas de CRUD:
  - Criar produtos
  - Listar todos os produtos
  - Buscar produto por código
  - Buscar produtos por categoria
  - Atualizar dados (PUT e PATCH)
  - Remover produtos

---

## 🔗 Endpoints

| Método | Rota                                   | Descrição                             |
|--------|----------------------------------------|----------------------------------------|
| GET    | /                                      | Verifica se a API está em execução     |
| GET    | /produtos                              | Lista todos os produtos                |
| GET    | /produtos/por-codigo/{codigo}           | Busca um produto pelo código           |
| GET    | /produtos/por-categoria/{categoria}     | Lista produtos por categoria           |
| POST   | /produtos                              | Cria um novo produto                   |
| PUT    | /produtos/{id}                         | Atualiza todos os dados                |
| PATCH  | /produtos/{id}                         | Atualiza parcialmente                  |
| DELETE | /produtos/{id}                         | Remove um produto                      |

---

## 📦 Estrutura do Projeto

- Endpoints (Minimal API)
- Models
- Data (DbContext)
- Services / Repositories

---

## 📄 Exemplo de Produto (JSON)

```json
{
  "nome": "Teclado Mecânico",
  "codigo": "TEC123",
  "preco": 250.00,
  "descricao": "Teclado mecânico RGB",
  "qtdEstoque": 10,
  "avaliacao": 5,
  "categoria": "Periféricos"
}
```

## Como Executar

1. Clone o repositório:  
   ```bash
   git clone <URL_DO_REPOSITORIO>
2. Abra a solução no Visual Studio
3. Configure a string de conexão com o SQL Server no arquivo appsettings.json (caso necessário)
4. Execute o projeto
5. Utilize o Postman ou outra ferramenta para testar os endpoints

## Testes
Os endpoints foram testados utilizando o Postman, garantindo o funcionamento correto das operações de CRUD.

## Aprendizado
Durante o desenvolvimento deste projeto, foram aplicados conceitos como:

- Criação de APIs com ASP.NET Core utilizando Minimal API
- Integração com banco de dados relacional (SQL Server)
- Uso do Entity Framework Core para persistência de dados
- Implementação de operações CRUD
- Diferença entre métodos PUT e PATCH
- Organização e boas práticas no backend
