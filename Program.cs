//Ingresa un numero
Console.WriteLine("Ingrese un numero: ");
string original = Console.ReadLine();

//Convierte el texto en un dato tipo char[]
char[] numArray = original.ToCharArray();

string reverse = String.Empty;
//Da vuelta la cadena
for (int i = numArray.Length - 1; i >= 0; i--)
{
    reverse += numArray[i];
}
//Muestra
Console.WriteLine("Numero original: " + original);
Console.WriteLine("Numero invertido: " + reverse);