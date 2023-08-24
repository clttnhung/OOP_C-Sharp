using System;

namespace Lop
{
    internal class Program
    {
        // vd huy
        class Student
        {
            public string name;
            public Student(string name)
            {
                this.name = name;
                Console.WriteLine("Khoi tao " + name);
            }

            ~Student()
            {
                Console.WriteLine ("Huy"+ name);
            }
        }
        static void Main(string[] args)
        {
            Vukhi sungluc;
            sungluc = new Vukhi();
            //Console.WriteLine(sungluc.name);            
            //Vukhi sungtruong = new Vukhi("Xin chao");
            sungluc.name = "Sung luc";
            sungluc.Thietlapsatthuong(5);
            
            sungluc.Noisanxuat = "My";
            Console.WriteLine(sungluc.Noisanxuat);

            Vukhi sungmay = new Vukhi("Sung may", 15);

            sungluc.Tancong();
            sungmay.Tancong();


        //
        Student student;
        for( int i = 0; i < 1000; i++)
        {
            
        }
        student = new Student ("Sinh vien 1");

        student = null;

        }
    }
}
