internal class Program
{
    private static void Main(string[] args)
    {
        double[,] matrix = new double[5, 3];

        for (int line = 0; line < 5 ; line++)
        {
            for (int column = 0; column <2; column++)
            {
                Console.Write($" Matriz[{line},{column}] : ");
                matrix[line, column] = double.Parse(Console.ReadLine());
            }
        }
        for(int line = 0;line < 5 ; line++)
        {
            matrix[line, 2] = (matrix[line,0] + matrix[line,1]) / 2;
        }

        //vários for para imprimir no formato de uma matriz
        for(int column = 0;column < 3; column++)
        {
            Console.Write(matrix[0, column] + "  ");
        }
        Console.Write("\n");
        for (int column = 0; column < 3; column++)
        {
            Console.Write(matrix[1, column] + "  ");
        }
        Console.Write("\n");
        for (int column = 0; column < 3; column++)
        {
            Console.Write(matrix[2, column] + "  ");
        }
        Console.Write("\n");
        for (int column = 0; column < 3; column++)
        {
            Console.Write(matrix[3, column] + "  ");
        }
        Console.Write("\n");
        for (int column = 0; column < 3; column++)
        {
            Console.Write(matrix[4, column] + "  ");
        }


    }
    
}