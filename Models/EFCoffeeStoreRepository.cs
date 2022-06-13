using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeStore.Models
{
    public class EFCoffeeStoreRepository : ICoffeeStoreRepository
    {
        private CoffeeStoreDbContext context;
        public EFCoffeeStoreRepository(CoffeeStoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Coffee> Coffees => context.Coffees;
        public void CreateBook(Coffee b)
        {
            context.Add(b);
            context.SaveChanges();
        }
        public void DeleteBook(Coffee b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
        public void SaveBook(Coffee b)
        {
            context.SaveChanges();
        }
    }
}
