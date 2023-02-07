using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullMVCourse.Core
{
    public class MyDBContext : IdentityDbContext<ApplicationUser, Role, int>
    {
        private readonly DbContextOptions _options;
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
            _options = options;
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskDocument> TaskDocuments { get; set; }
        public DbSet<TaskLink> TaskLinks { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }

    }
}
