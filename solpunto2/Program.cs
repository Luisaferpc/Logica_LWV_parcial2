internal class Program
{
    public static void Main(string[] args)
    {
        double nota1=0, nota2=0, nota3=0;
        string nombreEstudiante;
        bool continuar=true;
        double suma=0;
        double promedio=0;
        
    


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

        Console.WriteLine($"El promedio del estudiante {nombreEstudiante} es {promedio} ");



        } while (continuar);

    
    
    
    }
}