using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CandyShopen.Models;

namespace CandyShopen.ViewModels
{
    public class CandyListViewModel
    {
        public IEnumerable<Candy> Candies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
