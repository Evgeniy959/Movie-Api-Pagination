using MovieApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.ViewModel
{
    public class SearchViewModel
    {
        public IEnumerable<Details> Movies { get; set; }
        public string Title { get; set; }
        public int TotalResults { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }

    }
}
