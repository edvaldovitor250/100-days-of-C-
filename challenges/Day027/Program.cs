        int[] dados = { 1, 32, 4, 1, 98, 47, 65, 23, 9 };
        int ordem = 3; 

        double[][] matriz = MatrixCreate(ordem, ordem);
        int k = 0;
        for (int i = 0; i < ordem; i++)
        {
            for (int j = 0; j < ordem; j++)
            {
                matriz[i][j] = dados[k++];
            }
        }

        Console.WriteLine("Matriz:");
        PrintMatrix(matriz);

        double det = Determinant(matriz);
        Console.WriteLine($"\nDeterminante: {det}");
    

    static double[][] MatrixCreate(int rows, int cols)
    {
        double[][] result = new double[rows][];
        for (int i = 0; i < rows; ++i)
            result[i] = new double[cols];
        return result;
    }

    static double Determinant(double[][] matrix)
    {
        int n = matrix.Length;

        if (n == 1)
        {
            return matrix[0][0];
        }
        if (n == 2)
        {
            return matrix[0][0] * matrix[1][1] - matrix[0][1] * matrix[1][0];
        }

        double det = 0;
        for (int i = 0; i < n; i++)
        {
            double[][] subMatrix = CreateSubMatrix(matrix, 0, i);
            det += Math.Pow(-1, i) * matrix[0][i] * Determinant(subMatrix);
        }
        return det;
    }

    static double[][] CreateSubMatrix(double[][] matrix, int excludeRow, int excludeCol)
    {
        int n = matrix.Length;
        double[][] subMatrix = MatrixCreate(n - 1, n - 1);

        int r = -1;
        for (int i = 0; i < n; i++)
        {
            if (i == excludeRow)
                continue;

            r++;
            int c = -1;
            for (int j = 0; j < n; j++)
            {
                if (j == excludeCol)
                    continue;

                subMatrix[r][++c] = matrix[i][j];
            }
        }

        return subMatrix;
    }

    static void PrintMatrix(double[][] matrix)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                Console.Write(matrix[i][j] + "\t");
            }
            Console.WriteLine();
        }
    }