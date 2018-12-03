using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (var context = new MusicContext())
            {
                var albums = context.Albums.Count();
                Console.WriteLine(albums);

                context.Albums.Add(new Album() { Price = 9.99m, Title = "Wish" });
                context.SaveChanges();

                albums = context.Albums.Count();

                Console.WriteLine(albums);
                Console.ReadLine();

            }*/

            //var mongo client
            var mongoDbClient = new MongoClient("mongodb://localhost:27017");
            //create a database object
            var db = mongoDbClient.GetDatabase("musica");
            var shelf = db.GetCollection<BsonDocument>("Albums");

            var doc = new BsonDocument
            {
                {"AlbumId","1" },
                {"Title","Enco" },
                { "Price", "99.9"},
            };
            var doc1 = new BsonDocument
            {
                { "AlbumId","2"},
                { "Title","Get Rich or Die Trying"},
                { "Price","125,5"}
                };
            shelf.InsertOneAsync(doc);
            shelf.InsertOneAsync(doc1);

            Console.Read();
        }
    }

    /*public class Album
    {
        public int AlbumId { get; set; }
        public String Title { get; set; }
        public decimal Price { get; set; }
    }

    public class MusicContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
    }*/
}
