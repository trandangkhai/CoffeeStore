using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeStore.Models
{
    public interface ICoffeeStoreRepository
    {
        IQueryable<Coffee> Coffees { get; }
        void SaveBook(Coffee b);
        void CreateBook(Coffee b);
        void DeleteBook(Coffee b);
    }
}
