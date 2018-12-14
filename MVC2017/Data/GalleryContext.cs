using MVC2017.Models;
using System.Data.Entity;

namespace MVC2017.Data
{
    public class GalleryContext : DbContext
    {
        public GalleryContext(): base("GalleryContext")
        {
            //Database.SetInitializer<GalleryContext> (new DropCreateDatabaseIfModelChanges<GalleryContext>());
        }

        public DbSet<Photo> Photos { get; set; }
    }
}