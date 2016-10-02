using System.Collections.Generic;
using MusicStore.Models;

namespace MusicStore.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}