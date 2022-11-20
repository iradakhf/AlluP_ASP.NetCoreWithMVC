using Allup.DAL;
using Allup.Interfaces;
using Allup.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Allup.Services
{
    public class LayoutService : ILayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

   
        public async Task<Dictionary<string,string>> GetSettingsAsync()
        {
            return await _context.Settings.ToDictionaryAsync(s=>s.Key,s=>s.Value);
        }

    }
}
