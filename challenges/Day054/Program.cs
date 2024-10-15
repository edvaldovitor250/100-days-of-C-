using System;

class TSP
{
    private static int N;
    private static int[,] dist;
    private static int[,] dp;
    private const int INF = int.MaxValue;

    private static int Tsp(int mask, int pos)
    {
        if (mask == (1 << N) - 1)
        {
            return dist[pos, 0];
        }

        if (dp[mask, pos] != -1)
        {
            return dp[mask, pos];
        }

        int ans = INF;

        for (int city = 0; city < N; city++)
        {
            if ((mask & (1 << city)) != 0)
                continue;

            int newAns = dist[pos, city] + Tsp(mask | (1 << city), city);
            ans = Math.Min(ans, newAns);
        }

        return dp[mask, pos] = ans;
    }

    public static void Main(string[] args)
    {
        dist = new int[,]
        {
            { 0, 10, 15, 20 },
            { 10, 0, 35, 25 },
            { 15, 35, 0, 30 },
            { 20, 25, 30, 0 }
        };

        N = dist.GetLength(0);

        dp = new int[1 << N, N];
        for (int i = 0; i < (1 << N); i++)
        {
            for (int j = 0; j < N; j++)
            {
                dp[i, j] = -1;
            }
        }

        int result = Tsp(1, 0);

        Console.WriteLine("O menor custo do percurso é: " + result);
    }
}
