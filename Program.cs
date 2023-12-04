Console.WriteLine("Reto 3: Numeros Amistosos");
int Eleccion = 0;
int m = 0;
int n = 0;
int l = 0;
int e = 0;
int pasado = 0;
int limite = 2000;
bool Bander = false;
while (Eleccion != 2)
{
    try
    {
        Console.WriteLine("");
        Console.WriteLine("Menu");
        Console.WriteLine("");
        Console.WriteLine("1. Buscar Numeros Amistosos Pares");
        Console.WriteLine("2. Salir");
        Console.WriteLine("");
        Console.Write("Ingrese opcion que desea revisar: ");
        Eleccion = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (Eleccion)
        {   
            case 1:
                Console.WriteLine("Buscar Numeros Amistosos Pares");
                Console.WriteLine("");
                for (int i = 0; i < limite; i++)
                {
                    m = i;
                    n = 0;
                    l = 0;
                    e = 0;
                    for (int j = 1; j < m; j++)
                    {
                        if (m % j == 0)
                        {
                            n += j;
                        }
                    }
                    for (int k = 1; k < n; k++)
                    {
                        if (n % k == 0)
                        {
                            l += k;
                        }
                    }
                    if ((l == m && m != n) && (m !=pasado))
                    {
                        Bander = true;
                        pasado = n;
                        Console.WriteLine("Numeros Amistosos: (" + m + " , " + n + ")");
                        e++;
                    }
                }
                if (Bander == false)
                {
                    Console.WriteLine("No se encontraron numeros amistosos");
                }      
                Console.WriteLine("");
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
            case 2:
                Console.WriteLine("Lo esperamos pronto");
                Console.Write("Presione enter para continuar");
                Console.ReadLine();
                Console.Clear();
                break;
            default:
                break;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Valor incorrecto, ingrese un valor valido");
        Console.Write("Presione enter para continuar");
        Console.ReadLine();
        Console.Clear();
    }
}