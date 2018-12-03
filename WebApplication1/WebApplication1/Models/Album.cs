using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
 

namespace WebApplication1.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public String Title { get; set; }
        public decimal Price { get; set; }
    }

    public class MusicContext : DbContext

    {
        public MusicContext() { Database.Log = s => System.Diagnostics.Debug.WriteLine(s);}
        public DbSet<Album> Albums { get; set; }
    }
}