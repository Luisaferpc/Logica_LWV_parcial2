internal class Program
{
    public static void Main(string[] args)
    {
        int numero, jugadores;
        int N = 0;
        Random aleatorio = new Random();
        bool centinela = true;

       

        Console.WriteLine("CANTIDAD DE JUGADORES: ");
        jugadores = Convert.ToInt32(Console.ReadLine());
        if (jugadores > 4)
        {
            Console.Write("MAXIMO 4 JUGADORES"); }
        else {
            Console.WriteLine("VAMOS A JUGAR! \n ADIVINA EL NÚMERO");
            numero = Convert.ToInt32(Console.ReadLine());

            if (jugadores > 0 && jugadores <= 2)
            {
                N = aleatorio.Next(1, 50);
                if (numero > N || numero < N)
                {


                    while (!centinela)
                    {
                        Console.WriteLine("SIGUE INTENTANDO");


                        break;
                    }
                }
                else  {
                    centinela = true;

                    Console.WriteLine("HAS GANADO!"); }















                }

            }


    }
}
