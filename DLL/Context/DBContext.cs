using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DLL.Context
{
    public class DBContext : IdentityDbContext<User>
    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }

        public new DbSet<User> Users { get; set; }
        public DbSet<ActivationCode> ActivationCodes { get; set; }
        public DbSet<ApiToken> ApiTokens { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerTank> PlayerTanks { get; set; }
        public DbSet<CodeRequest> CodeRequests { get; set; }
    }
}