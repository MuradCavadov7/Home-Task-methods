using EF_Core.Contexts;
using EF_Core.Exceptions;
using EF_Core.Helpers;
using EF_Core.Models;
using System.Collections;

namespace EF_Core;

internal class Program
{
    static void Main(string[] args)
    {

        CaseHelper helper = new CaseHelper();
        //List<User> users = [];
        //List<Product> products = [];
        //List<Basket> baskets = [];
        Console.WriteLine(

   """ 
    Menu
    1. Register
    2. Login
    """

             );

        int choose = 0;
        bool isContinue = true;
        while (isContinue)
        {

            Console.Write("\nZehmet olmasa 1-2  deyerlerin gonderin:");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    {
                        helper.Register();
                        break;
                    }

                case 2:
                   
                    var user = helper.Login();
                    Console.WriteLine($"Welcome User:{user.Username}");
                    bool isBack = true;
                    while (isBack)
                    {
                        Console.WriteLine("""
    
                            0.Menu.
                            1.Məhsullara bax.
                            2.Səbətə bax.
                            3.Hesabdan çıx.
    
                            """);
                        int choosen = Convert.ToInt32(Console.ReadLine());
                        switch (choosen)
                        {
                            case 0:
                                break;
                            case 1:
                                helper.GetAllProduct(user);

                                break;
                            case 2:
                                helper.GetAllBaskets(user);
                                break;
                            case 3:
                                isBack = false;
                                break;
                            default:
                                Console.WriteLine("duzgun eded daxil etmediniz");
                                break;
                        }
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Duzgun reqem daxil edilmedi!\n");
                        Console.WriteLine(
                               """ 
                                 Menu
                                 1. Register
                                 2. Login
                                """);
                        break;
                    }
            }
        }
    }
}
