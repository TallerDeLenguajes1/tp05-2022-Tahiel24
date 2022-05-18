//Ingresa un numero
Console.WriteLine("Ingrese un numero para invertir: ");
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

//Ejercicio 3: Calculadora V2

double num1,num2,num3,VA,cuadrado,raiz,sen,cos,ent,maximo,minimo;
int op;
Console.WriteLine("Ingrese un numero para operar: ");
num1=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Operacion que desea realizar?");
op=Convert.ToInt32(Console.ReadLine());

while(op!=10){
    switch(op){
        case 1:
            VA=Math.Abs(num1);
            Console.WriteLine("Resultado: "+VA);            
            break;
        case 2:
            cuadrado=Math.Pow(num1,2);
            Console.WriteLine("Resultado: "+cuadrado);  
            break;
        case 3:
            raiz=Math.Sqrt(num1);
            Console.WriteLine("Resultado: "+raiz);  
            break;
        case 4:
            sen=Math.Sin(num1);
            Console.WriteLine("Resultado: "+sen);  
            break;
        case 5:
            cos=Math.Cos(num1);
            Console.WriteLine("Resultado: "+cos);  
            break;
        case 6:
            ent=Math.Truncate(num1);
            Console.WriteLine("Resultado: "+ent);  
            break;
    }
    Console.WriteLine("Desea seguir operando?(10 para finalizar): ");
    op=Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Ingrese un numero mas: ");
num2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Un numero mas: ");
num3=Convert.ToDouble(Console.ReadLine());

maximo=Math.Max(num2, num2);
minimo=Math.Min(num2, num3);

Console.WriteLine("Maximo de los numeros ingresados: "+maximo);
Console.WriteLine("Minimo de los numeros ingresados: "+minimo);