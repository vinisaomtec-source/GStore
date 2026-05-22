using GStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedProduto
{
    public SeedProduto(ModelBuilder builder)
    {
        List<Produto> produtos = [
            new() {
                Id = 1,
                CategoriaId = 1,
                Nome="",
                Descricao="",
                ValorCusto = 0m,
                ValorVenda = 0m,
                Qtde = 0,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            }
        ];
        builder.Entity<Produto>().HasData(produtos);
    }
}
