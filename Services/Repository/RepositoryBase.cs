using Microsoft.EntityFrameworkCore;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class RepositoryBase<T> where T : class
    {
        BankAccountTypeContext context;
        DbSet<T> dbSet;
        public RepositoryBase() 
        {
            context = new BankAccountTypeContext();
            dbSet = context.Set<T>();
        }

        public List<T> GetAll() 
        {
            return dbSet.ToList();
        }

        public List<T> GetAllAccounts()
        {
            return dbSet.ToList();
        }

        public void Add(T item) 
        {
            dbSet.Add(item);
            context.SaveChanges();
        }

        public void Update(T item) 
        { 
            var tracker = context.Attach(item);
            tracker.State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T item)
        {
            dbSet.Remove(item);
            context.SaveChanges();
        }
    }
}
