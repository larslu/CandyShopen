using CandyShopen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CandyShopen.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Candy> CandyOnSale { get; set; }
    }
}
