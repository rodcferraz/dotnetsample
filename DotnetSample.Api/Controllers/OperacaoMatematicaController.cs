using DotnetSample.Api.Calculo;
using Microsoft.AspNetCore.Mvc;

namespace DotnetSample.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OperacaoMatematicaController : ControllerBase
{

    [HttpGet("somar")]
    public IActionResult Somar(double a, double b)
    {
        var resultado = OperacoesMatematicas.Somar(a, b);
        return Ok(new { a, b, resultado });
    }

    [HttpGet("diminuir")]
    public IActionResult Diminuir(double a, double b)
    {
        var resultado = OperacoesMatematicas.Diminuir(a, b);
        return Ok(new { a, b, resultado });
    }
}
