using Calculadora;

namespace Calculadora.Tests;

public class OperacionesMatematicasTest
{

    //Arrange
    private readonly OperacionesMatematicas _operaciones = new OperacionesMatematicas();

    [Fact]
    public void Sumar_DosPositivos_RetornaLaSuma()
    {
        //Arrange
        int a = 3, b = 6;

        //Act
        int resultado = _operaciones.Sumar(a, b);

        //Assert
        Assert.Equal(9, resultado);
    }


    [Fact]
    public void Sumas_NegativoMasPositivo_RetornarValorCorrecto()
    {
        //Arrange
        int a = -3, b = 6;

        //Act
        int resultado = _operaciones.Sumar(a, b);

        //Assert
        Assert.Equal(3, resultado);
    }


    [Fact]
    public void Sumar_CeroMasCero_RetornaCero()
    {
        //Arrange
        int a = 0, b = 0;

        //Act
        int resultado = _operaciones.Sumar(a, b);

        //Assert
        Assert.Equal(0, resultado);
    }

}
