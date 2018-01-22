﻿using Warehouse.Products.Domain.Entities;
using Warehouse.Products.Domain.Extensibility.Repositories;
using Warehouse.Products.Infrastructure.PostgreSQLDataAccess.Database;

namespace Warehouse.Products.Infrastructure.PostgreSQLDataAccess.Repositories
{
    internal class ProductRepository : CrudRepository<Product>, IProductRepository
    {
        internal ProductRepository(ProductDbContext context) : base(context)
        {
        }
    }
}