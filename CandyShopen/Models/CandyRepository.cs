using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShopen.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly AppDbContext _appDbContext;

        public CandyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Candy> GetAllCandy => _appDbContext.Candies.Include(c => c.Category);

        public IEnumerable<Candy> GetCandyOnSale => _appDbContext.Candies.Include(c => c.Category).Where(p => p.IsOnSale);
       

        public Candy GetCandyById(int candyId)
        {
            return GetAllCandy.FirstOrDefault<Candy>(c => c.CandyId == candyId);
        }
    }
}
