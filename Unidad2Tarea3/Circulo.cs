using System;

public class Circulo : Figura
{
    //Propiedad para almacenar el radio del círculo
    private float Radio { get; set; }

    //Constructor que recibe el radio del círculo
    public Circulo(float radio)
    {
        Radio = radio;
    }

    //Sobrescribir métodos virtuales para el círculo
    public override float Perimetro()
    {
        return 2 * (float)Math.PI * Radio;
    }

    public override float Area()
    {
        return (float)Math.PI * Radio * Radio;
    }
}
