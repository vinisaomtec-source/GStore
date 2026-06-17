using GStore.API.Data;
using GStore.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GStore.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProdutosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Produto>> GetProdutos()
    {
        return Ok(_context.Produtos.ToList());
    }

    [HttpGet("{id}")]
    public ActionResult<Produto> GetProduto(int id)
    {
        var produto = _context.Produtos.Find(id);
        return produto == null ? NotFound("Produto não localizado") : Ok(produto);
    }

    [HttpPost]
    public ActionResult<Produto> PostProduto([FromBody] Produto produto)
    {
        if (!ModelState.IsValid)
            return BadRequest("Confira os dados enviados!");

        _context.Produtos.Add(produto);
        _context.SaveChanges();

        return CreatedAtAction("GetProduto", new { id = produto.Id }, produto);
    }

    [HttpPut("{id}")]
    public ActionResult PutProduto(int id, [FromBody] Produto produto)
    {
        if (id != produto.Id || !ModelState.IsValid)
            return BadRequest("Confira os dados enviados");

        var oldProduto = _context.Produtos.Find(id);
        if (oldProduto == null)
            return NotFound("Produto não localizado");

        oldProduto.Nome = produto.Nome;

        _context.Entry(oldProduto).State = EntityState.Modified;
        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteProduto(int id)
    {
        var produto = _context.Produtos.Find(id);
        if (produto == null)
            return NotFound("Produto não localizado");

        _context.Produtos.Remove(produto);
        _context.SaveChanges();

        return NoContent();
    }
}