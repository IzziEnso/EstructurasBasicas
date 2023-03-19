namespace Ejer4._4._4
{
    class Program
    {
        static void Main(String[]Args)
        {
            Console.WriteLine("NÚMERO DE ALUMNOS");
            double n = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            while (i < n)
            {

                Console.WriteLine("NOMBRE");
                String nombre = (Console.ReadLine());
                double promedio;

                Console.WriteLine("NOTA 1: ");
                double nota1 = int.Parse(Console.ReadLine());
                Console.WriteLine("NOTA 2: ");
                double nota2 = int.Parse(Console.ReadLine());
                Console.WriteLine("PROMEDIO: ");
                promedio = (nota1 + nota2) / 2;
                Console.WriteLine(promedio);

                i++;
            }
        }
    }
}

