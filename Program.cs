using System;
using docker_workshop.Services;
using docker_workshop.Entity;

namespace docker_workshop
{
    class Program
    {
        static string database = "formations";
        static string user = "admin";
        static string pwd = "pwd";
        static string databaseHostname = Environment.GetEnvironmentVariable("DB_HOSTNAME");
        
        static void Main(string[] args)
        {
            string mongodbConnectionString = $"mongodb://{user}:{pwd}@{databaseHostname}:27017/?authSource=admin";

            var bookService = new BookService(mongodbConnectionString, database);

            var book1 = new Book("Nouveau livre", 1m);
            var book2 = new Book("Livre sur le CI/CD", 2m);
            
            bookService.Create(book1);
            bookService.Create(book2);

            var books = bookService.Get();

            Console.WriteLine(books[0].ToString());
        }
    }
}
