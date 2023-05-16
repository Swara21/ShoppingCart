using Shoppingcart.Models;
using System.Collections.Generic;
using System.Net;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Shoppingcart.Data
{
    public class EssentialDBcontext : DbContext
    {
        public EssentialDBcontext(DbContextOptions<EssentialDBcontext> options) : base(options)
        { }
      
        public DbSet<UserDetails> UserInfo { get; set; }
        public DbSet<ProductDetails> Products { get; set; }
        public DbSet<PaymentGateway> Payment { get; set; }
        public DbSet<Cart> Carts { get; set; }

        public DbSet<Orders> Order { get; set; }
        public DbSet<UserAddress> Address{ get; set; }
        public DbSet<Feedback> Feedbacks { get; set; } 
    }
}

