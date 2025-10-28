namespace Tennis;

public class CalculadoraPuntajeTenis
{
    [Theory]
    [InlineData(15, 0, "Puntaje: 15 - 0")]
    [InlineData(30, 0, "Puntaje: 30 - 0")]
    [InlineData(15, 15, "Puntaje: 15 - 15")]
    public void Jugador1_Pto_Jugador2_Pto(int Jugador1, int Jugador2 , string Esperado)
    {
        // //Arrange
        // int Jugador1 = 15;
        // int Jugador2 = 0;
        
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal(Esperado, resultado);

    }
    
    [Fact]
    public void Jugador1_3P_Jugador2_0P()
    {
        //Arrange
        int Jugador1 = 40;
        int Jugador2 = 0;
        
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal("Gana Jugador 1: 40 - 0", resultado);

    }
    
    [Fact]
    public void Jugador1_3P_Jugador2_1P()
    {
        //Arrange
        int Jugador1 = 40;
        int Jugador2 = 15;
        
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal("Gana Jugador 1: 40 - 15", resultado);

    }
    
    private string puntaje(int jugador1, int jugador2)
    {
        if (jugador1 < 40  && jugador2 < 40)
        {
            return $"Puntaje: {jugador1} - {jugador2}";
        }
        if (jugador1 == 40 && jugador2 == 0)
        {
            return $"Gana Jugador 1: {jugador1} - {jugador2}";
        }
        
        return "Puntaje No valido";
    }
}