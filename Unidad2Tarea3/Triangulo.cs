using System;

public class Triangulo : Figura
{
    //Propiedades para almacenar la base y la altura del triángulo
    private float Base { get; set; }
    private float Altura { get; set; }

    //Constructor que recibe la base y la altura del triángulo
    public Triangulo(float baseTriangulo, float alturaTriangulo)
    {
        Base = baseTriangulo;
        Altura = alturaTriangulo;
    }

    //Sobrescribir métodos virtuales para el triángulo
    public override float Perimetro()
    {
        //Suponiendo que es un triángulo cualquiera y no equilátero
        return 3 * Base;
    }

    public override float Area()
    {
        return (Base * Altura) / 2;
    }
}
