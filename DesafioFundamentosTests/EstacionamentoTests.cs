using DesafioFundamentos.Models;

namespace DesafioFundamentosTests;

public class EstacionamentoTests
{

    private Estacionamento _estacionamento;

    public EstacionamentoTests()
    {
        _estacionamento = new Estacionamento(5, 10);
    }

    [Theory]
    [InlineData("1234567")]
    [InlineData("ABC1234")]
    [InlineData("ABC1235")]
    [InlineData("ABD1235")]
    [InlineData("ABE1235")]

    public void DeveAdicionarAPlacaCom7Caracteres(string placa)
    {

        // act
        bool resultadoTest = _estacionamento.VerificarCaracteres(placa);

        // assert
        Assert.True(resultadoTest);
    }

    [Fact]
    public void NaoDeveAdicionarAPlacaComMenosDe7Caracteres()
    {
        // arrange
        string placa = "123456";


        // act
        bool resultadoTest = _estacionamento.VerificarCaracteres(placa);

        // assert
        Assert.False(resultadoTest);
    }

    [Fact]
    public void DeveSalvarUmaPlaca()
    {
        // arrange
        string placa = "1234567";

        // act
        _estacionamento.AdicionarVeiculo(placa);
        var salvoNaLista = _estacionamento.pegarListaVeiculo()[0];  

        // assert
        Assert.Equal(placa, salvoNaLista);

    }

    [Fact]
    public void DeveRemoverUmaPlaca()
    {
        // arrange
        string placa = "1234567";
        decimal horasEstacionadas = 2;

        // act
        _estacionamento.AdicionarVeiculo(placa);
        _estacionamento.RemoverVeiculo(placa, horasEstacionadas);
        var quantidadeItensLista = _estacionamento.pegarListaVeiculo().Count;  

        // assert
        Assert.Equal(0, quantidadeItensLista);

    }

}