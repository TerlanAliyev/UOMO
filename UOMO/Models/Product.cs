using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class Product
    {
        public Product()
        {
            Baskets = new HashSet<Basket>();
            Boxes = new HashSet<Box>();
            Photos = new HashSet<Photo>();
            WishLists = new HashSet<WishList>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double? ProductPrice { get; set; }
        public int? ProductUserId { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? ProductShopId { get; set; }
        public int? ProductColorId { get; set; }
        public int? ProductSizeId { get; set; }

        public virtual Category ProductCategory { get; set; }
        public virtual Color ProductColor { get; set; }
        public virtual Size ProductSize { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Box> Boxes { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }
    }
}
