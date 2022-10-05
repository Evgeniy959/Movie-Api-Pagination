using Microsoft.Extensions.DependencyInjection;
using MovieApi.Options;
using MovieApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMovieApi(this IServiceCollection services, Action<MovieApiOptions> options)
        {
            services.AddTransient<IMovieApiService, MovieApiService>();
            services.Configure<MovieApiOptions>(options);
            return services;
        }
    }
}
