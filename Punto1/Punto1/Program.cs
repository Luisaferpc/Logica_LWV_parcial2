internal class Program
{
    public static void Main(string[] args)
    {
        int numero, jugadores;
        int N = 0;
        Random aleatorio = new Random();
        

        Console.WriteLine("CANTIDAD DE JUGADORES: ");
        jugadores = Convert.ToInt32(Console.ReadLine());
        if (jugadores > 4)
        {
            Console.Write("MAXIMO 4 JUGADORES");


        }
        else
        {
            Console.WriteLine("VAMOS A JUGAR! \n ADIVINA EL NÚMERO");
            numero = Convert.ToInt32(Console.ReadLine());

            if (jugadores > 0 && jugadores <= 2)
            {
                N = aleatorio.Next(1, 50);


                while (numero > N || numero < N)
                {
     
                    Console.WriteLine("OH OH!! SIGUE INTENTANDO");
 
                }do 
                       { if (numero == N) {
                    Console.WriteLine("HAS GANADO");
                }


            

                
            }










        }
}
