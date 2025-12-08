using Microsoft.EntityFrameworkCore;
using StudentsManager.Mvc.Persistence;

namespace StudentsManager.Tests.Providers;

internal static class DbContextProvider
{
    internal static DbContextOptions<ManagerDbContext> GetDbContextOptions()
    {
        var connectionString = ConnectionStringProvider.GetConnectionString();
        return new DbContextOptionsBuilder<ManagerDbContext>().UseSqlServer(connectionString).Options;
    }
}