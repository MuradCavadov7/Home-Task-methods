using Newtonsoft.Json;
using System.ComponentModel;
using System.Xml.Linq;

namespace Library_micro_project;

internal class Program
{
    static void Main(string[] args)
    {
        string path = Path.Combine(@"C:", "Users", "99477", "Desktop", "homework", "Library_micro_project", "Library_micro_project","Files","database.json");

        if (!File.Exists(path)) 
        {
            File.Create(path);
        }
        Library library = new Library("Library of Congress",path);

        Console.WriteLine(

        """ 
        Menu
        1. Add book
        2. Get book by id
        3. Remove book
        0. Quit
        """

                  );

        int choose = 0;
        bool isContinue = true;
        while (isContinue)
        {

            Console.Write("\nZehmet olmasa 1,2,3,0  deyer gonderin:");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    {
                        Book book = new Book(Console.ReadLine(), Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
                        book.ShowInfo();
                        library.AddBook(book);
                        break;
                    }

                case 2:
                    library.GetBookById(Convert.ToInt32(Console.ReadLine())).ShowInfo();
                    
                    break;

                case 3:
                    library.RemoveBook(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 0:
                    Console.WriteLine("Quit");
                    isContinue = false;
                    break;

                default:
                    Console.WriteLine("Duzgun reqem daxil edilmedi!\n");
                    Console.WriteLine(

        """ 
        Menu
        1. Add book
        2. Get book by id
        3. Remove book
        0. Quit
        """

           );
                    break;

            }
        }
    }
}