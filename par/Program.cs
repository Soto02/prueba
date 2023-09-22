namespace par
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa llamado par.cs que muestre por pantalla los números
            //pares divisibles por 3 del 1 al 50.

            int num = 50;
            
            for(int i = 1; i <= num; i++)
            {
                if(i % 2 == 0)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}