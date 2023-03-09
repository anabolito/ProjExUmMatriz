internal class Program
{
    private static void Main(string[] args)
    {
        double[,] matrix = new double[5, 3];


        // matrix.GetLength(0 ou 1)  0 irá ler a qtdd de linhas, e 1 lerá a qtdd de colunas
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
        for( int line = 0; line< 5 ; line++)
        {
               for(int column = 0;column < 3; column++)
            {
                Console.Write($"{matrix[line, column]}\t");
            }
            Console.WriteLine();
        }


    }
    
}