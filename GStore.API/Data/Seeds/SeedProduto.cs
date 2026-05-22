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
        Nome = "iPhone 15 Pro",
        Descricao = "Smartphone Apple 256GB",
        ValorCusto = 5500m,
        ValorVenda = 7499m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/1.png"
    },
    new() {
        Id = 2,
        CategoriaId = 1,
        Nome = "Galaxy S24 Ultra",
        Descricao = "Smartphone Samsung premium",
        ValorCusto = 4800m,
        ValorVenda = 6899m,
        Qtde = 8,
        Destaque = true,
        Foto = "/img/produtos/2.png"
    },
    new() {
        Id = 3,
        CategoriaId = 1,
        Nome = "Xiaomi 14",
        Descricao = "Smartphone Xiaomi avançado",
        ValorCusto = 3200m,
        ValorVenda = 4699m,
        Qtde = 12,
        Destaque = false,
        Foto = "/img/produtos/3.png"
    },
    new() {
        Id = 4,
        CategoriaId = 1,
        Nome = "Moto Edge 50",
        Descricao = "Smartphone Motorola premium",
        ValorCusto = 2600m,
        ValorVenda = 3899m,
        Qtde = 15,
        Destaque = false,
        Foto = "/img/produtos/4.png"
    },
    new() {
        Id = 5,
        CategoriaId = 1,
        Nome = "Redmi Note 13",
        Descricao = "Smartphone intermediário Xiaomi",
        ValorCusto = 1400m,
        ValorVenda = 2199m,
        Qtde = 20,
        Destaque = true,
        Foto = "/img/produtos/5.png"
    },
    new() {
        Id = 6,
        CategoriaId = 1,
        Nome = "Asus ROG Phone 8",
        Descricao = "Smartphone gamer Asus",
        ValorCusto = 5000m,
        ValorVenda = 7299m,
        Qtde = 5,
        Destaque = true,
        Foto = "/img/produtos/6.png"
    },
    new() {
        Id = 7,
        CategoriaId = 1,
        Nome = "Poco X6 Pro",
        Descricao = "Smartphone custo benefício",
        ValorCusto = 1800m,
        ValorVenda = 2699m,
        Qtde = 18,
        Destaque = false,
        Foto = "/img/produtos/7.png"
    },
    new() {
        Id = 8,
        CategoriaId = 1,
        Nome = "Zenfone 11",
        Descricao = "Smartphone compacto premium",
        ValorCusto = 3500m,
        ValorVenda = 4999m,
        Qtde = 7,
        Destaque = false,
        Foto = "/img/produtos/8.png"
    },
    new() {
        Id = 9,
        CategoriaId = 1,
        Nome = "Realme GT 6",
        Descricao = "Smartphone alta performance",
        ValorCusto = 2400m,
        ValorVenda = 3599m,
        Qtde = 14,
        Destaque = false,
        Foto = "/img/produtos/9.png"
    },
    new() {
        Id = 10,
        CategoriaId = 1,
        Nome = "Galaxy A55",
        Descricao = "Smartphone Samsung intermediário",
        ValorCusto = 1700m,
        ValorVenda = 2499m,
        Qtde = 25,
        Destaque = true,
        Foto = "/img/produtos/10.png"
    },

    // =========================
    // Notebooks
    // =========================
    new() {
        Id = 11,
        CategoriaId = 2,
        Nome = "MacBook Air M3",
        Descricao = "Notebook Apple ultrafino",
        ValorCusto = 7500m,
        ValorVenda = 9999m,
        Qtde = 5,
        Destaque = true,
        Foto = "/img/produtos/11.png"
    },
    new() {
        Id = 12,
        CategoriaId = 2,
        Nome = "Dell Inspiron 15",
        Descricao = "Notebook Dell Intel i7",
        ValorCusto = 4200m,
        ValorVenda = 5899m,
        Qtde = 8,
        Destaque = false,
        Foto = "/img/produtos/12.png"
    },
    new() {
        Id = 13,
        CategoriaId = 2,
        Nome = "Acer Nitro 5",
        Descricao = "Notebook gamer Acer",
        ValorCusto = 4600m,
        ValorVenda = 6799m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/13.png"
    },
    new() {
        Id = 14,
        CategoriaId = 2,
        Nome = "Lenovo IdeaPad 3",
        Descricao = "Notebook Lenovo Ryzen",
        ValorCusto = 2900m,
        ValorVenda = 4299m,
        Qtde = 10,
        Destaque = false,
        Foto = "/img/produtos/14.png"
    },
    new() {
        Id = 15,
        CategoriaId = 2,
        Nome = "Samsung Book",
        Descricao = "Notebook Samsung para estudos",
        ValorCusto = 2200m,
        ValorVenda = 3199m,
        Qtde = 15,
        Destaque = false,
        Foto = "/img/produtos/15.png"
    },
    new() {
        Id = 16,
        CategoriaId = 2,
        Nome = "Alienware M16",
        Descricao = "Notebook gamer premium",
        ValorCusto = 9800m,
        ValorVenda = 12999m,
        Qtde = 3,
        Destaque = true,
        Foto = "/img/produtos/16.png"
    },
    new() {
        Id = 17,
        CategoriaId = 2,
        Nome = "HP Pavilion",
        Descricao = "Notebook HP moderno",
        ValorCusto = 3900m,
        ValorVenda = 5499m,
        Qtde = 9,
        Destaque = true,
        Foto = "/img/produtos/17.png"
    },
    new() {
        Id = 18,
        CategoriaId = 2,
        Nome = "LG Gram",
        Descricao = "Notebook ultraleve LG",
        ValorCusto = 6200m,
        ValorVenda = 8599m,
        Qtde = 4,
        Destaque = false,
        Foto = "/img/produtos/18.png"
    },
    new() {
        Id = 19,
        CategoriaId = 2,
        Nome = "Asus Vivobook",
        Descricao = "Notebook Asus moderno",
        ValorCusto = 2800m,
        ValorVenda = 4199m,
        Qtde = 11,
        Destaque = false,
        Foto = "/img/produtos/19.png"
    },
    new() {
        Id = 20,
        CategoriaId = 2,
        Nome = "Positivo Vision",
        Descricao = "Notebook básico econômico",
        ValorCusto = 1500m,
        ValorVenda = 2299m,
        Qtde = 20,
        Destaque = false,
        Foto = "/img/produtos/20.png"
    },
        // =========================
    // Smartwatches
    // =========================
    new() {
        Id = 21,
        CategoriaId = 3,
        Nome = "Apple Watch Series 9",
        Descricao = "Smartwatch Apple premium",
        ValorCusto = 2500m,
        ValorVenda = 3999m,
        Qtde = 8,
        Destaque = true,
        Foto = "/img/produtos/21.png"
    },
    new() {
        Id = 22,
        CategoriaId = 3,
        Nome = "Galaxy Watch 6",
        Descricao = "Smartwatch Samsung moderno",
        ValorCusto = 1400m,
        ValorVenda = 2299m,
        Qtde = 12,
        Destaque = true,
        Foto = "/img/produtos/22.png"
    },
    new() {
        Id = 23,
        CategoriaId = 3,
        Nome = "Amazfit GTR 4",
        Descricao = "Smartwatch com bateria longa",
        ValorCusto = 700m,
        ValorVenda = 1299m,
        Qtde = 15,
        Destaque = false,
        Foto = "/img/produtos/23.png"
    },
    new() {
        Id = 24,
        CategoriaId = 3,
        Nome = "Xiaomi Watch S3",
        Descricao = "Relógio inteligente Xiaomi",
        ValorCusto = 650m,
        ValorVenda = 1199m,
        Qtde = 20,
        Destaque = false,
        Foto = "/img/produtos/24.png"
    },
    new() {
        Id = 25,
        CategoriaId = 3,
        Nome = "Garmin Forerunner",
        Descricao = "Smartwatch esportivo Garmin",
        ValorCusto = 1800m,
        ValorVenda = 2999m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/25.png"
    },
    new() {
        Id = 26,
        CategoriaId = 3,
        Nome = "Huawei Watch GT",
        Descricao = "Smartwatch elegante Huawei",
        ValorCusto = 900m,
        ValorVenda = 1599m,
        Qtde = 10,
        Destaque = false,
        Foto = "/img/produtos/26.png"
    },
    new() {
        Id = 27,
        CategoriaId = 3,
        Nome = "Fitbit Versa 4",
        Descricao = "Smartwatch fitness Fitbit",
        ValorCusto = 850m,
        ValorVenda = 1499m,
        Qtde = 11,
        Destaque = false,
        Foto = "/img/produtos/27.png"
    },
    new() {
        Id = 28,
        CategoriaId = 3,
        Nome = "TicWatch Pro 5",
        Descricao = "Smartwatch Android premium",
        ValorCusto = 1300m,
        ValorVenda = 2199m,
        Qtde = 7,
        Destaque = true,
        Foto = "/img/produtos/28.png"
    },
    new() {
        Id = 29,
        CategoriaId = 3,
        Nome = "Realme Watch 3",
        Descricao = "Smartwatch acessível",
        ValorCusto = 300m,
        ValorVenda = 599m,
        Qtde = 25,
        Destaque = false,
        Foto = "/img/produtos/29.png"
    },
    new() {
        Id = 30,
        CategoriaId = 3,
        Nome = "Polar Ignite",
        Descricao = "Relógio para esportes",
        ValorCusto = 1100m,
        ValorVenda = 1899m,
        Qtde = 9,
        Destaque = true,
        Foto = "/img/produtos/30.png"
    },

    // =========================
    // Fones de Ouvido
    // =========================
    new() {
        Id = 31,
        CategoriaId = 4,
        Nome = "AirPods Pro 2",
        Descricao = "Fone Apple sem fio",
        ValorCusto = 1400m,
        ValorVenda = 2199m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/31.png"
    },
    new() {
        Id = 32,
        CategoriaId = 4,
        Nome = "Galaxy Buds FE",
        Descricao = "Fone Samsung bluetooth",
        ValorCusto = 350m,
        ValorVenda = 699m,
        Qtde = 20,
        Destaque = false,
        Foto = "/img/produtos/32.png"
    },
    new() {
        Id = 33,
        CategoriaId = 4,
        Nome = "JBL Tune 720BT",
        Descricao = "Headphone JBL potente",
        ValorCusto = 300m,
        ValorVenda = 549m,
        Qtde = 15,
        Destaque = true,
        Foto = "/img/produtos/33.png"
    },
    new() {
        Id = 34,
        CategoriaId = 4,
        Nome = "Sony WH-1000XM5",
        Descricao = "Headphone premium Sony",
        ValorCusto = 1800m,
        ValorVenda = 2799m,
        Qtde = 5,
        Destaque = true,
        Foto = "/img/produtos/34.png"
    },
    new() {
        Id = 35,
        CategoriaId = 4,
        Nome = "Redmi Buds 5",
        Descricao = "Fone Xiaomi bluetooth",
        ValorCusto = 180m,
        ValorVenda = 349m,
        Qtde = 30,
        Destaque = false,
        Foto = "/img/produtos/35.png"
    },
    new() {
        Id = 36,
        CategoriaId = 4,
        Nome = "HyperX Cloud II",
        Descricao = "Headset gamer HyperX",
        ValorCusto = 400m,
        ValorVenda = 799m,
        Qtde = 18,
        Destaque = true,
        Foto = "/img/produtos/36.png"
    },
    new() {
        Id = 37,
        CategoriaId = 4,
        Nome = "Logitech G435",
        Descricao = "Headset gamer sem fio",
        ValorCusto = 350m,
        ValorVenda = 699m,
        Qtde = 16,
        Destaque = false,
        Foto = "/img/produtos/37.png"
    },
    new() {
        Id = 38,
        CategoriaId = 4,
        Nome = "Edifier W800BT",
        Descricao = "Headphone bluetooth Edifier",
        ValorCusto = 220m,
        ValorVenda = 449m,
        Qtde = 14,
        Destaque = false,
        Foto = "/img/produtos/38.png"
    },
    new() {
        Id = 39,
        CategoriaId = 4,
        Nome = "Beats Studio Buds",
        Descricao = "Fone premium Beats",
        ValorCusto = 900m,
        ValorVenda = 1599m,
        Qtde = 9,
        Destaque = true,
        Foto = "/img/produtos/39.png"
    },
    new() {
        Id = 40,
        CategoriaId = 4,
        Nome = "Razer BlackShark V2",
        Descricao = "Headset gamer profissional",
        ValorCusto = 500m,
        ValorVenda = 899m,
        Qtde = 12,
        Destaque = true,
        Foto = "/img/produtos/40.png"
    },

    // =========================
    // Monitores
    // =========================
    new() {
        Id = 41,
        CategoriaId = 5,
        Nome = "LG UltraWide 29",
        Descricao = "Monitor ultrawide Full HD",
        ValorCusto = 1200m,
        ValorVenda = 1899m,
        Qtde = 9,
        Destaque = true,
        Foto = "/img/produtos/41.png"
    },
    new() {
        Id = 42,
        CategoriaId = 5,
        Nome = "Samsung Odyssey G5",
        Descricao = "Monitor gamer curvo",
        ValorCusto = 1700m,
        ValorVenda = 2599m,
        Qtde = 7,
        Destaque = true,
        Foto = "/img/produtos/42.png"
    },
    new() {
        Id = 43,
        CategoriaId = 5,
        Nome = "Dell P2422H",
        Descricao = "Monitor profissional Dell",
        ValorCusto = 900m,
        ValorVenda = 1499m,
        Qtde = 12,
        Destaque = false,
        Foto = "/img/produtos/43.png"
    },
    new() {
        Id = 44,
        CategoriaId = 5,
        Nome = "AOC Hero 24",
        Descricao = "Monitor gamer 144Hz",
        ValorCusto = 1100m,
        ValorVenda = 1799m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/44.png"
    },
    new() {
        Id = 45,
        CategoriaId = 5,
        Nome = "Asus TUF Gaming",
        Descricao = "Monitor gamer Asus",
        ValorCusto = 1500m,
        ValorVenda = 2299m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/45.png"
    },
    new() {
        Id = 46,
        CategoriaId = 5,
        Nome = "Philips 241V8",
        Descricao = "Monitor LED Philips",
        ValorCusto = 650m,
        ValorVenda = 1099m,
        Qtde = 15,
        Destaque = false,
        Foto = "/img/produtos/46.png"
    },
    new() {
        Id = 47,
        CategoriaId = 5,
        Nome = "BenQ Zowie",
        Descricao = "Monitor competitivo esports",
        ValorCusto = 1800m,
        ValorVenda = 2799m,
        Qtde = 5,
        Destaque = true,
        Foto = "/img/produtos/47.png"
    },
    new() {
        Id = 48,
        CategoriaId = 5,
        Nome = "Gigabyte G27Q",
        Descricao = "Monitor QHD gamer",
        ValorCusto = 1600m,
        ValorVenda = 2499m,
        Qtde = 8,
        Destaque = true,
        Foto = "/img/produtos/48.png"
    },
    new() {
        Id = 49,
        CategoriaId = 5,
        Nome = "Samsung Smart Monitor",
        Descricao = "Monitor inteligente Samsung",
        ValorCusto = 1300m,
        ValorVenda = 1999m,
        Qtde = 9,
        Destaque = false,
        Foto = "/img/produtos/49.png"
    },
    new() {
        Id = 50,
        CategoriaId = 5,
        Nome = "LG UltraGear 27",
        Descricao = "Monitor gamer LG",
        ValorCusto = 1400m,
        ValorVenda = 2199m,
        Qtde = 11,
        Destaque = true,
        Foto = "/img/produtos/50.png"
    },

    // =========================
    // Teclados e Mouses
    // =========================
    new() {
        Id = 51,
        CategoriaId = 6,
        Nome = "Logitech MX Master 3",
        Descricao = "Mouse premium Logitech",
        ValorCusto = 400m,
        ValorVenda = 699m,
        Qtde = 15,
        Destaque = true,
        Foto = "/img/produtos/51.png"
    },
    new() {
        Id = 52,
        CategoriaId = 6,
        Nome = "Redragon Kumara",
        Descricao = "Teclado mecânico gamer",
        ValorCusto = 180m,
        ValorVenda = 349m,
        Qtde = 22,
        Destaque = false,
        Foto = "/img/produtos/52.png"
    },
    new() {
        Id = 53,
        CategoriaId = 6,
        Nome = "Razer DeathAdder",
        Descricao = "Mouse gamer Razer",
        ValorCusto = 220m,
        ValorVenda = 499m,
        Qtde = 18,
        Destaque = true,
        Foto = "/img/produtos/53.png"
    },
    new() {
        Id = 54,
        CategoriaId = 6,
        Nome = "Corsair K95",
        Descricao = "Teclado gamer RGB",
        ValorCusto = 700m,
        ValorVenda = 1199m,
        Qtde = 7,
        Destaque = true,
        Foto = "/img/produtos/54.png"
    },
    new() {
        Id = 55,
        CategoriaId = 6,
        Nome = "Logitech G Pro",
        Descricao = "Mouse gamer profissional",
        ValorCusto = 350m,
        ValorVenda = 649m,
        Qtde = 13,
        Destaque = true,
        Foto = "/img/produtos/55.png"
    },
    new() {
        Id = 56,
        CategoriaId = 6,
        Nome = "HyperX Alloy Origins",
        Descricao = "Teclado mecânico HyperX",
        ValorCusto = 300m,
        ValorVenda = 599m,
        Qtde = 14,
        Destaque = false,
        Foto = "/img/produtos/56.png"
    },
    new() {
        Id = 57,
        CategoriaId = 6,
        Nome = "Dell KM5221W",
        Descricao = "Kit teclado e mouse sem fio",
        ValorCusto = 150m,
        ValorVenda = 299m,
        Qtde = 20,
        Destaque = false,
        Foto = "/img/produtos/57.png"
    },
    new() {
        Id = 58,
        CategoriaId = 6,
        Nome = "Razer Huntsman Mini",
        Descricao = "Teclado compacto gamer",
        ValorCusto = 450m,
        ValorVenda = 899m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/58.png"
    },
    new() {
        Id = 59,
        CategoriaId = 6,
        Nome = "Logitech Pebble",
        Descricao = "Mouse portátil silencioso",
        ValorCusto = 120m,
        ValorVenda = 249m,
        Qtde = 25,
        Destaque = false,
        Foto = "/img/produtos/59.png"
    },
    new() {
        Id = 60,
        CategoriaId = 6,
        Nome = "SteelSeries Apex Pro",
        Descricao = "Teclado gamer premium",
        ValorCusto = 850m,
        ValorVenda = 1399m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/60.png"
    },

    // =========================
    // Monitores
    // =========================
    new() {
        Id = 41,
        CategoriaId = 5,
        Nome = "LG UltraWide 29",
        Descricao = "Monitor ultrawide Full HD",
        ValorCusto = 1200m,
        ValorVenda = 1899m,
        Qtde = 9,
        Destaque = true,
        Foto = "/img/produtos/41.png"
    },
    new() {
        Id = 42,
        CategoriaId = 5,
        Nome = "Samsung Odyssey G5",
        Descricao = "Monitor gamer curvo",
        ValorCusto = 1700m,
        ValorVenda = 2599m,
        Qtde = 7,
        Destaque = true,
        Foto = "/img/produtos/42.png"
    },
    new() {
        Id = 43,
        CategoriaId = 5,
        Nome = "Dell P2422H",
        Descricao = "Monitor profissional Dell",
        ValorCusto = 900m,
        ValorVenda = 1499m,
        Qtde = 12,
        Destaque = false,
        Foto = "/img/produtos/43.png"
    },
    new() {
        Id = 44,
        CategoriaId = 5,
        Nome = "AOC Hero 24",
        Descricao = "Monitor gamer 144Hz",
        ValorCusto = 1100m,
        ValorVenda = 1799m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/44.png"
    },
    new() {
        Id = 45,
        CategoriaId = 5,
        Nome = "Asus TUF Gaming",
        Descricao = "Monitor gamer Asus",
        ValorCusto = 1500m,
        ValorVenda = 2299m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/45.png"
    },
    new() {
        Id = 46,
        CategoriaId = 5,
        Nome = "Philips 241V8",
        Descricao = "Monitor LED Philips",
        ValorCusto = 650m,
        ValorVenda = 1099m,
        Qtde = 15,
        Destaque = false,
        Foto = "/img/produtos/46.png"
    },
    new() {
        Id = 47,
        CategoriaId = 5,
        Nome = "BenQ Zowie",
        Descricao = "Monitor competitivo esports",
        ValorCusto = 1800m,
        ValorVenda = 2799m,
        Qtde = 5,
        Destaque = true,
        Foto = "/img/produtos/47.png"
    },
    new() {
        Id = 48,
        CategoriaId = 5,
        Nome = "Gigabyte G27Q",
        Descricao = "Monitor QHD gamer",
        ValorCusto = 1600m,
        ValorVenda = 2499m,
        Qtde = 8,
        Destaque = true,
        Foto = "/img/produtos/48.png"
    },
    new() {
        Id = 49,
        CategoriaId = 5,
        Nome = "Samsung Smart Monitor",
        Descricao = "Monitor inteligente Samsung",
        ValorCusto = 1300m,
        ValorVenda = 1999m,
        Qtde = 9,
        Destaque = false,
        Foto = "/img/produtos/49.png"
    },
    new() {
        Id = 50,
        CategoriaId = 5,
        Nome = "LG UltraGear 27",
        Descricao = "Monitor gamer LG",
        ValorCusto = 1400m,
        ValorVenda = 2199m,
        Qtde = 11,
        Destaque = true,
        Foto = "/img/produtos/50.png"
    },

    // =========================
    // Teclados e Mouses
    // =========================
    new() {
        Id = 51,
        CategoriaId = 6,
        Nome = "Logitech MX Master 3",
        Descricao = "Mouse premium Logitech",
        ValorCusto = 400m,
        ValorVenda = 699m,
        Qtde = 15,
        Destaque = true,
        Foto = "/img/produtos/51.png"
    },
    new() {
        Id = 52,
        CategoriaId = 6,
        Nome = "Redragon Kumara",
        Descricao = "Teclado mecânico gamer",
        ValorCusto = 180m,
        ValorVenda = 349m,
        Qtde = 22,
        Destaque = false,
        Foto = "/img/produtos/52.png"
    },
    new() {
        Id = 53,
        CategoriaId = 6,
        Nome = "Razer DeathAdder",
        Descricao = "Mouse gamer Razer",
        ValorCusto = 220m,
        ValorVenda = 499m,
        Qtde = 18,
        Destaque = true,
        Foto = "/img/produtos/53.png"
    },
    new() {
        Id = 54,
        CategoriaId = 6,
        Nome = "Corsair K95",
        Descricao = "Teclado gamer RGB",
        ValorCusto = 700m,
        ValorVenda = 1199m,
        Qtde = 7,
        Destaque = true,
        Foto = "/img/produtos/54.png"
    },
    new() {
        Id = 55,
        CategoriaId = 6,
        Nome = "Logitech G Pro",
        Descricao = "Mouse gamer profissional",
        ValorCusto = 350m,
        ValorVenda = 649m,
        Qtde = 13,
        Destaque = true,
        Foto = "/img/produtos/55.png"
    },
    new() {
        Id = 56,
        CategoriaId = 6,
        Nome = "HyperX Alloy Origins",
        Descricao = "Teclado mecânico HyperX",
        ValorCusto = 300m,
        ValorVenda = 599m,
        Qtde = 14,
        Destaque = false,
        Foto = "/img/produtos/56.png"
    },
    new() {
        Id = 57,
        CategoriaId = 6,
        Nome = "Dell KM5221W",
        Descricao = "Kit teclado e mouse sem fio",
        ValorCusto = 150m,
        ValorVenda = 299m,
        Qtde = 20,
        Destaque = false,
        Foto = "/img/produtos/57.png"
    },
    new() {
        Id = 58,
        CategoriaId = 6,
        Nome = "Razer Huntsman Mini",
        Descricao = "Teclado compacto gamer",
        ValorCusto = 450m,
        ValorVenda = 899m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/58.png"
    },
    new() {
        Id = 59,
        CategoriaId = 6,
        Nome = "Logitech Pebble",
        Descricao = "Mouse portátil silencioso",
        ValorCusto = 120m,
        ValorVenda = 249m,
        Qtde = 25,
        Destaque = false,
        Foto = "/img/produtos/59.png"
    },
    new() {
        Id = 60,
        CategoriaId = 6,
        Nome = "SteelSeries Apex Pro",
        Descricao = "Teclado gamer premium",
        ValorCusto = 850m,
        ValorVenda = 1399m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/60.png"
    },
    // =========================
    // Monitores
    // =========================
    new() {
        Id = 41,
        CategoriaId = 5,
        Nome = "LG UltraWide 29",
        Descricao = "Monitor ultrawide Full HD",
        ValorCusto = 1200m,
        ValorVenda = 1899m,
        Qtde = 9,
        Destaque = true,
        Foto = "/img/produtos/41.png"
    },
    new() {
        Id = 42,
        CategoriaId = 5,
        Nome = "Samsung Odyssey G5",
        Descricao = "Monitor gamer curvo",
        ValorCusto = 1700m,
        ValorVenda = 2599m,
        Qtde = 7,
        Destaque = true,
        Foto = "/img/produtos/42.png"
    },
    new() {
        Id = 43,
        CategoriaId = 5,
        Nome = "Dell P2422H",
        Descricao = "Monitor profissional Dell",
        ValorCusto = 900m,
        ValorVenda = 1499m,
        Qtde = 12,
        Destaque = false,
        Foto = "/img/produtos/43.png"
    },
    new() {
        Id = 44,
        CategoriaId = 5,
        Nome = "AOC Hero 24",
        Descricao = "Monitor gamer 144Hz",
        ValorCusto = 1100m,
        ValorVenda = 1799m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/44.png"
    },
    new() {
        Id = 45,
        CategoriaId = 5,
        Nome = "Asus TUF Gaming",
        Descricao = "Monitor gamer Asus",
        ValorCusto = 1500m,
        ValorVenda = 2299m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/45.png"
    },
    new() {
        Id = 46,
        CategoriaId = 5,
        Nome = "Philips 241V8",
        Descricao = "Monitor LED Philips",
        ValorCusto = 650m,
        ValorVenda = 1099m,
        Qtde = 15,
        Destaque = false,
        Foto = "/img/produtos/46.png"
    },
    new() {
        Id = 47,
        CategoriaId = 5,
        Nome = "BenQ Zowie",
        Descricao = "Monitor competitivo esports",
        ValorCusto = 1800m,
        ValorVenda = 2799m,
        Qtde = 5,
        Destaque = true,
        Foto = "/img/produtos/47.png"
    },
    new() {
        Id = 48,
        CategoriaId = 5,
        Nome = "Gigabyte G27Q",
        Descricao = "Monitor QHD gamer",
        ValorCusto = 1600m,
        ValorVenda = 2499m,
        Qtde = 8,
        Destaque = true,
        Foto = "/img/produtos/48.png"
    },
    new() {
        Id = 49,
        CategoriaId = 5,
        Nome = "Samsung Smart Monitor",
        Descricao = "Monitor inteligente Samsung",
        ValorCusto = 1300m,
        ValorVenda = 1999m,
        Qtde = 9,
        Destaque = false,
        Foto = "/img/produtos/49.png"
    },
    new() {
        Id = 50,
        CategoriaId = 5,
        Nome = "LG UltraGear 27",
        Descricao = "Monitor gamer LG",
        ValorCusto = 1400m,
        ValorVenda = 2199m,
        Qtde = 11,
        Destaque = true,
        Foto = "/img/produtos/50.png"
    },

    // =========================
    // Teclados e Mouses
    // =========================
    new() {
        Id = 51,
        CategoriaId = 6,
        Nome = "Logitech MX Master 3",
        Descricao = "Mouse premium Logitech",
        ValorCusto = 400m,
        ValorVenda = 699m,
        Qtde = 15,
        Destaque = true,
        Foto = "/img/produtos/51.png"
    },
    new() {
        Id = 52,
        CategoriaId = 6,
        Nome = "Redragon Kumara",
        Descricao = "Teclado mecânico gamer",
        ValorCusto = 180m,
        ValorVenda = 349m,
        Qtde = 22,
        Destaque = false,
        Foto = "/img/produtos/52.png"
    },
    new() {
        Id = 53,
        CategoriaId = 6,
        Nome = "Razer DeathAdder",
        Descricao = "Mouse gamer Razer",
        ValorCusto = 220m,
        ValorVenda = 499m,
        Qtde = 18,
        Destaque = true,
        Foto = "/img/produtos/53.png"
    },
    new() {
        Id = 54,
        CategoriaId = 6,
        Nome = "Corsair K95",
        Descricao = "Teclado gamer RGB",
        ValorCusto = 700m,
        ValorVenda = 1199m,
        Qtde = 7,
        Destaque = true,
        Foto = "/img/produtos/54.png"
    },
    new() {
        Id = 55,
        CategoriaId = 6,
        Nome = "Logitech G Pro",
        Descricao = "Mouse gamer profissional",
        ValorCusto = 350m,
        ValorVenda = 649m,
        Qtde = 13,
        Destaque = true,
        Foto = "/img/produtos/55.png"
    },
    new() {
        Id = 56,
        CategoriaId = 6,
        Nome = "HyperX Alloy Origins",
        Descricao = "Teclado mecânico HyperX",
        ValorCusto = 300m,
        ValorVenda = 599m,
        Qtde = 14,
        Destaque = false,
        Foto = "/img/produtos/56.png"
    },
    new() {
        Id = 57,
        CategoriaId = 6,
        Nome = "Dell KM5221W",
        Descricao = "Kit teclado e mouse sem fio",
        ValorCusto = 150m,
        ValorVenda = 299m,
        Qtde = 20,
        Destaque = false,
        Foto = "/img/produtos/57.png"
    },
    new() {
        Id = 58,
        CategoriaId = 6,
        Nome = "Razer Huntsman Mini",
        Descricao = "Teclado compacto gamer",
        ValorCusto = 450m,
        ValorVenda = 899m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/58.png"
    },
    new() {
        Id = 59,
        CategoriaId = 6,
        Nome = "Logitech Pebble",
        Descricao = "Mouse portátil silencioso",
        ValorCusto = 120m,
        ValorVenda = 249m,
        Qtde = 25,
        Destaque = false,
        Foto = "/img/produtos/59.png"
    },
    new() {
        Id = 60,
        CategoriaId = 6,
        Nome = "SteelSeries Apex Pro",
        Descricao = "Teclado gamer premium",
        ValorCusto = 850m,
        ValorVenda = 1399m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/60.png"
    },
        // =========================
    // Monitores
    // =========================
    new() {
        Id = 41,
        CategoriaId = 5,
        Nome = "LG UltraWide 29",
        Descricao = "Monitor ultrawide Full HD",
        ValorCusto = 1200m,
        ValorVenda = 1899m,
        Qtde = 9,
        Destaque = true,
        Foto = "/img/produtos/41.png"
    },
    new() {
        Id = 42,
        CategoriaId = 5,
        Nome = "Samsung Odyssey G5",
        Descricao = "Monitor gamer curvo",
        ValorCusto = 1700m,
        ValorVenda = 2599m,
        Qtde = 7,
        Destaque = true,
        Foto = "/img/produtos/42.png"
    },
    new() {
        Id = 43,
        CategoriaId = 5,
        Nome = "Dell P2422H",
        Descricao = "Monitor profissional Dell",
        ValorCusto = 900m,
        ValorVenda = 1499m,
        Qtde = 12,
        Destaque = false,
        Foto = "/img/produtos/43.png"
    },
    new() {
        Id = 44,
        CategoriaId = 5,
        Nome = "AOC Hero 24",
        Descricao = "Monitor gamer 144Hz",
        ValorCusto = 1100m,
        ValorVenda = 1799m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/44.png"
    },
    new() {
        Id = 45,
        CategoriaId = 5,
        Nome = "Asus TUF Gaming",
        Descricao = "Monitor gamer Asus",
        ValorCusto = 1500m,
        ValorVenda = 2299m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/45.png"
    },
    new() {
        Id = 46,
        CategoriaId = 5,
        Nome = "Philips 241V8",
        Descricao = "Monitor LED Philips",
        ValorCusto = 650m,
        ValorVenda = 1099m,
        Qtde = 15,
        Destaque = false,
        Foto = "/img/produtos/46.png"
    },
    new() {
        Id = 47,
        CategoriaId = 5,
        Nome = "BenQ Zowie",
        Descricao = "Monitor competitivo esports",
        ValorCusto = 1800m,
        ValorVenda = 2799m,
        Qtde = 5,
        Destaque = true,
        Foto = "/img/produtos/47.png"
    },
    new() {
        Id = 48,
        CategoriaId = 5,
        Nome = "Gigabyte G27Q",
        Descricao = "Monitor QHD gamer",
        ValorCusto = 1600m,
        ValorVenda = 2499m,
        Qtde = 8,
        Destaque = true,
        Foto = "/img/produtos/48.png"
    },
    new() {
        Id = 49,
        CategoriaId = 5,
        Nome = "Samsung Smart Monitor",
        Descricao = "Monitor inteligente Samsung",
        ValorCusto = 1300m,
        ValorVenda = 1999m,
        Qtde = 9,
        Destaque = false,
        Foto = "/img/produtos/49.png"
    },
    new() {
        Id = 50,
        CategoriaId = 5,
        Nome = "LG UltraGear 27",
        Descricao = "Monitor gamer LG",
        ValorCusto = 1400m,
        ValorVenda = 2199m,
        Qtde = 11,
        Destaque = true,
        Foto = "/img/produtos/50.png"
    },

    // =========================
    // Teclados e Mouses
    // =========================
    new() {
        Id = 51,
        CategoriaId = 6,
        Nome = "Logitech MX Master 3",
        Descricao = "Mouse premium Logitech",
        ValorCusto = 400m,
        ValorVenda = 699m,
        Qtde = 15,
        Destaque = true,
        Foto = "/img/produtos/51.png"
    },
    new() {
        Id = 52,
        CategoriaId = 6,
        Nome = "Redragon Kumara",
        Descricao = "Teclado mecânico gamer",
        ValorCusto = 180m,
        ValorVenda = 349m,
        Qtde = 22,
        Destaque = false,
        Foto = "/img/produtos/52.png"
    },
    new() {
        Id = 53,
        CategoriaId = 6,
        Nome = "Razer DeathAdder",
        Descricao = "Mouse gamer Razer",
        ValorCusto = 220m,
        ValorVenda = 499m,
        Qtde = 18,
        Destaque = true,
        Foto = "/img/produtos/53.png"
    },
    new() {
        Id = 54,
        CategoriaId = 6,
        Nome = "Corsair K95",
        Descricao = "Teclado gamer RGB",
        ValorCusto = 700m,
        ValorVenda = 1199m,
        Qtde = 7,
        Destaque = true,
        Foto = "/img/produtos/54.png"
    },
    new() {
        Id = 55,
        CategoriaId = 6,
        Nome = "Logitech G Pro",
        Descricao = "Mouse gamer profissional",
        ValorCusto = 350m,
        ValorVenda = 649m,
        Qtde = 13,
        Destaque = true,
        Foto = "/img/produtos/55.png"
    },
    new() {
        Id = 56,
        CategoriaId = 6,
        Nome = "HyperX Alloy Origins",
        Descricao = "Teclado mecânico HyperX",
        ValorCusto = 300m,
        ValorVenda = 599m,
        Qtde = 14,
        Destaque = false,
        Foto = "/img/produtos/56.png"
    },
    new() {
        Id = 57,
        CategoriaId = 6,
        Nome = "Dell KM5221W",
        Descricao = "Kit teclado e mouse sem fio",
        ValorCusto = 150m,
        ValorVenda = 299m,
        Qtde = 20,
        Destaque = false,
        Foto = "/img/produtos/57.png"
    },
    new() {
        Id = 58,
        CategoriaId = 6,
        Nome = "Razer Huntsman Mini",
        Descricao = "Teclado compacto gamer",
        ValorCusto = 450m,
        ValorVenda = 899m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/58.png"
    },
    new() {
        Id = 59,
        CategoriaId = 6,
        Nome = "Logitech Pebble",
        Descricao = "Mouse portátil silencioso",
        ValorCusto = 120m,
        ValorVenda = 249m,
        Qtde = 25,
        Destaque = false,
        Foto = "/img/produtos/59.png"
    },
    new() {
        Id = 60,
        CategoriaId = 6,
        Nome = "SteelSeries Apex Pro",
        Descricao = "Teclado gamer premium",
        ValorCusto = 850m,
        ValorVenda = 1399m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/60.png"
    },
        // =========================
    // Tablets
    // =========================
    new() {
        Id = 61,
        CategoriaId = 7,
        Nome = "iPad Air",
        Descricao = "Tablet Apple poderoso",
        ValorCusto = 3200m,
        ValorVenda = 4999m,
        Qtde = 8,
        Destaque = true,
        Foto = "/img/produtos/61.png"
    },
    new() {
        Id = 62,
        CategoriaId = 7,
        Nome = "Galaxy Tab S9",
        Descricao = "Tablet Samsung premium",
        ValorCusto = 2800m,
        ValorVenda = 4299m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/62.png"
    },
    new() {
        Id = 63,
        CategoriaId = 7,
        Nome = "Xiaomi Pad 6",
        Descricao = "Tablet Xiaomi moderno",
        ValorCusto = 1800m,
        ValorVenda = 2999m,
        Qtde = 12,
        Destaque = false,
        Foto = "/img/produtos/63.png"
    },
    new() {
        Id = 64,
        CategoriaId = 7,
        Nome = "Lenovo Tab P12",
        Descricao = "Tablet Lenovo Android",
        ValorCusto = 1400m,
        ValorVenda = 2399m,
        Qtde = 14,
        Destaque = false,
        Foto = "/img/produtos/64.png"
    },
    new() {
        Id = 65,
        CategoriaId = 7,
        Nome = "iPad Mini",
        Descricao = "Tablet compacto Apple",
        ValorCusto = 2600m,
        ValorVenda = 3999m,
        Qtde = 9,
        Destaque = true,
        Foto = "/img/produtos/65.png"
    },
    new() {
        Id = 66,
        CategoriaId = 7,
        Nome = "Galaxy Tab A9",
        Descricao = "Tablet Samsung intermediário",
        ValorCusto = 1100m,
        ValorVenda = 1899m,
        Qtde = 18,
        Destaque = false,
        Foto = "/img/produtos/66.png"
    },
    new() {
        Id = 67,
        CategoriaId = 7,
        Nome = "Huawei MatePad",
        Descricao = "Tablet Huawei elegante",
        ValorCusto = 1700m,
        ValorVenda = 2799m,
        Qtde = 11,
        Destaque = false,
        Foto = "/img/produtos/67.png"
    },
    new() {
        Id = 68,
        CategoriaId = 7,
        Nome = "Amazon Fire Max",
        Descricao = "Tablet Amazon multimídia",
        ValorCusto = 900m,
        ValorVenda = 1599m,
        Qtde = 16,
        Destaque = false,
        Foto = "/img/produtos/68.png"
    },
    new() {
        Id = 69,
        CategoriaId = 7,
        Nome = "Microsoft Surface Go",
        Descricao = "Tablet híbrido Microsoft",
        ValorCusto = 3500m,
        ValorVenda = 5299m,
        Qtde = 5,
        Destaque = true,
        Foto = "/img/produtos/69.png"
    },
    new() {
        Id = 70,
        CategoriaId = 7,
        Nome = "Realme Pad",
        Descricao = "Tablet custo benefício",
        ValorCusto = 1000m,
        ValorVenda = 1699m,
        Qtde = 20,
        Destaque = false,
        Foto = "/img/produtos/70.png"
    },

    // =========================
    // Câmeras
    // =========================
    new() {
        Id = 71,
        CategoriaId = 8,
        Nome = "Canon EOS R50",
        Descricao = "Câmera mirrorless Canon",
        ValorCusto = 4200m,
        ValorVenda = 5999m,
        Qtde = 4,
        Destaque = true,
        Foto = "/img/produtos/71.png"
    },
    new() {
        Id = 72,
        CategoriaId = 8,
        Nome = "Sony Alpha ZV-E10",
        Descricao = "Câmera para criadores",
        ValorCusto = 3900m,
        ValorVenda = 5699m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/72.png"
    },
    new() {
        Id = 73,
        CategoriaId = 8,
        Nome = "Nikon Z30",
        Descricao = "Câmera Nikon compacta",
        ValorCusto = 3500m,
        ValorVenda = 5199m,
        Qtde = 5,
        Destaque = false,
        Foto = "/img/produtos/73.png"
    },
    new() {
        Id = 74,
        CategoriaId = 8,
        Nome = "GoPro Hero 12",
        Descricao = "Câmera de ação GoPro",
        ValorCusto = 2200m,
        ValorVenda = 3499m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/74.png"
    },
    new() {
        Id = 75,
        CategoriaId = 8,
        Nome = "DJI Osmo Pocket 3",
        Descricao = "Câmera portátil DJI",
        ValorCusto = 2600m,
        ValorVenda = 3999m,
        Qtde = 8,
        Destaque = true,
        Foto = "/img/produtos/75.png"
    },
    new() {
        Id = 76,
        CategoriaId = 8,
        Nome = "Canon SL3",
        Descricao = "Câmera DSLR Canon",
        ValorCusto = 2800m,
        ValorVenda = 4299m,
        Qtde = 7,
        Destaque = false,
        Foto = "/img/produtos/76.png"
    },
    new() {
        Id = 77,
        CategoriaId = 8,
        Nome = "Sony A6400",
        Descricao = "Câmera Sony profissional",
        ValorCusto = 4700m,
        ValorVenda = 6899m,
        Qtde = 4,
        Destaque = true,
        Foto = "/img/produtos/77.png"
    },
    new() {
        Id = 78,
        CategoriaId = 8,
        Nome = "Fujifilm X-T30",
        Descricao = "Câmera retrô Fujifilm",
        ValorCusto = 4100m,
        ValorVenda = 6199m,
        Qtde = 6,
        Destaque = false,
        Foto = "/img/produtos/78.png"
    },
    new() {
        Id = 79,
        CategoriaId = 8,
        Nome = "Insta360 X4",
        Descricao = "Câmera 360 graus",
        ValorCusto = 2400m,
        ValorVenda = 3899m,
        Qtde = 9,
        Destaque = true,
        Foto = "/img/produtos/79.png"
    },
    new() {
        Id = 80,
        CategoriaId = 8,
        Nome = "Panasonic Lumix G7",
        Descricao = "Câmera mirrorless Panasonic",
        ValorCusto = 3000m,
        ValorVenda = 4599m,
        Qtde = 5,
        Destaque = false,
        Foto = "/img/produtos/80.png"
    },
        // =========================
    // Impressoras
    // =========================
    new() {
        Id = 81,
        CategoriaId = 9,
        Nome = "Epson EcoTank L3250",
        Descricao = "Impressora tanque de tinta Epson",
        ValorCusto = 900m,
        ValorVenda = 1499m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/81.png"
    },
    new() {
        Id = 82,
        CategoriaId = 9,
        Nome = "HP DeskJet 2874",
        Descricao = "Impressora multifuncional HP",
        ValorCusto = 350m,
        ValorVenda = 699m,
        Qtde = 15,
        Destaque = false,
        Foto = "/img/produtos/82.png"
    },
    new() {
        Id = 83,
        CategoriaId = 9,
        Nome = "Canon Mega Tank G3110",
        Descricao = "Impressora Canon econômica",
        ValorCusto = 800m,
        ValorVenda = 1399m,
        Qtde = 9,
        Destaque = true,
        Foto = "/img/produtos/83.png"
    },
    new() {
        Id = 84,
        CategoriaId = 9,
        Nome = "Brother DCP-T420W",
        Descricao = "Impressora Wi-Fi Brother",
        ValorCusto = 950m,
        ValorVenda = 1599m,
        Qtde = 8,
        Destaque = false,
        Foto = "/img/produtos/84.png"
    },
    new() {
        Id = 85,
        CategoriaId = 9,
        Nome = "Samsung Xpress M2020",
        Descricao = "Impressora laser Samsung",
        ValorCusto = 700m,
        ValorVenda = 1199m,
        Qtde = 12,
        Destaque = false,
        Foto = "/img/produtos/85.png"
    },
    new() {
        Id = 86,
        CategoriaId = 9,
        Nome = "HP LaserJet Pro",
        Descricao = "Impressora laser profissional",
        ValorCusto = 1200m,
        ValorVenda = 1999m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/86.png"
    },
    new() {
        Id = 87,
        CategoriaId = 9,
        Nome = "Epson WorkForce",
        Descricao = "Impressora corporativa Epson",
        ValorCusto = 1500m,
        ValorVenda = 2399m,
        Qtde = 5,
        Destaque = true,
        Foto = "/img/produtos/87.png"
    },
    new() {
        Id = 88,
        CategoriaId = 9,
        Nome = "Canon Pixma TS",
        Descricao = "Impressora fotográfica Canon",
        ValorCusto = 600m,
        ValorVenda = 1099m,
        Qtde = 11,
        Destaque = false,
        Foto = "/img/produtos/88.png"
    },
    new() {
        Id = 89,
        CategoriaId = 9,
        Nome = "Brother HL-L2360DW",
        Descricao = "Impressora laser compacta",
        ValorCusto = 1000m,
        ValorVenda = 1699m,
        Qtde = 7,
        Destaque = false,
        Foto = "/img/produtos/89.png"
    },
    new() {
        Id = 90,
        CategoriaId = 9,
        Nome = "Xerox Phaser 3020",
        Descricao = "Impressora laser Xerox",
        ValorCusto = 850m,
        ValorVenda = 1399m,
        Qtde = 10,
        Destaque = true,
        Foto = "/img/produtos/90.png"
    },

    // =========================
    // Games e Consoles
    // =========================
    new() {
        Id = 91,
        CategoriaId = 10,
        Nome = "PlayStation 5",
        Descricao = "Console Sony nova geração",
        ValorCusto = 3200m,
        ValorVenda = 4499m,
        Qtde = 8,
        Destaque = true,
        Foto = "/img/produtos/91.png"
    },
    new() {
        Id = 92,
        CategoriaId = 10,
        Nome = "Xbox Series X",
        Descricao = "Console Microsoft premium",
        ValorCusto = 3000m,
        ValorVenda = 4299m,
        Qtde = 7,
        Destaque = true,
        Foto = "/img/produtos/92.png"
    },
    new() {
        Id = 93,
        CategoriaId = 10,
        Nome = "Nintendo Switch OLED",
        Descricao = "Console portátil Nintendo",
        ValorCusto = 1800m,
        ValorVenda = 2999m,
        Qtde = 12,
        Destaque = true,
        Foto = "/img/produtos/93.png"
    },
    new() {
        Id = 94,
        CategoriaId = 10,
        Nome = "PlayStation 5 Slim",
        Descricao = "Versão compacta do PS5",
        ValorCusto = 3100m,
        ValorVenda = 4399m,
        Qtde = 6,
        Destaque = true,
        Foto = "/img/produtos/94.png"
    },
    new() {
        Id = 95,
        CategoriaId = 10,
        Nome = "Xbox Series S",
        Descricao = "Console digital Microsoft",
        ValorCusto = 1900m,
        ValorVenda = 2899m,
        Qtde = 15,
        Destaque = false,
        Foto = "/img/produtos/95.png"
    },
    new() {
        Id = 96,
        CategoriaId = 10,
        Nome = "Meta Quest 3",
        Descricao = "Óculos VR para games",
        ValorCusto = 2500m,
        ValorVenda = 3899m,
        Qtde = 5,
        Destaque = true,
        Foto = "/img/produtos/96.png"
    },
    new() {
        Id = 97,
        CategoriaId = 10,
        Nome = "Steam Deck",
        Descricao = "Console portátil da Valve",
        ValorCusto = 2800m,
        ValorVenda = 4199m,
        Qtde = 7,
        Destaque = true,
        Foto = "/img/produtos/97.png"
    },
    new() {
        Id = 98,
        CategoriaId = 10,
        Nome = "Nintendo Switch Lite",
        Descricao = "Console portátil compacto",
        ValorCusto = 1200m,
        ValorVenda = 1999m,
        Qtde = 14,
        Destaque = false,
        Foto = "/img/produtos/98.png"
    },
    new() {
        Id = 99,
        CategoriaId = 10,
        Nome = "Controle DualSense",
        Descricao = "Controle sem fio PS5",
        ValorCusto = 320m,
        ValorVenda = 549m,
        Qtde = 20,
        Destaque = false,
        Foto = "/img/produtos/99.png"
    },
    new() {
        Id = 100,
        CategoriaId = 10,
        Nome = "Headset Pulse 3D",
        Descricao = "Headset gamer PlayStation",
        ValorCusto = 450m,
        ValorVenda = 799m,
        Qtde = 13,
        Destaque = true,
        Foto = "/img/produtos/100.png"
    },
        ];
        builder.Entity<Produto>().HasData(produtos);
    }
}


