internal class Program
{
    public static void Main(string[] args)
    {
        int numero, jugadores;
        int N = 0;
        Random aleatorio = new Random();

        Console.WriteLine("CANTIDAD DE JUGADORES: ");
        jugadores = Convert.ToInt32(Console.ReadLine());

        if (jugadores > 0 || jugadores <= 2) {
            Console.WriteLine("VAMOS A JUGAR! \n ADIVINA EL NÚMERO");
            numero = Convert.ToInt32(Console.ReadLine());
            N = aleatorio.Next(1, 50);
        }
       

        

  


  


    }
}