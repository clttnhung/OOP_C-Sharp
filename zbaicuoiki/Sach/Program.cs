using System;
using System.Linq;

namespace ontap
{
    class Edition {
        public string title;
        public string author;
        public virtual void Nhap()
        {
            Console.WriteLine("Title: ");
            title=Console.ReadLine();
            Console.WriteLine("Author: ");
            author=Console.ReadLine();
        }
 
        // public abstract void CompareTo();
    }

    class Book : Edition {
        public int  year;
        public string publisher;
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Year: ");
            year=int.Parse(Console.ReadLine());
            Console.WriteLine("Publisher: ");
            publisher=Console.ReadLine();

        }
        // public override void CompareTo (){}
    }
    class Article : Edition {
        public int  year;
        public string journal;
        public override void Nhap()
        {
            Console.WriteLine("Year: ");
            year=int.Parse(Console.ReadLine());
            Console.WriteLine("Journal: ");
            journal=Console.ReadLine();

        }
        // public override void CompareTo (){}
    }
    class OnlineResoure : Edition {
        public string  link;
        public string abstrac;
         public override void Nhap()
        {

        }
        // public override void CompareTo (){}
    }
    
    
    class Program
    {
        static void Main() 
        {

        List<Book> books = new List<Book>();
        for (int i=0;i<5;i++)
        {
            var book  = new Book();
            book.Nhap();
            books.Add(book);
        }

        List<Book> SortedList = books.OrderBy(o=>o.title).ToList();

        Console.WriteLine($"123  {SortedList.Count()}");
        foreach(var item in SortedList){
            Console.WriteLine("Title: {0}, Author: {1}, year: {2}", item.title, item.author, item.year);
        }

        Console.ReadLine();
            
        }
    }
}