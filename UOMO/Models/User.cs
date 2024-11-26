using System;
using System.Collections.Generic;

#nullable disable

namespace UOMO.Models
{
    public partial class User
    {
        public User()
        {
            Baskets = new HashSet<Basket>();
            Boxes = new HashSet<Box>();
            Cargos = new HashSet<Cargo>();
            Orders = new HashSet<Order>();
            WishLists = new HashSet<WishList>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserNickName { get; set; }
        public string UserGender { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserProfilePhotoUrl { get; set; }
        public int? UserCountryId { get; set; }
        public string UserRole { get; set; }
        public string UserCity { get; set; }
        public string UserStreetAdress { get; set; }
        public int? UserPostCode { get; set; }
        public string UserPhone { get; set; }

        public virtual Country UserCountry { get; set; }
        public virtual ICollection<Basket> Baskets { get; set; }
        public virtual ICollection<Box> Boxes { get; set; }
        public virtual ICollection<Cargo> Cargos { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }
    }
}
