using System.Text;

Console.WriteLine("Nhap so 1-4 tuong ung cau a-d: ");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
        Console.WriteLine("bai8_a: ");
        Console.WriteLine("ASCII Table");
        Console.WriteLine("-----------");
        Console.WriteLine("Char\tCode");

        for (int i = 32; i < 127; i++) // ASCII printable characters range from 32 to 126
        {
            Console.WriteLine("{0}\t{1}", (char)i, i);
        }

        Console.ReadKey();
        break;

    case 2:
        Console.WriteLine("Bai8_b: ");
        for (int i = 32; i <= 127; i++)
        {
            char character = (char)i;
            string utf8Bytes = BitConverter.ToString(Encoding.UTF8.GetBytes(new char[] { character }));
            Console.WriteLine("{0}\tU+{1:X4}\t{2}", character, i, utf8Bytes);
        }

        for (int i = 0x00A1; i <= 0x00FF; i++)
        {
            char character = (char)i;
            string utf8Bytes = BitConverter.ToString(Encoding.UTF8.GetBytes(new char[] { character }));
            Console.WriteLine("{0}\tU+{1:X4}\t{2}", character, i, utf8Bytes);
        }

        Console.ReadKey();
        break;


    case 3:
        Console.WriteLine("Bai8_c: ");
        Console.WriteLine("Nhan phim Space de tao tieng beep, nhan esc de thoat.");

        while (true)
        {
            var key = Console.ReadKey(intercept: true).Key;

            if (key == ConsoleKey.Spacebar)
            {
                Console.Beep();
                Console.WriteLine("Beep!");
            }
            else if (key == ConsoleKey.Escape)
            {
                break;
            }
        }
        break;


    case 4:
        Console.WriteLine("Bai8_d: ");
        Console.WriteLine("Nhap vao choui ky tu: ");
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
        Console.WriteLine("so lan xuat hien cua moi ky tu trong: ");
        foreach (KeyValuePair<char, int> kvp in charCount)
        {
            {
                Console.WriteLine($"'{kvp.Key}': {kvp.Value} lan");

            }
        }

        break;


}
