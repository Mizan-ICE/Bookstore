using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bookstore.Models;

namespace Bookstore.Data
{
    public class BookstoreContext : DbContext
    {
        public BookstoreContext (DbContextOptions<BookstoreContext> options)
            : base(options)
        {
        }

        public DbSet<Bookstore.Models.Book> Book { get; set; } = default!;
    }
}
