using System.Security.Cryptography.X509Certificates;

namespace bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap tu 1-2 tuong ung cau a-b: ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Bai9_a: ");
                    static string Reverse(string input)
                    {
                        char[] charArray = input.ToCharArray();
                        Array.Reverse(charArray);
                        return new string(charArray);
                    }

                    Console.WriteLine("Nhap chuoi ky tu cua ban: ");
                    string userInput = Console.ReadLine();
                    string reversedString = Reverse(userInput);
                    Console.WriteLine("Chuoi dao nguoc: " + reversedString);
                    break;

                case 2:
                    Console.WriteLine("Bai9_b");
                    Console.WriteLine("Nhap vao chuoi ky tu cua ban: ");
                    string input = Console.ReadLine();
                    Dictionary<char, int> charCount = new Dictionary<char, int>();

                    foreach (char c in input)
                    {
                        if (charCount.ContainsKey(c))
                        {
                            charCount[c]++;
                        }
                        else
                        {
                            charCount[c] = 1;
                        }
                    }




                    Console.WriteLine("So luong ky tu xuat hien trong chuoi la: ");
                    foreach (KeyValuePair<char, int> kvp in charCount)
                    {
                        Console.WriteLine($"'{kvp.Key}': {kvp.Value} lan");
                    }
                    break;
                

            


                        

            }
        }
    }
}
