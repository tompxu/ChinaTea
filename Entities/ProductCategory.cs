//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChinaTea.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int Id { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductCategoryChineseName { get; set; }
        public string ProductCategoryDescription { get; set; }
    
        public virtual ICollection<Product> Products { get; set; }
    }
}
