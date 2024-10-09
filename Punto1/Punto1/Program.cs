using System.Collections;
using System.Diagnostics;

internal class Program
{
    public static void Main(string[] args)
    {
        int numero, jugadores;
        int N = 0;
        Random aleatorio = new Random();
        bool continuar = true;

       

        Console.WriteLine("CANTIDAD DE JUGADORES: ");
        jugadores = Convert.ToInt32(Console.ReadLine());
        if (jugadores >1 && jugadores<= 4)
        { 
             do {
                switch (jugadores)
                {
                    case 2: 
            
                    Console.WriteLine ("INGRESA UN NUMERO: ");
                    numero=Int32.Parse(Console.ReadLine());
                    N=aleatorio.Next(0,50);
                    if(numero>N){Console.WriteLine ("MENOR");
                    } else if (numero<N) {Console.WriteLine ("MAYOR");
                        } else if (numero==N) {Console.WriteLine ("HAS GANADO!");   continuar=false; }  

                    break;

                    case 3:
                    Console.WriteLine ("INGRESA UN NUMERO: ");
                    numero=Int32.Parse(Console.ReadLine());
                    N=aleatorio.Next(0,100);
                     if(numero>N){Console.WriteLine ("MENOR");
                    } else if (numero<N) {Console.WriteLine ("MAYOR");
                        } else if (numero==N) {Console.WriteLine ("HAS GANADO!");   continuar=false; }  

                    break;
                    case 4:
                    Console.WriteLine ("INGRESA UN NUMERO: ");
                    numero=Int32.Parse(Console.ReadLine());
                    N=aleatorio.Next(0,200);
                   if(numero>N){Console.WriteLine ("MENOR");
                    } else if (numero<N) {Console.WriteLine ("MAYOR");
                        } else if (numero==N) {Console.WriteLine ("HAS GANADO!");   continuar=false; }  

                    break;
       

                }





            }
            while(continuar);
        
        
        }else Console.WriteLine("DEBE SER MINIMO 2 Y  MAXIMO 4 JUGADORES");
           


    }
}
