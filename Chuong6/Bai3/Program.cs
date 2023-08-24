using System;
namespace btc6
{
    interface Edition
    {
        void CompareTo();
    }
    class Book:Edition
    {
        public string title;
        public string author;
        public string year;
        public string publisher;
        public string[,] DS=new string[100,100];
        List<string> TG =new List<string>();
        public static int dem=0;
        public  void Nhap()
        {
            Console.WriteLine("Nhap tieu de: ");
            title=Console.ReadLine();
            DS[0,dem]=title;
            Console.WriteLine("Nhap ten tac gia: ");
            author=Console.ReadLine();
            DS[0,dem]=author;
            TG.Add(author);
            Console.WriteLine("Nam xuat ban: ");
            year=Console.ReadLine();
            DS[2,dem]=year;
            Console.WriteLine("Nha xuat ban: ");
            publisher=Console.ReadLine();
            DS[3,dem]=publisher;
            DS[4,dem]="Book";
            dem++;
        }
        public void Xuat()
        {
            CompareTo();
            int tt=0;
            bool T=true;
            while(T)
            for (int i=0; i<dem;i++)
            {
                if (DS[1,i]==TG[tt])
                {
                    Console.WriteLine("Tieu de: {0}, tac gia: {1}, nam xuat ban: {2}, nha xuat ban: {3}",DS[0,i],DS[1,i],DS[2,i],DS[3,i]);
                }
            }
            tt++;
            if (tt==TG.Count()){T=false;}
        }
        public void CompareTo()
        {
            TG.Sort();
        }
    }
    class Article:Edition
    {
        public string title;
        public string author;
        public string year;
        public string journal;
        public string[,] DS=new string[100,100];
        List<string> TG =new List<string>();
        public static int dem=0;
        public void Nhap()
        {
            Console.WriteLine("Nhap tieu de: ");
            title=Console.ReadLine();
            DS[0,dem]=title;
            Console.WriteLine("Nhap ten tac gia: ");
            author=Console.ReadLine();
            DS[0,dem]=author;
            Console.WriteLine("Nam xuat ban: ");
            year=Console.ReadLine();
            DS[2,dem]=year;
            Console.WriteLine("Tap chi:");
            journal=Console.ReadLine();
            DS[3,dem]=journal;
            DS[4,dem]="Article";
            dem++;
        }
       public void Xuat()
        {
            CompareTo();
            int tt=0;
            bool T=true;
            while(T)
            for (int i=0; i<dem;i++)
            {
                if (DS[1,i]==TG[tt])
                {
                    Console.WriteLine("Tieu de: {0}, tac gia: {1}, nam xuat ban: {2}, nha xuat ban: {3}",DS[0,i],DS[1,i],DS[2,i],DS[3,i]);
                }
            }
            tt++;
            if (tt==TG.Count()){T=false;}
        }
        public void CompareTo()
        {
            TG.Sort();
        }
    }
    class OnlineResoure:Edition
    {

        public string title;
        public string author;        
        public string link;
        public string abstractt;
        public string[,] DS=new string[100,100];
        List<string> TG =new List<string>();
        public static int dem=0;
        public void Nhap()
        {
            Console.WriteLine("Nhap tieu de: ");
            title=Console.ReadLine();
            DS[0,dem]=title;
            Console.WriteLine("Nhap ten tac gia: ");
            author=Console.ReadLine();
            DS[0,dem]=author;
            Console.WriteLine("Duong link: ");
            link=Console.ReadLine();
            DS[2,dem]=link;
            Console.WriteLine("Truu tuong: ");
            abstractt=Console.ReadLine();
            DS[3,dem]=abstractt;
            DS[4,dem]="OnlineResoure";
            dem++;
        }
        public void Xuat()
        {
            CompareTo();
            int tt=0;
            bool T=true;
            while(T)
            for (int i=0; i<dem;i++)
            {
                if (DS[1,i]==TG[tt])
                {
                    Console.WriteLine("Tieu de: {0}, tac gia: {1}, nam xuat ban: {2}, nha xuat ban: {3}",DS[0,i],DS[1,i],DS[2,i],DS[3,i]);
                }
            }
            tt++;
            if (tt==TG.Count()){T=false;}
        }
        public void CompareTo()
        {
            TG.Sort();
        }
    }
    class Program
    {
        static void Main()
        {
            int chon;
            int dem=0;
            Book s=new Book();
            Article tc= new Article();
            OnlineResoure tt=new OnlineResoure();
            string[,] DS=new string[100,100];
            List<string> dst =new List<string>();
            do 
            {
                Console.WriteLine("**EDITION**");
                Console.WriteLine("MENU");
                Console.WriteLine("1. Book.");
                Console.WriteLine("2. Article.");
                Console.WriteLine("3. OnlineResoure.");
                Console.WriteLine("4. Sort by title.");
                Console.WriteLine("5. Search by author.");
                Console.WriteLine("6. End.");
                chon=int.Parse(Console.ReadLine());
                switch(chon)
                {
                    case 1:
                        s.Nhap();
                        dst.Add(s.title);
                        DS[0,dem]=s.title;
                        DS[1,dem]=s.author;
                        DS[2,dem]=s.year;
                        DS[3,dem]=s.publisher;
                        dem++;
                        break;
                    case 2:
                        tc.Nhap();
                        dst.Add(tc.title);
                        DS[0,dem]=tc.title;
                        DS[1,dem]=tc.author;
                        DS[2,dem]=tc.year;
                        DS[3,dem]=tc.journal;
                        dem++;
                        break;
                    case 3:
                        tt.Nhap();
                        dst.Add(tt.title);
                        DS[0,dem]=tt.title;
                        DS[1,dem]=tt.author;
                        DS[2,dem]=tt.link;
                        DS[3,dem]=tt.abstractt;
                        dem++;
                        break;
                    case 4:
                        dst.Sort();
                        bool T=true;
                        int t=0;
                        while(T)
                        {for (int i=0; i<dem;i++)
                        {
                            if (DS[0,i]==dst[t])
                            {Console.WriteLine("An pham {0}: {1}, {2}, {3}, {4}",(t+1),DS[0,i],DS[1,i],DS[2,i],DS[3,i]);}
                        }
                        t++;
                        if (t==dst.Count()){T=false;}}
                        break;
                    case 5:
                        string FAuthor=Console.ReadLine();
                        Console.WriteLine("Edition by author {0}",FAuthor);
                        for (int i=0;i<dem;i++)
                        {
                            if (DS[1,i]==FAuthor)
                            {Console.WriteLine("{0}, {1}, {2}, {3}",DS[0,i],DS[1,i],DS[2,i],DS[3,i]);}
                        }
                        break;
                    case 6:
                        break;
                }
            }while(chon!=6);
        }
    }
}