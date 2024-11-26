using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UOMO.Models;

namespace UOMO.Controllers
{
    public class HomeController : Controller
    {
        private readonly UOMOContext _sql;

        public HomeController(UOMOContext sql)
        {
            _sql = sql;
        }

        public IActionResult Index()
        {
            var a = _sql.Products.Include(x => x.Photos).Take(4).ToList();
            return View(a);
        }
        public IActionResult Shop()
        {
            ViewBag.Categories = _sql.Categories.ToList();
            var a = _sql.Products.Include(x => x.Photos).Include(x => x.ProductCategory).ToList();
            return View(a);
        }
        public IActionResult product_variable(int id)
        {
            ViewBag.Colors = _sql.Colors.ToList();
            ViewBag.Sizes = _sql.Sizes.ToList();

            var a = _sql.Products.Include(x => x.Photos).Include(x => x.ProductCategory).SingleOrDefault(x => x.ProductId == id);
            return View(a);
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult blog_single()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
      
        public IActionResult lookbook()
        {
            return View();
        }
        public IActionResult faq()
        {
            return View();
        }
        public IActionResult terms()
        {
            return View();
        }
        public IActionResult error404()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
        public IActionResult shop_cart(int id)
        {
            id = Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value);
            ViewBag.Colors=_sql.Colors.ToList();
            ViewBag.Size = _sql.Sizes.ToList();

            var a = _sql.Baskets.Include(x => x.BasketProduct).ThenInclude(x=>x.Photos).Include(x=>x.BasketColor).Include(x => x.BasketSize).Where(x => x.BasketUserId == id).ToList();
            return View(a);
        }
        [HttpPost]
        public IActionResult add_shop_cart(Basket basket, int id)
        {
            var a=_sql.Baskets.Include(x=>x.BasketProduct).SingleOrDefault(x=>x.BasketProductId== id && x.BasketUserId == Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value));

            if (a!=null)
            {
                return RedirectToAction("error");
            }
            else
            {

            basket.BasketProductId = id;
            basket.BasketUserId = Convert.ToInt32(@User.FindFirst(ClaimTypes.Sid).Value);
            _sql.Baskets.Add(basket);
            _sql.SaveChanges();
            return RedirectToAction("shop_cart", "Home");
            }
        }
      
        public IActionResult remove_shop_cart(int id)
        {
            var a = _sql.Baskets.SingleOrDefault(x => x.BasketId == id);
            _sql.Baskets.Remove(a);
            _sql.SaveChanges();
            return RedirectToAction("shop_cart", "Home");

        }
        public IActionResult shop_checkout(int id)
        {
            id = Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value);
            ViewBag.Baskets = _sql.Baskets.Include(x=>x.BasketProduct).Where(x=>x.BasketUserId==id).ToList();
            var a = _sql.Users.Include(x => x.UserCountry).SingleOrDefault(x => x.UserId == id);
            ViewBag.Countries = _sql.Countries.ToList();
            return View(a);
        }

        public IActionResult shop_order_complete()
        {
            int id = Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value);
            var a = _sql.Boxes.Include(x=>x.BoxProduct).Where(x=>x.BoxUserId==id).ToList();
            return View(a);
        }
        public IActionResult shop_order_tracking()
        {
            return View();
        }
        public IActionResult siteMap()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LetOrder(List<Box> box,Cargo cargo,int id)
        {
            int totalprice = (int)box.Sum(x => x.BoxCount * x.BoxTotalPrice);
            cargo.CargoUserId = Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value);
            cargo.CargoDate = DateTime.Now;
            _sql.Cargos.Add(cargo);
            cargo.CargoTotalPrice = totalprice;
            cargo.CargoLevelId = 1;
            _sql.SaveChanges();

            foreach (var item in box)
            {
                item.BoxUserId = Convert.ToInt32(User.FindFirst(ClaimTypes.Sid).Value);
                item.BoxCargoId = cargo.CargoId;
                _sql.Boxes.Add(item);
                _sql.SaveChanges();
            }

            return RedirectToAction("shop_checkout","Home");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
