using Microsoft.EntityFrameworkCore;

namespace Multi_PageWebAppLayton.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Contact>().HasData(
            new Contact
            {
                ContactId = 1,
                Name = "Mark Ruffalo",
                Phone = "673-392-1992"
            },
            new Contact
            {
                ContactId = 2,
                Name = "John Cena",
                Phone = "551-523-5493"
            },
            new Contact
            {
                ContactId = 3,
                Name = "Biscuit Johnson",
                Phone = "641-841-0218"
            }
            );
        }
    }
}