using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Otus.Teaching.PromoCodeFactory.DataAccess.Context;

namespace Otus.Teaching.PromoCodeFactory.DataAccess
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlite("Data Source=Application.db");
            });
        }
    }
}
