using _0524FirstMVC.Data;
using _0524FirstMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _0524FirstMVC.Services
{
    public class MenuService
    {
        public async Task<List<Member>> GetAllMembers()
        {
            MemberContext context = new MemberContext();
            var member = await context.Members.ToListAsync();
            return member;
        }

        public async Task<List<Member>> GetTeamMembers(string teamname)
        {
            MemberContext context= new MemberContext();
            var members = await context.Members.Where(x=>x.Team==teamname).ToListAsync();
            return members;
        }
    }
}
