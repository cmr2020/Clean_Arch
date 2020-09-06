using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
   public class DependensyContainer
    {
       
        
        public static void RegisterService(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //infra Data Layer

            services.AddScoped<ICourseRepository, CourseReository>();

            services.AddScoped<IEducationRepository, EducationRepository>();

        }



    }
}
