namespace Tennis;

public class CalculadoraPuntajeTenis
{
    [Theory]
    [InlineData(15, 0, "Puntaje: 15 - 0")]
    [InlineData(30, 0, "Puntaje: 30 - 0")]
    [InlineData(15, 15, "Puntaje: 15 - 15")]
    public void Jugador1_Pto_Jugador2_Pto_Normal(int Jugador1, int Jugador2 , string Esperado)
    {
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal(Esperado, resultado);
    }
    
    [Theory]
    [InlineData(40, 0, "Gana Jugador 1: 40 - 0")]
    [InlineData(40, 15, "Gana Jugador 1: 40 - 15")]
    public void Jugador1_Gana(int Jugador1, int Jugador2 , string Esperado)
    {
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal(Esperado, resultado);
    }

    [Fact]
    public void Puntaje_Deuce()
    {
        //Arrange
        int Jugador1 = 40;
        int Jugador2 = 40;
        
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal("Deuce", resultado);
    }

    [Fact]
    public void AvanzaJugador1_40mas1Punto_vs_Jugador2_40()
    {
        //Arrange
        int Jugador1 = 40 + 1;
        int Jugador2 = 40;
        
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal("Avanza Jugador 1: 40 + 1  - 40", resultado);
    }
    
    [Fact]
    public void AvanzaJugador2_40mas1Punto_vs_Jugador1_40()
    {
        //Arrange
        int Jugador1 = 40;
        int Jugador2 = 40 + 1;
        
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal("Avanza Jugador 2: 40 + 1  - 40", resultado);
    }
    
    private string puntaje(int jugador1, int jugador2)
    {
        if (jugador1 < 40  && jugador2 < 40)
        {
            return $"Puntaje: {jugador1} - {jugador2}";
        }
        if (jugador1 == 40 && jugador2 < 40)
        {
            return $"Gana Jugador 1: {jugador1} - {jugador2}";
        }

        if (jugador1 == 40 && jugador2 == 40)
        {
            return "Deuce";
        }
        
        if (jugador1 == 41 && jugador2 == 40)
        {
            return "Avanza Jugador 1: 40 + 1  - 40";
        }
        
        if (jugador1 == 40 && jugador2 == 41)
        {
            return "Avanza Jugador 2: 40 + 1  - 40";
        }
        
        return "Puntaje No valido";
    }
}