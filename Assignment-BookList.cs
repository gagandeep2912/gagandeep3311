using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class book
    {
        public int BookNo { get; set; }
        public String BookName { get; set; }
        public String BookAuthors { get; set; }
        public double cost { get; set; }
        public int stock { get; set; } = 10;
    }
    class Booklist
    {
        private book[] books = null;
        private int size = 0;
        public Booklist(int size) {
            this.size = size;
            books = new book[size];

        }
        public void AddNewBook(book bks)
        {
            for (int i = 0; i < size; i++)
            {
                if (books[i] == null)
                {
                    books[i] = new book { BookNo = bks.BookNo, BookName = bks.BookName, BookAuthors = bks.BookAuthors };
                    return;
                }


            }

        }
        public void UpdateNewBook(book bks)
        {
            for (int i = 0; i < size; i++)
            {
                if (books[i] != null && books[i].BookNo == bks.BookNo)
                {
                    books[i].BookName = bks.BookName;
                    books[i].BookAuthors = bks.BookAuthors;
                    return;
                }
               
                throw new Exception("Book not found");

            }
          

        }
        public book FindNewBook(int id)
        {
            foreach (book bks in books)
            {
                if (bks != null && bks.BookNo == id)
                    return bks;
            }


            throw new Exception("Book not found");

        }

        public void DeleteBook(int id)
        {
            for (int i = 0; i < size; i++)
            {
                if (books[i] != null && books[i].BookNo == id)
                {
                    books[i] = null;
                    return;
                }

            }
            throw new Exception("Book not found");

        }
    }
        class UserInterface
    {

        public static Booklist bl = null;

        internal static void DisplayMenu(string file)
        {
            Console.WriteLine("enter the size");
            int size =Convert.ToInt32( Console.ReadLine());
            bl= new Booklist(size);
            bool processing = true;
            string Menu = File.ReadAllText(file);
            do
            {
                Console.WriteLine(Menu);
                int choice = Convert.ToInt32(Console.ReadLine());
                processing = processMenu(choice);
            } while (processing);
            Console.WriteLine("Thanks for using our application");
        }
        private static bool processMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    addingBook();
                    break;
                case 2:
                    updatingingBook();
                    break;
                case 3:
                    findingBook();
                    break;
                case 4:
                    deletingBook();
                    break;
                default:
                    return false;
                    break;
                    
            }
            return true;
        }
        private static void addingBook()
        {
            Console.WriteLine("Enter Id of the Book to be added");
            int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(id);
            Console.WriteLine("Enter Name of the Book to be added");
            string name =Console.ReadLine();
            //Console.WriteLine(name);
           Console.WriteLine("Enter Author of the Book to be added");
            string author = Console.ReadLine();
            //Console.WriteLine(author);
            book bks = new book { BookNo = id, BookAuthors = author, BookName = name };
          
            bl.AddNewBook(bks);
            Console.WriteLine("Addded succesfully");
            //Console.WriteLine("press enter to clear the screen");
           // Console.Clear();


        }
        private static void updatingingBook()
        {
            Console.WriteLine("Enter Id of the Book");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of the Book");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Author of the Book");
            string author = Console.ReadLine();
            book bks = new book { BookNo = id, BookAuthors = author, BookName = name };
            bl.UpdateNewBook(bks);
            //Console.WriteLine("press enter to clear the screen");
            //Console.Clear();


        }
        private static void findingBook()
        {
            Console.WriteLine("Enter Id of the Book");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                book bks = bl.FindNewBook(id);
                Console.WriteLine("The details of book u have searched for are\n");
                Console.WriteLine("The name of book is:"+bks.BookName+"/n The author of the book is:"+bks.BookAuthors);
                //Console.WriteLine("press enter to clear the screen");
                //Console.Clear();


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void deletingBook()
        {
            Console.WriteLine("Enter Id of the Book");
            int id = Convert.ToInt32(Console.ReadLine());
            bl.DeleteBook(id);
            Console.WriteLine("The book successfully deleted");
            //Console.WriteLine("press enter to clear the screen");
            //Console.Clear();
        }

    }

    class Assignment_BookList
    {
        static void Main(string[] args)
        {
            UserInterface.DisplayMenu(args[0]);
        }
     
    }
}
