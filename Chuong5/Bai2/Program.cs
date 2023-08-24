
namespace MyApp
{
    class People
    {
        public string ID;
        public string Hoten;
        public int Tuoi;
        public string Diachi;

        //public People(){}
        public virtual void Nhap()
        {
            Console.Write("Nhap ma so: ");
            ID = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            Hoten = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Tuoi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            Diachi = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine($"Ma so la: {ID}");
            Console.WriteLine($"Ho ten la: {Hoten}");
            Console.WriteLine($"Tuoi la: {Tuoi}");
            Console.WriteLine($"Dia chi la: {Diachi}");
        }
    }
    class Students : People
    {
        public string Tern;
        public double TP1;
        public double TP2;
        public double TP3;
        public double gpa;
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ten hoc phan: ");
            Tern = Console.ReadLine();
            Console.Write("Nhap diem TP1: ");
            TP1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem TP2: ");
            TP2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem TP3: ");
            TP3 = Convert.ToDouble(Console.ReadLine());
        }
        public void GPA()
        {
            gpa = (TP1 + TP2 + TP3) / 3;

            if (gpa >= 9.5 && gpa <= 10) { Console.WriteLine($"GPA sinh vien la: {gpa}"); Console.WriteLine("Xep loai A+"); }
            else if (gpa >= 8.5 && gpa <= 9.4) { Console.WriteLine($"GPA sinh vien la: {gpa}"); Console.WriteLine("Xep loai A"); }
            else if (gpa >= 8.0 && gpa <= 8.4) { Console.WriteLine($"GPA sinh vien la: {gpa}"); Console.WriteLine("Xep loai B+"); }
            else if (gpa >= 7.0 && gpa <= 7.9) { Console.WriteLine($"GPA sinh vien la: {gpa}"); Console.WriteLine("Xep loai B"); }
            else if (gpa >= 6.5 && gpa <= 6.9) { Console.WriteLine($"GPA sinh vien la: {gpa}"); Console.WriteLine("Xep loai C+"); }
            else if (gpa >= 5.5 && gpa <= 6.4) { Console.WriteLine($"GPA sinh vien la: {gpa}"); Console.WriteLine("Xep loai C"); }
            else if (gpa >= 5.0 && gpa <= 5.4) { Console.WriteLine($"GPA sinh vien la: {gpa}"); Console.WriteLine("Xep loai D+"); }
            else if (gpa >= 4.0 && gpa <= 4.9) { Console.WriteLine($"GPA sinh vien la: {gpa}"); Console.WriteLine("Xep loai D"); }
            else { Console.WriteLine("Xep loai F"); }
        }
        public override void Xuat()
        {
            Console.WriteLine($"Ten hoc phan la: {Tern}");
            base.Xuat();
            // Console.WriteLine($"GPA sinh vien la: {gpa}");
            GPA();
        }
    }
    class Lecture : People
    {
 
        public double Kinhnghiem;
        public string Hocvi;
        public string Chucvu;
        public int n;
        public override void Nhap()
        {
            Console.Write("Nhap vao so Giang Vien: ");
            n = Convert.ToInt32(Console.ReadLine());
            Lecture[] lecture = new Lecture[n];
            for (int i = 0; i < n; i++)
            {
                lecture[i] = new Lecture();
                Console.WriteLine($" Nhap thong tin giang vien thu {i + 1}");
                Console.Write("Nhap ma so: ");
                lecture[i].ID = Console.ReadLine();
                Console.Write("Nhap ho ten: ");
                lecture[i].Hoten = Console.ReadLine();
                Console.Write("Nhap tuoi: ");
                lecture[i].Tuoi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap dia chi: ");
                lecture[i].Diachi = Console.ReadLine();
                Console.Write("Nhap so nam kinh nghiem: ");
                lecture[i].Kinhnghiem = double.Parse(Console.ReadLine());
                Console.Write("Nhap Hoc vi: ");
                lecture[i].Hocvi = Console.ReadLine();
                Console.Write("Nhap Chuc vu: ");
                lecture[i].Chucvu = Console.ReadLine();
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (lecture[i].Kinhnghiem < lecture[j].Kinhnghiem)
                    {
                        Lecture lecturenew = new Lecture();
                        lecturenew = lecture[i];
                        lecture[i] = lecture[j];
                        lecture[j] = lecturenew;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ma so la: {lecture[i].ID}");
                Console.WriteLine($"Ho ten la: {lecture[i].Hoten}");
                Console.WriteLine($"Tuoi la: {lecture[i].Tuoi}");
                Console.WriteLine($"Dia chi la: {lecture[i].Diachi}");
                Console.WriteLine($"Nam kinh nghiem la {lecture[i].Kinhnghiem}");
                Console.WriteLine($"Hoc vi la {lecture[i].Hocvi}");
                Console.WriteLine($"Chuc vu la {lecture[i].Chucvu}");
            }
        }
    }
    internal class Bai2
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.Nhap();
            students.Xuat();
            Lecture lecture = new Lecture();
            lecture.Nhap();
            //lecture.Xuat();

        }
    }
}
