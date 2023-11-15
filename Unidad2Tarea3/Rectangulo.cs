using System;

public class Rectangulo : Figura
{
	
    //Propiedades para almacenar lados del rectángulo
    private float Lado1 { get; set; }
    private float Lado2 { get; set; }

    //Constructor que recibe los lados del rectángulo
    public Rectangulo(float lado1, float lado2)
    {
        Lado1 = lado1;
        Lado2 = lado2;
    }

    //Sobrescribir métodos virtuales para el rectángulo
    public override float Perimetro()
    {
        return 2 * (Lado1 + Lado2);
    }

    public override float Area()
    {
        return Lado1 * Lado2;
    }
}

