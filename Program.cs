internal class Program
{
    private static void Main(string[] args)
    {
        string[] donviArray = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        string[] chucArray = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        string[] tramArray = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };

        Console.WriteLine("Nhập một số:");
        int so = int.Parse(Console.ReadLine());

        if (so >= 0 && so < 1000)
        {
            int donvi = so % 10;
            int chuc = (so / 10) % 10;
            int tram = so / 100;

            if (tram > 0) Console.Write(tramArray[tram] + " ");
            if (chuc > 0 || tram > 0) Console.Write(chucArray[chuc] + " ");
            if (donvi > 0 || so == 0) Console.WriteLine(donviArray[donvi]);
        }
        else
        {
            Console.WriteLine("Nhập sai giá trị");
        }
    }
}