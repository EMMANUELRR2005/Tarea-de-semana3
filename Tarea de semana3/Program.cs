// EJERCICIO 1
//try
//{
//    Console.WriteLine("Ingrese primer numero");
//    int num1 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Ingrese segundo numero");
//    int num2 = int.Parse(Console.ReadLine());

//    Console.WriteLine("Ingrese tercer numero");
//    int num3 = int.Parse(Console.ReadLine());

//    if (num1 > num2 && num1 >num3)
//    {
//    Console.WriteLine("El numero mayor es: " + num1);
//    }
//    if (num2 >num1 && num2 > num3)
//    {
//    Console.WriteLine("El numero mayor es: " + num2);
//    }
//    else
//    {
//    Console.WriteLine("El numero mayor es: " + num3);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine("No ingresaste un valor numerico");
//    Console.WriteLine("Vuelve a intentar");
//}

//EJERCICIO 2
//try
//{
//    Console.WriteLine("Bienvenido al club");
//    Console.WriteLine("Coloque su edad para continuar");
//    int edad = int.Parse(Console.ReadLine());

//    if (edad >= 18)
//    {
//        Console.WriteLine("Bienvenido eres mayor de edad y puedes entrar");
//    }
//    else
//    {
//        Console.WriteLine("Lo siento, eres menor de edad así que no puedes entrar");
//    }
//}
//catch (Exception ex)
//    {
//    Console.WriteLine("No ingresaste un valor valido (SOLO NUMEROS)");
//    }

//EJERCICIO 3
try
{

    Console.WriteLine("Bienvenido a descuentos");
    Console.WriteLine("Agregue el precio del producto");
    double precio = double.Parse(Console.ReadLine());

    if (precio > 100)
    {
        Console.WriteLine("Si aplica al descuento");
        double descuen = precio / 10;
        double liquido = precio - descuen;

        Console.WriteLine("Se aplico un descuento del 10% ");
        Console.WriteLine("Su total a pagar es de: " + liquido);
    }
    else
    {
        Console.WriteLine("No aplicas para el descuento");

    }

}
catch (Exception ex)
{
    Console.WriteLine("No ingresaste un valor valido (SOLO NUMEROS)");
}
