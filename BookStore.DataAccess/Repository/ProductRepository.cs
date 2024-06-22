﻿using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repository.IRepository;
using BookStore.Models;

namespace BookStore.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if(objFromDb != null)
            {
                    objFromDb.Title = obj.Title;
                    objFromDb.ISBN = obj.ISBN;
                    objFromDb.Price = obj.Price;
                    objFromDb.Price50 = obj.Price50;
                    objFromDb.ListPrice = obj.ListPrice;
                    objFromDb.Price100 = obj.Price100;
                    objFromDb.Description = obj.Description;
                    objFromDb.Category = obj.Category;
                    objFromDb.Author = obj.Author;
                if(obj.ImageUrl!= null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
