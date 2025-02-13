// See https://aka.ms/new-console-template for more information
int num1;
double numDec;
string texto;
bool esVerdadero;
Console.WriteLine("Por favor, ingrese un numero"); 
num1= int.Parse(Console.ReadLine());
Console.WriteLine("Por favor, ingrese un numero decimal");
numDec = double.Parse(Console.ReadLine());  
Console.ReadLine();
Console.WriteLine("Por favor ingrese su Nombre");
texto = Console.ReadLine(); 
Console.ReadLine(); 
Console.WriteLine("Por favor ingrese un valor verdadero o falso");
esVerdadero = bool.Parse(Console.ReadLine());

Console.WriteLine("\nValores ingresados por el usuario:");
Console.WriteLine($"Numero entero: {num1}");
Console.WriteLine($"Numero decimal: {numDec}");
Console.WriteLine($"Texto: {texto}");
Console.WriteLine($"Valor verdadero o falso: {esVerdadero}");


