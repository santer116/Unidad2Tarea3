
internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;

        do
        {
            //Menu
            Console.WriteLine("- MENÚ PRINCIPAL -");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("1 - Rectángulo");
            Console.WriteLine("2 - Círculo");
            Console.WriteLine("3 - Triángulo");
            Console.Write("Introduzca su opción: ");
            //Almacenamos la opcion
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    //Salir del programa
                    break;
                case 1:
                    //Rectángulo
                    try
                    {
                        Console.Write("Introduzca el valor del lado 1: ");
                        float lado1 = float.Parse(Console.ReadLine());

                        Console.Write("Introduzca el valor del lado 2: ");
                        float lado2 = float.Parse(Console.ReadLine());

                        //Crear objeto Rectangulo
                        Rectangulo rectangulo = new Rectangulo(lado1, lado2);

                        //Mostrar resultados
                        Console.WriteLine($"Perímetro: {rectangulo.Perimetro()}");
                        Console.WriteLine($"Área: {rectangulo.Area()}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                case 2:
                    //Círculo
                    try
                    {
                        Console.Write("Introduzca el valor del radio: ");
                        float radio = float.Parse(Console.ReadLine());

                        //Crear objeto Circulo
                        Circulo circulo = new Circulo(radio);

                        //Mostrar resultados
                        Console.WriteLine($"Perímetro: {circulo.Perimetro()}");
                        Console.WriteLine($"Área: {circulo.Area()}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                case 3:
                    //Triángulo
                    try
                    {
                        Console.Write("Introduzca el valor de la base: ");
                        float baseTriangulo = float.Parse(Console.ReadLine());

                        Console.Write("Introduzca el valor de la altura: ");
                        float alturaTriangulo = float.Parse(Console.ReadLine());

                        //Crear objeto Triangulo
                        Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);

                        //Mostrar resultados
                        Console.WriteLine($"Perímetro: {triangulo.Perimetro()}");
                        Console.WriteLine($"Área: {triangulo.Area()}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;
                default:
                    //En caso de opcion erronea
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
            //Limpiar la consola y mostrar nuevamente el menu
            //En el caso de que se pulse salir del programa (opcion 0) tenemos que pulsar intro para realmente salir del programa
            Console.WriteLine("PULSA INTRO PARA CONTINUAR");
            Console.ReadLine();
            Console.Clear(); //(Limpiar)
        } while (opcion != 0);//Si opcion es 0 no entra nuevamente en el bucle
    }
}