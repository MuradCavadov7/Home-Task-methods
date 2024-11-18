using EF_Core.Contexts;
using EF_Core.Exceptions;
using EF_Core.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Helpers;

public class CaseHelper 
{
    public List<User>?Users { get; set; }
    public List<Product>?Products { get; set; }
    public List<Basket>?Baskets { get; set; }


    public void Register()
    {
        string name = Console.ReadLine()!;
        string surname = Console.ReadLine()!;
        string username = Console.ReadLine()!;
        string password = Console.ReadLine()!;

        using (AppDbContext sql = new AppDbContext())
            if (sql.Users.Any(u => u.Username == username))
            {
                Console.WriteLine("Registration failed!");
            }
            else
            {
                sql.Users.Add(new User
                {
                    Name = name!,
                    Surname = surname!,
                    Username = username!,
                    Password = password!

                });
                sql.SaveChanges();
                Console.WriteLine("registration was successful!");
            }
    }
    public User Login()
    {
        string username = Console.ReadLine()!;
        string password = Console.ReadLine()!;
        using (AppDbContext sql = new AppDbContext())
        {
            var user = sql.Users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            if (user == null)
            {
                throw  new UserNotFoundException("User not found");
            }
            Console.WriteLine("login is successful");
            return user;
        }
    }

    public void GetAllProduct(User user)
    {//Məllim Product-ları Sqlde insert eledim
        using (AppDbContext sql = new AppDbContext())
        {
            sql.Products.ToList().ForEach(p => Console.WriteLine($"{p.Id}. {p.Name}-{p.Price}"));
            int id = int.Parse(Console.ReadLine()!);
            var products = sql.Products.Where(p => p.Id == id!).FirstOrDefault();

            if (products is null)
            {
                throw new ProductNotFoundException("Product Not Found");
            }
            sql.Baskets.Add(new Basket
            {
                UserId = user.Id!,
                ProductId = products.Id!,
            });
            sql.SaveChanges();
            Console.WriteLine("Product added to the baskets");
        }
        
    }

    public void GetAllBaskets(User user)
    {
        using (AppDbContext sql = new AppDbContext())
        {
            var baskets = sql.Baskets.Where(x => x.UserId == user.Id).ToList();
            foreach (var basket in baskets)
            {
                var products = sql.Products.Where(x => x.Id == basket.ProductId).FirstOrDefault();
                Console.WriteLine(products.Id + ". " + products.Name + " - " + products.Price );
            }

            Console.WriteLine("Send your Remove Id");
            int rId = int.Parse(Console.ReadLine());
            var query = sql.Baskets.Where(x => x.UserId == user.Id && x.ProductId == rId).FirstOrDefault();

            var query2 = baskets.Find(x => x.ProductId == rId);

            if (query is null)
            {
                throw new ProductNotFoundException("Product Not Found");
            }
            sql.Baskets.Remove(query);
            Console.WriteLine("Product is Removed");
            sql.SaveChanges();

        }
    }

}
