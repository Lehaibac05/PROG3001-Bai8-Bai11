namespace Bai10
{
    struct SinhVien
    {
        public string Ten;
        public float Diem;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            SinhVien[] sv = new SinhVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}");
                Console.Write("Ten: ");
                sv[i].Ten = Console.ReadLine();
                Console.Write("Diem: ");
                sv[i].Diem = float.Parse(Console.ReadLine());

              

                 
                }
            float tongDiem = 0;
            Console.WriteLine("\nThong tin sinh vien: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Sinh vien thu {i + 1}");
                Console.Write($"Ten: {sv[i].Ten}");
                Console.Write($"Diem: {sv[i].Diem}");
                tongDiem += sv[i].Diem;
            }

            float diemTrungBinh = tongDiem / n;
            Console.WriteLine($"\nDiem trung binh cua ca lop la: {diemTrungBinh}");
        }
    }
}
