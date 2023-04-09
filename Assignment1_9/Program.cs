static int BinomalCoe(int n, int k)
{
    if (k == 0 || k == n)
    {
            return 1;
    }
    else
    {
            return BinomalCoe(n - 1, k - 1) + BinomalCoe(n - 1, k);
    }
}

int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());

int result = BinomalCoe(n, k);

Console.WriteLine(BinomalCoe(n,k));