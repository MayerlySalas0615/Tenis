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
        var resultado = puntaje(Jugador1, Jugador2);
        
        //Assert
        Assert.Equal(Jugador1, resultado);

    }

    private int puntaje(int jugador1, int jugador2)
    {
        throw new NotImplementedException();
    }
}