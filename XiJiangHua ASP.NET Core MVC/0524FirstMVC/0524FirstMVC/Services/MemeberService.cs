using _0524FirstMVC.Data;
using _0524FirstMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using _0524FirstMVC.ViewModels;

namespace _0524FirstMVC.Services
{
    public class MemeberService
    {
        private readonly MemberContext _context;
        public MemeberService()
        {
            _context = new MemberContext();
        }
        public async Task<List<CityCountViewModel>> CityCount()
        {
            var query = from member in await _context.Members.ToListAsync()
                        group member by member.City into cityGroup
                        select new CityCountViewModel { City = cityGroup.Key, Count = cityGroup.Count() };
            var query2 = (await _context.Members.ToListAsync())
                                .GroupBy(member => member.City)
                                .Select(g => new CityCountViewModel { City = g.Key, Count = g.Count() });
            return query.ToList();
        }

    }
}
