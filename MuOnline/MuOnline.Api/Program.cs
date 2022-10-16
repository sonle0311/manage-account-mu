using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using MuOnline.Database;
using MuOnline.Database.EF;
using MuOnline.Database.Entities.Entites;
using MuOnline.Database.Repositories;
using MuOnline.Database.UnitOfWork;
using MuOnline.Services;
using MuOnline.Services.Abstractions;
using MuOnline.Services.CharacterSevices;
using MuOnline.Services.System;
using MuOnline.Services.System.Dtos;
using System.Reflection;

namespace MuOnline.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers()
                .AddFluentValidation(fl => fl.RegisterValidatorsFromAssemblyContaining<LoginUserRequestValidator>());
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var connectionString = builder.Configuration.GetConnectionString("MuOnlineDb");
            builder.Services.AddDbContext<MuOnlineDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddTransient(typeof(IDesignTimeDbContextFactory<MuOnlineDbContext>), typeof(MuOnlineDbContextFactory));
            builder.Services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<MuOnlineDbContext>()
                .AddDefaultTokenProviders();

            builder.Services.AddTransient<UserManager<AppUser>,UserManager<AppUser>>();
            builder.Services.AddTransient<SignInManager<AppUser>, SignInManager<AppUser>>();
            builder.Services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterModule<DatabaseConfig>();
                builder.RegisterModule<ServiceConfig>();
                

                //builder.RegisterType<UserService>().As<IUserService>().InstancePerLifetimeScope();
                //builder.RegisterType<CharacterService>().As<ICharacterService>().InstancePerLifetimeScope();

            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}