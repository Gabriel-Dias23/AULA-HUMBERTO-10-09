using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpPost]
        public IActionResult CriarProduto([FromBody] Produto produto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            // Aqui você poderia salvar o produto no banco
            return Ok("Produto criado com sucesso!");
        }
    }
}
