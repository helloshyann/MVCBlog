using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVCBlog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBlog.Services
{
    public class DataService
    {
        public static async Task ManageDataAsync(IHost host)
        {
            using var svcScope = host.Services.CreateScope();
            var svcProvider = svcScope.ServiceProvider;
            // Database Access
            var dbContextSvc = svcProvider.GetRequiredService<ApplicationDbContext>();
            // For published applications - this runs update-database on production code
            await dbContextSvc.Database.MigrateAsync();
        }
    }
}
