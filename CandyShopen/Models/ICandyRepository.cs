using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShopen.Models
{
    public interface ICandyRepository
    {
        IEnumerable<Candy> GetAllCandy { get; set; }
        IEnumerable<Candy> GetCandyOnSale { get; set; }

        Candy GetCandyById(int candyId);

    }
}
