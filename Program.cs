using System;

class Program
{
    static void Main(string[] args)
    {
        Matrix();

    }
    static void Matrix()
    {
        {
            string choice;

            do
            {
                Console.WriteLine("Choose operation:");

                choice = Console.ReadLine();

                if (choice == "+" || choice == "-")
                {
                    Console.Write("Enter the number of rows for the matrices: ");
                    int rows = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter the number of columns for the matrices: ");
                    int columns = Convert.ToInt32(Console.ReadLine());
                    float[,] matrix1 = CreateMatrix(rows, columns);
                    float[,] matrix2 = CreateMatrix(rows, columns);

                    if (choice == "+")
                    {
                        float[,] sumMatrix = AddMatrices(matrix1, matrix2);
                        Console.WriteLine("Sum of matrices:");
                        PrintMatrix(sumMatrix);
                    }
                    else if (choice == "-")
                    {
                        float[,] diffMatrix = SubtractMatrices(matrix1, matrix2);
                        Console.WriteLine("Difference of matrices:");
                        PrintMatrix(diffMatrix);
                    }
                }
                else
                {
                    Console.WriteLine("Exiting program.");
                }

            } while (choice == "+" || choice == "-");
        }
        static float[,] CreateMatrix(int rows, int columns)
        {
            float[,] matrix = new float[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Enter the value for element [{i}, {j}]: ");
                    matrix[i, j] = Convert.ToSingle(Console.ReadLine());
                }
            }

            return matrix;
        }

        static float[,] AddMatrices(float[,] matrix1, float[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            float[,] result = new float[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        static float[,] SubtractMatrices(float[,] matrix1, float[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            float[,] result = new float[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        static void PrintMatrix(float[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("{0:N1} \t", matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}






