using BookManagementUsing3tierMVCwithJQuery.Core.IRepository;
using BookManagementUsing3tierMVCwithJQuery.Core.IServices;
using BookManagementUsing3tierMVCwithJQuery.Resources.Repository;
using BookManagementUsing3tierMVCwithJQuery.Services.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BookManagementUsing3tierMVCwithJQuery.Utility
{

    public static class DIResolver
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();

            services.AddScoped<IServices, Service>();

            services.AddScoped<IRepository, Repository>();
        }
    }
}
