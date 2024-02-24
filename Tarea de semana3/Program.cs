try
{
    Console.WriteLine("Ingrese primer numero");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese segundo numero");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese tercer numero");
    int num3 = int.Parse(Console.ReadLine());

    if (num1 > num2 && num1 >num3)
    {
    Console.WriteLine("El numero mayor es: " + num1);
    }
    if (num2 >num1 && num2 > num3)
    {
    Console.WriteLine("El numero mayor es: " + num2);
    }
    else
    {
    Console.WriteLine("El numero mayor es: " + num3);
    }
}
catch (Exception ex)
{
    Console.WriteLine("No ingresaste un valor numerico");
}