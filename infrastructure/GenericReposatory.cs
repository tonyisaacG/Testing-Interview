using core.Interfaces;
using infrastructure.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Data
{
    public class GenericReposatory<T> : IGenericReposatory<T> where T :class
    {
        private readonly StoreContext _context;
        public GenericReposatory(StoreContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

    }
}
