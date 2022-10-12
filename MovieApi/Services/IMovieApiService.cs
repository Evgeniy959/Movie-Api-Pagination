﻿using MovieApi.Models;
using System.Threading.Tasks;

namespace MovieApi.Services
{
    public interface IMovieApiService
    {
        string ApiKey { get; }
        string BaseUrl { get; }

        Task<MovieApiResponse> SearchByTitle(string title, int page);
        Task<Details> SearchById(string id);
    }
}