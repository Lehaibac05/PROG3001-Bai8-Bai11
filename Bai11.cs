namespace Bai11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap thu muc de luu file: ");
            string directory = Console.ReadLine();

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
                Console.WriteLine($"Thu muc '{directory}' da duoc tao.");
            }
            Console.Write("Nhap ten file (bao gom phan mo rong, vd: file.txt): ");
            string fileName = Console.ReadLine();

            Console.Write("Nhap noi dung can ghi vao file: ");
            string content = Console.ReadLine();

            string filePath = Path.Combine(directory, fileName);

            File.WriteAllText(filePath, content);
            Console.WriteLine($"Noi dung da duoc ghi vao file {filePath}");

            string readContent = File.ReadAllText(filePath);

            Console.WriteLine("Noi dung doc tu file:");
            Console.WriteLine(readContent);
        }
    }
}
