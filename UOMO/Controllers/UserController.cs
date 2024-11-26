using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using UOMO.Models;

namespace UOMO.Controllers
{
    public class UserController : Controller
    {
        private readonly UOMOContext _sql;

        public UserController(UOMOContext sql)
        {
            _sql = sql;
        }
        public IActionResult account_dashboard()
        {
            return View();
        }
        public IActionResult Box(int id)
        {
            return View(_sql.Boxes.Include(x=>x.BoxProduct).ThenInclude(x=>x.Photos).Where(x => x.BoxCargoId== id).ToList());
        }
        public IActionResult account_orders(int id)
        {
            id = Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value);
            var a = _sql.Cargos.Include(x=>x.CargoLevel).Where(x=>x.CargoUserId==id).ToList();
            return View(a);
        }
        public IActionResult account_edit_address()
        {
            return View();
        }
        public IActionResult account_edit(int id)
        {
            var a = _sql.Users.SingleOrDefault(x=>x.UserId==id);
            ViewBag.Countries = _sql.Countries;
            return View(a);
        }
        [HttpPost]
        public IActionResult account_edit(int id,User user, string NewPassword)
        {
            var a = _sql.Users.SingleOrDefault(x => x.UserId == id);
            if (a.UserPassword== GetMD5(user.UserPassword))
            {
            a.UserPassword = GetMD5(NewPassword);
                
            a.UserName = user.UserName;
            a.UserProfilePhotoUrl = "avatar.jpg";
            a.UserEmail=user.UserEmail;
            a.UserGender = user.UserGender;
            a.UserCountry=user.UserCountry;
            a.UserNickName=user.UserNickName;
            a.UserSurname=user.UserSurname;

            _sql.SaveChanges();
            return RedirectToAction("account_edit","User");
            }
            else
            {
                return View();
            }
        }


        public IActionResult account_wishlist(int id)
        {
            id = Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value);
            var a=_sql.WishLists.Include(x=>x.WishProduct).Include(x=>x.WishProduct.Photos).Include(x=>x.WishProduct.ProductCategory).Where(x=>x.WishUserId==id).ToList();
            return View(a);
        }
        public IActionResult add_wishlist(WishList wishlist,int id)
        {
            wishlist.WishProductId = id;
            wishlist.WishUserId = Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value);
            _sql.WishLists.Add(wishlist);
            _sql.SaveChanges();
            return RedirectToAction("Shop","Home");
        }
        public IActionResult remove_wishlist( int id)
        {
            var a = _sql.WishLists.Where(x => x.WishProductId == id).ToList();
            _sql.WishLists.RemoveRange(a);
            _sql.SaveChanges();
            return RedirectToAction("account_wishlist", "User");
        }
      
        public IActionResult choose()
        {
            return View();
        }
        public IActionResult login_register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login_register(User user)
        {
            user.UserPassword = GetMD5(user.UserPassword);
            var daxilolan = _sql.Users.SingleOrDefault(x=>x.UserNickName==user.UserNickName && x.UserPassword==user.UserPassword);
            if (daxilolan != null)
            {
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,daxilolan.UserName),
                    new Claim(ClaimTypes.Surname,daxilolan.UserSurname),
                    new Claim(ClaimTypes.Email,daxilolan.UserEmail),
                    new Claim(ClaimTypes.GivenName,daxilolan.UserNickName),
                    new Claim(ClaimTypes.Sid,daxilolan.UserId.ToString()),
                };

                var identity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                var prins=new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties();
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,prins,props).Wait();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync().Wait();
            return RedirectToAction("login_register", "User");

        }
        public IActionResult SignUp(int id)
        {
            ViewBag.Countries = _sql.Countries;
            var a=_sql.Users.Include(x => x.UserCountry).ToList();
            return View(a);
        }
        [HttpPost]
        public IActionResult SignUp(User user, IFormFile UserProfilePhoto)
        {
            if (user.UserGender == "Men" && UserProfilePhoto == null)
            {
                user.UserProfilePhotoUrl = "avatar.jpg";
            }
            if (user.UserGender == "Women" && UserProfilePhoto == null)
            {
                user.UserProfilePhotoUrl = "womanavatar.png";
            }
            if (UserProfilePhoto != null)
            {
                string newproduct = Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) + Path.GetExtension(UserProfilePhoto.FileName);
                using (Stream stream = new FileStream("wwwroot/images/" + newproduct, FileMode.Create))
                {
                    UserProfilePhoto.CopyTo(stream);
                }
                user.UserProfilePhotoUrl = newproduct;
            }


            user.UserPassword = GetMD5(user.UserPassword);
            user.UserRole = "Personal";
            _sql.Users.Add(user);
            _sql.SaveChanges();
            return RedirectToAction("login_register", "Home");
        }

    

    private string GetMD5(string input)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
    }
}

