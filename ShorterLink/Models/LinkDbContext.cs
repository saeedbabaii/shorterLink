using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ShorterLink.Models
{
    public class LinkDbContext : IdentityDbContext
    {
        public LinkDbContext(DbContextOptions<LinkDbContext> options) : base(options)
        {

        }
        public DbSet<Link> Pies { get; set; }
    }
}
