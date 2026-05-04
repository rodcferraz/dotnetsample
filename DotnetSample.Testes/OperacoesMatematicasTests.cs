using DotnetSample.Api.Calculo;

namespace DotnetSample.Testes;

public class OperacoesMatematicasTests
{
    [Fact]
    public void Somar_DeveRetornarSomaDosDoisValores()
    {
        var resultado = OperacoesMatematicas.Somar(5.5, 4.5);

        Assert.Equal(10.0, resultado, precision: 5);
    }

    [Theory]
    [InlineData(10.0, 5.0, 5.0)]
    [InlineData(0.0, 0.0, 0.0)]
    [InlineData(-3.0, -2.0, -1.0)]
    [InlineData(2.5, 1.25, 1.25)]
    public void Diminuir_DeveRetornarDiferencaDosDoisValores(double valor, double valorSubtrair, double esperado)
    {
        var resultado = OperacoesMatematicas.Diminuir(valor, valorSubtrair);

        Assert.Equal(esperado, resultado, precision: 5);
    }

    [Theory]
    [InlineData(2.0, 3.0, 5.0)]
    [InlineData(-2.0, 3.0, 1.0)]
    [InlineData(2.5, -1.5, 1.0)]
    [InlineData(0.0, 0.0, 0.0)]
    public void Somar_DeveTrabalharComValoresPositivosENegativos(double a, double b, double esperado)
    {
        var resultado = OperacoesMatematicas.Somar(a, b);

        Assert.Equal(esperado, resultado, precision: 5);
    }
}