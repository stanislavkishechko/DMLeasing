using BL.Common.Interfaces;
using BL.Common.Interfaces.Repositories;
using BL.Common.Interfaces.Services;
using BL.Services;
using Core.Entities;
using Infrastructure.Database.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));
            services.AddScoped<ITextFieldRepository, TextFieldRepository>();
            services.AddScoped<IServiceItemRepository, ServiceItemRepository>();
            services.AddScoped<IRepository<BlogItem>, Repository<BlogItem>>();
            services.AddScoped<ITextFieldService, TextFieldService>();
            services.AddScoped<IServiceItemService, ServiceItemService>();
            services.AddScoped<IBlogItemService, BlogItemService>();
            services.AddScoped<IEmailSender, EmailSender>();

            return services;
        }
    }
}
