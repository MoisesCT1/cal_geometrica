using Calc_Geometrica;

int opcion;

Console.WriteLine("Calculadora Geométrica, seleccione una opción: ");
Console.WriteLine("1. Circulos");
Console.WriteLine("2. Cuadrados/Rectangulos");
Console.WriteLine("3. Triángulos");
Console.WriteLine("4. Elipses");

opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion) {
    case 1:
        Console.WriteLine("Por favor ingrese el radio del circulo");
        double radio = Convert.ToDouble(Console.ReadLine());
        Circulos circulo1= new Circulos(radio);
        Console.WriteLine("El área del circulo es: "+circulo1.CalcularArea());
        break;

    case 2:
        Console.WriteLine("Por favor ingrese la base del cuadrado: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la altura: ");
        double h = Convert.ToDouble(Console.ReadLine());
        Cuadrado cuadrado1 = new Cuadrado(b,h);
        Console.WriteLine("El área del cuadrado es: " + cuadrado1.CalcularArea());

        break;

    case 3:
        Console.WriteLine("Por favor ingrese lado A del treangulo: ");
        double ladoA = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese lado B : ");
        double ladoB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese lado C: ");
        double ladoC = Convert.ToDouble(Console.ReadLine());
        Triangulo triangulo1 = new Triangulo(ladoA,ladoB,ladoC);
        Console.WriteLine("El área del triangulo es: " + triangulo1.CalcularArea());

        break;

    case 4:
        Console.WriteLine("Por favor ingrese el semieje mayor de la elipse: ");
        double semiEjeMayor = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el semieje menor de la elipse: ");
        double semiEjeMenor = Convert.ToDouble(Console.ReadLine());

        Elipse elipse1 = new Elipse(semiEjeMayor, semiEjeMenor);
        Console.WriteLine("El área de la elipse es: " + elipse1.CalcularArea());
        Console.WriteLine("El perímetro aproximado de la elipse es: " + elipse1.CalcularPerimetro());


        break;


}


