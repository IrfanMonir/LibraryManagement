using LibraryManagement.Application.Interfaces;
using LibraryManagement.Infrastructure.Services;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Infrastructure.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IBookService, BookService>();
            return services;
        }
    }
}
