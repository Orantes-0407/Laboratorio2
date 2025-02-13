// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operaciones Básicas ");
int num1;
float num2;
float suma, resta, multiplicacion, division;
Console.WriteLine("Ingrese el primer número: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
num2 = Convert.ToSingle(Console.ReadLine());
suma = num1 + num2;
resta = num1 - num2;
multiplicacion = num1 * num2;
division = num1 / num2;
Console.WriteLine("Los resultados son los siguientes: ");
Console.WriteLine($"Suma: {num1} + {num2} = {suma}");
Console.WriteLine($"Resta: {num1} - {num2} = {resta}");
Console.WriteLine($"Multiplicación: {num1} * {num2} = {multiplicacion}");
Console.WriteLine($"División: {num1} / {num2} = {division}");

