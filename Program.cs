//Ingresa un numero
Console.WriteLine("Ingrese un numero para ser invertido: ");
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

//Ejercicio 2: CalculadoraV1
double num1,num2,suma,resta,producto,cociente;
Console.WriteLine("Ingrese un numero para operar: ");
num1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese un numero mas: ");
num2=Convert.ToDouble(Console.ReadLine());
int op;
Console.WriteLine("Ingrese la operacion a realizar(1:Suma,2:Resta,3:Producto,4:Cociente): ");
op=Convert.ToInt32(Console.ReadLine());
while(op!=10){
    switch (op)
    {
        case 1:
            suma=sumaO(num1,num2);
            Console.WriteLine($"Resultado={suma}");
            break;
        case 2:
            resta=restaO(num1,num2);
            Console.WriteLine("Resultado: "+resta);
            break;
        case 3:
            producto=productoO(num1,num2);
            Console.WriteLine("Resultado: "+producto);
            break;
        case 4:
            cociente=cocienteO(num1,num2);
            Console.WriteLine("Resultado: "+cociente);
            break;
    }
    Console.WriteLine("Desea seguir operando?(Inserte 10 para concluir): ");
    op=Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("-------------------Programa finalizado----------------");


//Funciones
double sumaO(double num1, double num2){
    return num1+num2;
}

double restaO(double num1, double num2){
    return num1-num2;
}

double productoO(double num1, double num2){
    return num1*num2;
}

double cocienteO(double num1, double num2){
    return num1/num2;
}