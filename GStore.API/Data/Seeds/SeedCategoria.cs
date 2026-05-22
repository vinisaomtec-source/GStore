using GStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Data.Seeds;

public class SeedCategoria
{
    public SeedCategoria(ModelBuilder builder)
    {
        List<Categoria> categorias = [
            new() {Id = 1, Nome = "Smartphones"},
            new() {Id = 2, Nome = "Notebooks"},
            new() {Id = 3, Nome = "Smartwatches"},
            new() {Id = 4, Nome = "Fones de Ouvido"},
            new() {Id = 5, Nome = "Monitores"},
            new() {Id = 6, Nome = "Teclados e Mouses"},
            new() { Id = 7, Nome = "Tablets" },
            new() { Id = 8, Nome = "Câmeras" },
            new() { Id = 9, Nome = "Impressoras" },
            new() { Id = 10, Nome = "Games e Consoles" }
        ];
        builder.Entity<Categoria>().HasData(categorias);
    }        
}
