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
//try
//{

//    Console.WriteLine("Bienvenido a descuentos");
//    Console.WriteLine("Agregue el precio del producto");
//    double precio = double.Parse(Console.ReadLine());

//    if (precio > 100)
//    {
//        Console.WriteLine("Si aplica al descuento");
//        double descuen = precio / 10;
//        double liquido = precio - descuen;

//        Console.WriteLine("Se aplico un descuento del 10% ");
//        Console.WriteLine("Su total a pagar es de: " + liquido);
//    }
//    else
//    {
//        Console.WriteLine("No aplicas para el descuento");

//    }

//}
//catch (Exception ex)
//{
//    Console.WriteLine("No ingresaste un valor valido (SOLO NUMEROS)");
//}

//EJERCICIO 4
//try
//{
//    string[] user = { "Emmanuel", "Jose", "Rodriguez" };
//    string[] pass = { "2005", "2006", "2004" };

//    Console.Write("Ingrese su usuario: ");
//    string userI = Console.ReadLine();

//    Console.Write("Ingrese la contraseña: ");
//    string passI = Console.ReadLine();

//    if (ValidarCredenciales(userI, passI, user, pass))
//        Console.WriteLine("Usario y Contraseñas correctas. Acceso Concedido.");

//    else
//        Console.WriteLine("Usuario o Contraseñas incorrectas. Acceso Denegado.");

//    static bool ValidarCredenciales(string userI, string passI, string[] user, string[] pass)
//    {
//        for (int i = 0; i < user.Length; i++)
//        {
//            if (user[i] == userI && pass[i] == passI)
//            {
//                return true;
//            }
//        }
//        return false;
//    }
//}
//catch (Exception ex)
//{ Console.WriteLine("Parece que ha ingresado caracteres invalidos en su usuario o contraseña."); }

//EJERCICIO 5

try
{
    Console.WriteLine("Programa para ver si el numero es par o impar");
    Console.WriteLine("Ingrese el numero");
    int num1 = Convert.ToInt32(Console.ReadLine());

    if (num1 % 2 == 0 )
    {
        Console.WriteLine("El numero ingresado es par");

    }
    else
    {
        Console.WriteLine("El numero ingresado es impar");
    }
}
catch (Exception ex)
{
    Console.WriteLine("Ha ingresado un valor invalido");
}

