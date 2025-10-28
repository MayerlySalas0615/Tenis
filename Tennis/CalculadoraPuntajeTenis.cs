namespace Tennis;

public class CalculadoraPuntajeTenis
{
    [Fact]
    public void Jugador1_1P_Jugador2_0P()
    {
        //Arrange
        int Jugador1 = 15;
        int Jugador2 = 0;
        
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal("Puntaje: 15 - 0", resultado);

    }
    
    [Fact]
    public void Jugador1_2P_Jugador2_0P()
    {
        //Arrange
        int Jugador1 = 30;
        int Jugador2 = 0;
        
        //Act
        string resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal("Puntaje: 30 - 0", resultado);

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

    private string puntaje(int jugador1, int jugador2)
    {
        if ((jugador1 == 15 || jugador1 == 30 ) && jugador2 == 0)
        {
            return $"Puntaje: {jugador1} - {jugador2}";
        }

        if (jugador1 == 40 && jugador2 == 0)
        {
            return "Gana:" {jugador1};
        }
        
        return string.Empty;
    }
}