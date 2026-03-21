using Microsoft.EntityFrameworkCore;
using Produtos_Entrega;

namespace Produtos_Entrega
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<ProdutoDb>(opt =>
                opt.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Cadastro_Produtos;Trusted_Connection=True;TrustServerCertificate=True;"));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            var app = builder.Build();

            app.MapGet("/", () => "API Produtos - pronta!");

            app.MapGet("/produtos", async (ProdutoDb db) => Results.Ok(await db.Produtos.ToListAsync()));

            app.MapGet("/produtos/por-codigo/{codigo}", async (ProdutoDb db, string codigo) =>
                await db.Produtos.FirstOrDefaultAsync(p => p.Codigo == codigo) is Produto p ? Results.Ok(p) : Results.NotFound());

            app.MapGet("/produtos/por-categoria/{categoria}", async (ProdutoDb db, string categoria) =>
            {
                var produtos = await db.Produtos.Where(p => p.Categoria == categoria).ToListAsync();
                return produtos.Any() ? Results.Ok(produtos) : Results.NotFound();
            });

            app.MapPost("/produtos", async (ProdutoDb db, Produto p) =>
            {
                db.Produtos.Add(p);
                await db.SaveChangesAsync();
                return Results.Created($"/produtos/por-codigo/{p.Codigo}", p);
            });

            app.MapPut("/produtos/{id}", async (ProdutoDb db, int id, Produto p) =>
            {
                var existente = await db.Produtos.FindAsync(id);
                if (existente is null) return Results.NotFound();

                existente.Nome = p.Nome;
                existente.Codigo = p.Codigo;
                existente.Preco = p.Preco;
                existente.Descricao = p.Descricao;
                existente.QtdEstoque = p.QtdEstoque;
                existente.Avaliacao = p.Avaliacao;
                existente.Categoria = p.Categoria;

                await db.SaveChangesAsync();
                return Results.NoContent();
            });

            app.MapPatch("/produtos/{id}", async (ProdutoDb db, int id, Produto p) =>
            {
                var existente = await db.Produtos.FindAsync(id);
                if (existente is null) return Results.NotFound();

                if (!string.IsNullOrEmpty(p.Nome)) existente.Nome = p.Nome;
                if (!string.IsNullOrEmpty(p.Codigo)) existente.Codigo = p.Codigo;
                if (p.Preco > 0) existente.Preco = p.Preco;
                if (!string.IsNullOrEmpty(p.Descricao)) existente.Descricao = p.Descricao;
                if (p.QtdEstoque > 0) existente.QtdEstoque = p.QtdEstoque;
                if (p.Avaliacao > 0) existente.Avaliacao = p.Avaliacao;
                if (!string.IsNullOrEmpty(p.Categoria)) existente.Categoria = p.Categoria;

                await db.SaveChangesAsync();
                return Results.NoContent();
            });

            app.MapDelete("/produtos/{id}", async (ProdutoDb db, int id) =>
            {
                var existente = await db.Produtos.FindAsync(id);
                if (existente is null) return Results.NotFound();

                db.Produtos.Remove(existente);
                await db.SaveChangesAsync();
                return Results.Ok(existente);
            });

            app.Run();
        }
    }
}