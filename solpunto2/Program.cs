internal class Program
{
    public static void Main(string[] args)
    {
        double nota1=0, nota2=0, nota3=0;
        string nombreEstudiante;
        bool continuar=true;
        double suma=0;
        double promedio=0;
        int ganadores=0;
        int perdedores=0;
    


    Console.WriteLine("------------SISTEMA DE NOTAS------------");
     

        do {

        Console.WriteLine("NOMBRE DEL ESTUDIANTE: ");
        nombreEstudiante=Console.ReadLine();
        
                Console.WriteLine("Ingresa la primera nota: ");
                nota1= double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa la segunda nota: ");
                nota2= double.Parse(Console.ReadLine());

                Console.WriteLine("Ingresa la tercera nota: ");
                nota3= double.Parse(Console.ReadLine());

                suma=nota1+nota2+nota3;
                promedio=suma/3;

                switch (promedio)
                { 
                    case double notaFinal when (notaFinal>=4.5):

                    Console.WriteLine($"El estudiante {nombreEstudiante} está en la categoria EXCELENTE, {promedio} ");
                    break;

                    case double notaFinal when (notaFinal>= 4.0 && notaFinal<4.5):

                    Console.WriteLine($"El estudiante {nombreEstudiante} está en la categoria SOBRESALIENTE, {promedio} ");
                    break;

                    case double notaFinal when (notaFinal>= 3.5 && notaFinal<4.0):

                    Console.WriteLine($"El estudiante {nombreEstudiante} está en la categoria BUENO, {promedio} ");
                    break;

                    case double notaFinal when (notaFinal<3.5):

                    Console.WriteLine($"El estudiante {nombreEstudiante} está en la categoria BUENO, {promedio} ");
                    break;

                    
                    
                }
                    if (promedio>=3.5)
                    {
                        ganadores++;
                    }
                    else
                    {
                        perdedores++;
                    }
                
                Console.WriteLine("DESEA INGRESAR MAS ESTUDIANTES? (S/N) ");
                string respuesta=Console.ReadLine().ToLower();

                if (respuesta=="n")
                {
                    continuar=false;
                    Console.WriteLine($"EN TOTAL APROBARON {ganadores} ESTUDIANTES ");
                    Console.WriteLine($"EN TOTAL REPROBARON {perdedores} ESTUDIANTES ");
                }


                } while (continuar);
         
    
    
    
    }
}