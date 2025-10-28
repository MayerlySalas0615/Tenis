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

    private string puntaje(int jugador1, int jugador2)
    {
        if (jugador1 == 15 && jugador2 == 0)
        {
            return "Puntaje: " + jugador1.ToString() + " - " + jugador2.ToString();
        }
        return string.Empty;
    }
}