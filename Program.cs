Console.WriteLine("Ingrese un numero positivo a invertir");
int num = int.Parse(Console.ReadLine());
if (num > 0)
{
    num = num - (num * 2);
    Console.WriteLine("El numero invertido es: " + num);
}
else
{
    Console.WriteLine("El numero ingresado no es mayor a 0");
}