 


class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Üçgenin boyutunu girin: ");
            int size = int.Parse(Console.ReadLine());

            if (size <= 0)
            {
                Console.WriteLine("Geçersiz boyut. Pozitif bir tamsayı girin.");
                return;
            }

            TriangleDrawer.TriangleDrawer.DrawTriangle(size);
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz giriş. Bir tamsayı girin.");
        }
    }
}