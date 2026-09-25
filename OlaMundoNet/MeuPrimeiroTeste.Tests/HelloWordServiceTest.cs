using MeuPrimeiroTeste.App;

namespace MeuPrimeiroTeste.Tests;

public class HelloWordServiceTest
{
    [Fact]
public void GerarSaudacao_DeveRetornarSaudacaoPadrao_QuandoNomeForNuloOuVazio()
{
// Arrange (Preparação)
var service = new HelloWordService();
// Act (Ação)
var resultado = service.GerarSaudacao(null);
// Assert (Verificação)
Assert.Equal("Olá, Mundo!", resultado);
}
}
