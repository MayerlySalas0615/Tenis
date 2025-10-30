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
    [InlineData(0, 40, "Gana Jugador 2: 0 - 40")]
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

    [Theory]
    [InlineData(40 +1, 40, "Avanza Jugador 1: 40 + 1 - 40")]
    [InlineData(40, 40+ 1, "Avanza Jugador 2: 40 + 1 - 40")]
    public void AvanzaJugador_40mas1punto(int Jugador1, int Jugador2 , string Esperado)
    {
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal(Esperado, resultado);
    }
    
    [Fact(Skip = "Esta prueba se omite por refactorizacion")]
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

    [Theory]
    [InlineData(42, 40, "Gana Jugador 1: 42 - 40")] 
    [InlineData(40, 42, "Gana Jugador 2: 40 - 42")]
    public void GanaJugador_40mas2punto(int Jugador1, int Jugador2 , string Esperado)
    {
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal(Esperado, resultado);
    }
    
    
    private string puntaje(int jugador1, int jugador2)
    {
        string quiengana = jugador1 > jugador2 ? "Jugador 1" : "Jugador 2";
        
        if (jugador1 < 40  && jugador2 < 40)
        {
            return $"Puntaje: {jugador1} - {jugador2}";
        }
        
        if ((jugador1 == 40 && jugador2 < 30) || (jugador1 < 30 && jugador2 == 40))
        {
            return $"Gana {quiengana}: {jugador1} - {jugador2}";
        }

        if (jugador1 == 40 && jugador2 == 40)
        {
            return "Deuce";
        }
        
        if ((jugador1 == 41 && jugador2 == 40) || (jugador1 == 40 && jugador2 == 41) )
        {
            string quienAvanza = jugador1 > jugador2 ? "Jugador 1" : "Jugador 2";
            return $"Avanza {quienAvanza}: 40 + 1 - 40";
        }

        if ((jugador1 == 42 && jugador2 == 40) || (jugador1 == 40 && jugador2 == 42))
        {
            return $"Gana {quiengana}: {jugador1} - {jugador2}";
        }
        
        return "Puntaje No valido";
    }
}