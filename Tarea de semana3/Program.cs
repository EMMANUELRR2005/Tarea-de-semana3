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

//try
//{
//    Console.WriteLine("Programa para ver si el numero es par o impar");
//    Console.WriteLine("Ingrese el numero");
//    int num1 = Convert.ToInt32(Console.ReadLine());

//    if (num1 % 2 == 0 )
//    {
//        Console.WriteLine("El numero ingresado es par");

//    }
//    else
//    {
//        Console.WriteLine("El numero ingresado es impar");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Ha ingresado un valor invalido");
//}

// EJERCICIO 6
//try
//{ 
//    Console.WriteLine("Bienvenido al banco");
//    Console.WriteLine("Para acceder al prestamo llene esta informacion ");

//    Console.WriteLine("Coloque su edad");
//    int edad = int.Parse(Console.ReadLine());

//    Console.WriteLine("Ahora ingrese el monto del prestamo");
//    float monto = Convert.ToInt32(Console.ReadLine());

//    if (monto < 5000 || edad > 60)
//    {
//        Console.WriteLine("Felicidades se ha aprobado su prestamo");

//    }
//    else
//    {
//        Console.WriteLine("su prestamo ha sido rechazado");
//    }

//}
//catch (Exception ex)
//{
//    Console.WriteLine("Ha ingresado valores equivocados");
//}
//EJERCICIO 7
//try
//{
//    Console.WriteLine("Seleccione el numero de la figura que desea calcular: \n1.Triángulo. \n2.Cuadrado. \n3.Circulo. ");
//    int op7 = int.Parse(Console.ReadLine());

//    switch (op7)
//    {
//        case 1:
//            Console.WriteLine("Ingrese la base del triangulo: ");
//            double bt = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Ingrese la altura del triangulo: ");
//            double at = Convert.ToDouble(Console.ReadLine());

//            double art = (bt * at) / 2;
//            Console.WriteLine("El area del triangulo es de: " + art);
//            break;
//        case 2:
//            Console.WriteLine("Ingrese el largo de los lados del cuadrado: ");
//            double cl = Convert.ToDouble(Console.ReadLine());

//            double arc = cl * cl;
//            Console.WriteLine("El area del cuadrado es de: " + arc);
//            break;
//        case 3:
//            Console.WriteLine("Ingrese el radio del circulo: ");
//            double rc = Convert.ToDouble(Console.ReadLine());

//            double ac = Math.PI * Math.Pow(rc, 2);
//            Console.WriteLine("El area del circulo es de: " + rc);
//            break;
//    }
//}
//catch (Exception ex)
//{ 
//    Console.WriteLine("Ha ingresado un valor invalido, vuelva a intentar "); 
//}
//EJERCICIOS USANDO SWITCH 
//EJERCICIO 1
Console.WriteLine("Ingrese un numero del 1 al 5 en letras");
string num = Console.ReadLine();
int num1;

switch (num)
{
    case "uno":
        num1 = 1;
        Console.WriteLine(num1);
        break;
    case "dos":
        num1 = 2;
        Console.WriteLine(num1);
        break;
    case "tres":
        num1 = 3;
        Console.WriteLine(num1);
        break;
    case "cuatro":
        num1 = 4;
        Console.WriteLine(num1);
        break;
    case "cinco":
        num1 = 5;
        Console.WriteLine(num1);
        break;
    default:
        Console.WriteLine("Ha escrito un numero que no se le indico ");
        break;
}

