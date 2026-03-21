# Materials API - ASP.NET Core

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=flat&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white)

<p align="justify">
API desenvolvida em <strong>ASP.NET Core (C#)</strong> utilizando o padrão de <strong>Minimal API</strong>, com integração ao <strong>SQL Server</strong> por meio do 
<strong>Entity Framework Core</strong>. Este projeto foi criado como atividade acadêmica com o objetivo de praticar a construção de uma <strong>API REST completa (CRUD)</strong>, 
permitindo operações de criação, leitura, atualização e exclusão de dados, além de consolidar conhecimentos em desenvolvimento backend e integração com banco de dados relacional.
</p>


## Funcionalidades

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
  - Atualizar dados (com PUT e PATCH)
  - Deletar produtos

---

## Endpoints

<div align="center">

<table>
<tr>
<th>Método</th>
<th>Rota</th>
<th>Descrição</th>
</tr>

<tr><td>GET</td><td>/</td><td>Verifica se a API está em execução</td></tr>
<tr><td>GET</td><td>/produtos</td><td>Lista todos os produtos</td></tr>
<tr><td>GET</td><td>/produtos/por-codigo/{codigo}</td><td>Busca um produto pelo código</td></tr>
<tr><td>GET</td><td>/produtos/por-categoria/{categoria}</td><td>Lista produtos por categoria</td></tr>
<tr><td>POST</td><td>/produtos</td><td>Cria um novo produto</td></tr>
<tr><td>PUT</td><td>/produtos/{id}</td><td>Atualiza todos os dados</td></tr>
<tr><td>PATCH</td><td>/produtos/{id}</td><td>Atualiza parcialmente</td></tr>
<tr><td>DELETE</td><td>/produtos/{id}</td><td>Remove um produto</td></tr>

</table>

</div>

---

## Exemplo de Produto (JSON)

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
3. Configure a string de conexão com o SQL Server no arquivo de configuração (caso necessário)
4. Execute o projeto
5. Utilize ferramentas como Postman para testar os endpoints

## Testes

Todos os endpoints foram testados utilizando o Postman, garantindo o funcionamento correto das operações de CRUD.
