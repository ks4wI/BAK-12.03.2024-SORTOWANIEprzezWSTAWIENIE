class Program
{
    static void Main(string[] args)
    {
        Random rdm = new Random();
        int[] liczby = new int[100];
        for (int i = 0; i < liczby.Length; i++)
        {
            liczby[i] = rdm.Next(1, 1000);
        }

        Console.WriteLine("Tablica przed sortowaniem:");
        foreach (int liczba in liczby)
        {
            Console.Write(liczba + " ");
        }
        Console.WriteLine();

        InsertionSort(liczby);

        Console.WriteLine("Tablica po sortowaniu:");
        foreach (int liczba in liczby)
        {
            Console.Write(liczba + " ");
        }
        Console.WriteLine();

        int[] posortowaneLiczby = (int[])liczby.Clone();
        Array.Sort(posortowaneLiczby);

        bool czySaTakieSame = true;
        for (int i = 0; i < liczby.Length; i++)
        {
            if (liczby[i] != posortowaneLiczby[i])
            {
                czySaTakieSame = false;
                break;
            }
        }

        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int k = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > k)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = k;
            }
        }

        Console.WriteLine("Czy sortowanie jest poprawne? " + (czySaTakieSame ? "Tak" : "Nie"));
    }
}