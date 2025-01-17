﻿using Models.Core;
using Models.Persistence;
using Styles.Controler;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WPF.Mappings
{
    public class ProductMapping
    {
        public ICollection<ProductSearchItem> ListProductToListProductSearchItem(ICollection<Product> Products)
        {
            if (Products == null || Products.Count == 0)
                return null;

            ICollection<ProductSearchItem> ProductSearchItems = new List<ProductSearchItem>();

            foreach (Product Product in Products)
            {
                ProductSearchItems.Add(this.ProductToProductSearchItem(Product));
            }

            return ProductSearchItems;
        }

        public ProductSearchItem ProductToProductSearchItem(Product Product)
        {
            if (Product == null)
                return null;

            return new ProductSearchItem()
            {
                ProductID = Product.ID,
                ProductDescription = Product.Name,
                ItemPrice = string.Format("{0:0.00}", Math.Round(Product.Price, 2)),
                ItemType = (Product.Type == Models.Core.ProductType.Measurable) ? Styles.Controler.ProductType.Measurable : Styles.Controler.ProductType.Unit
            };
        }

        public Product ProductSearchItemToProduct(ProductSearchItem ProductSearchItem)
        {
            if (ProductSearchItem == null)
                return null;

            return InventryMangementSystemDbContext.Products.FirstOrDefault(p => p.ID == ProductSearchItem.ProductID);
        }
    }
}
