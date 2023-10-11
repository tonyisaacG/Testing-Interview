
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Interfaces
{
    public interface IGenericReposatory<T> where T :class
    {
        Task<IReadOnlyList< T>> ListAllAsync();



    }
}
