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


//Ejercicio 3: Calculadora V2

double num3,num4,num5,VA,cuadrado,raiz,sen,cos,ent,maximo,minimo;
int op2;
Console.WriteLine("Ingrese un numero para operar: ");
num3=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Operacion que desea realizar?");
op2=Convert.ToInt32(Console.ReadLine());

while(op2!=10){
    switch(op){
        case 1:
            VA=Math.Abs(num3);
            Console.WriteLine("Resultado: "+VA);            
            break;
        case 2:
            cuadrado=Math.Pow(num3,2);
            Console.WriteLine("Resultado: "+cuadrado);  
            break;
        case 3:
            raiz=Math.Sqrt(num3);
            Console.WriteLine("Resultado: "+raiz);  
            break;
        case 4:
            sen=Math.Sin(num3);
            Console.WriteLine("Resultado: "+sen);  
            break;
        case 5:
            cos=Math.Cos(num3);
            Console.WriteLine("Resultado: "+cos);  
            break;
        case 6:
            ent=Math.Truncate(num3);
            Console.WriteLine("Resultado: "+ent);  
            break;
    }
    Console.WriteLine("Desea seguir operando?(10 para finalizar): ");
    op2=Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Ingrese un numero mas: ");
num4=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Un numero mas: ");
num5=Convert.ToDouble(Console.ReadLine());

maximo=Math.Max(num4, num4);
minimo=Math.Min(num4, num3);

Console.WriteLine("Maximo de los numeros ingresados: "+maximo);
Console.WriteLine("Minimo de los numeros ingresados: "+minimo);
