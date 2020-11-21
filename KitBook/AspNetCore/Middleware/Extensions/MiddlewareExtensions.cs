﻿using KitBook.Models.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder ApplyDatabaseMigrations(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();
            using var context = serviceScope.ServiceProvider.GetService<CookbookDbContext>();
            context.Database.Migrate();
            return app;
        }
    }
}