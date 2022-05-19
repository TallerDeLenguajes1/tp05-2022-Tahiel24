//Ejercicio 1
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
Console.WriteLine("\nNumero original: " + original);
Console.WriteLine("Numero invertido: " + reverse);

//Ejercicio 4
Console.WriteLine("\nIngrese una cadena de texto: ");
string texto=Console.ReadLine();
Console.WriteLine("Ingrese una cadena mas: ");
string texto2=Console.ReadLine();

//Obtener algunas letras que forman parte de la cadena
Console.WriteLine("\nPrimera letra de la cadena ingresada: "+texto[0]);

//Obtener la longitud de la cadena y muestre por pantalla
Console.WriteLine("\nLongitud de la primera cadena ingresada: "+texto.Length);

//Concatenar (Unir) dos cadenas distintas
Console.WriteLine("\nCadenas concatenadas: "+texto+' '+texto2);

//Extraer una subcadena
string[]separado=texto.Split();
Console.WriteLine("\nSubcadena: "+separado[0]);

//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
Console.WriteLine("\nPrimera cadena con foreach: ");
foreach (char elemento in texto)
{
    Console.WriteLine($"{elemento}");
}

//Buscar la ocurrencia de una palabra determinada en la cadena ingresada
Console.WriteLine("\nIngrese la palabra para encontrar ocurrencias: ");
string ayuda=Console.ReadLine();
bool b= texto.Contains(ayuda);
if(b){
    Console.WriteLine("Coincidencia encontrada exitosamente.");
}else{
    Console.WriteLine("No hay coincidencias con la cadena ingresada.");
}

//Convierta la cadena a mayusculas y luego a minusculas
Console.WriteLine("\nMayusculas: "+texto.ToUpper());
Console.WriteLine("\nMinusculas: "+texto.ToLower());

//Ingresar una cadena separada por ciertos caracteres y mostrar por pantalla los resultados
Console.WriteLine("\nIngresar una nueva cadena: ");
string palabraN=Console.ReadLine();
string[] separada=palabraN.Split(); //Split separa una cadena en un arreglo
Console.WriteLine("Cadena separada: ");
foreach (string item in separada)
{
    Console.WriteLine($"{item}");
}

//Operaciones ingresando una cadena de caracteres
double suma,resta,producto,cociente;
Console.WriteLine("\nEscriba una operacion(+,-,*,/),(Ejemplo: 8+5): ");
string operacion=Console.ReadLine();
string[]sep=operacion.Split('+', '-', '*', '/');
double aux1=Convert.ToDouble(sep[0]);
double aux2=Convert.ToDouble(sep[1]);
switch(operacion[1]){
    case '+':
        suma=aux1+aux2;
        Console.WriteLine($"La suma de {aux1} y {aux2} es {suma}");
        break;
    case '-':
        resta=aux1-aux2;
        Console.WriteLine($"La resta de {aux1} y {aux2} es {resta}");
        break;
    case '*':
        producto=aux1*aux2;
        Console.WriteLine($"El producto de {aux1} y {aux2} es {producto}");
        break;
    case '/':
        cociente=aux1/aux2;
        Console.WriteLine($"El cociente de {aux1} y {aux2} es {cociente}");
        break;
}
