//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModelLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.Carts = new HashSet<Cart>();
            this.OrderCanceleds = new HashSet<OrderCanceled>();
            this.OrderConfirmeds = new HashSet<OrderConfirmed>();
            this.Orders = new HashSet<Order>();
            this.ProductWishlists = new HashSet<ProductWishlist>();
        }
    
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public System.DateTime ProductAddedDate { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductAvailability { get; set; }
        public int TotalProductAdded { get; set; }
        public int ProductAdminNotification { get; set; }
        public int ProductSizeId { get; set; }
        public string ProductImage { get; set; }
        public int ProductPrice { get; set; }
    
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual ProductSize ProductSize { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<OrderCanceled> OrderCanceleds { get; set; }
        public virtual ICollection<OrderConfirmed> OrderConfirmeds { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductWishlist> ProductWishlists { get; set; }
    }
}
