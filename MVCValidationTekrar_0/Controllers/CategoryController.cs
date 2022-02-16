using MVCValidationTekrar_0.DesignPatterns.SingletonPattern;
using MVCValidationTekrar_0.Models;
using MVCValidationTekrar_0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCValidationTekrar_0.Controllers
{
    public class CategoryController : Controller
    {
        /*
                MVCValidation(Doğrulama)
        
        Sizin girilmesini istemediğiniz verilerin ne şekilde girilmesi gerektiğini (bu alanın girilmesi zorunlu mu , email formatonda mı , hangi sayı aralıkları , bir property ile uyuşması gerekiyor mu) MVC Validation ile yaparsınız... Bu Validation sınıflarını rahatça DBFirst ile oluşan sınıflarınıza da verebilirsiniz (Bu kesinlikle modelde modifikasyon yapmak sayılmaz)

        MVC Validation sınıflarını GitHub'dan , msdn'den hazır Regex sınıflarına bakarak bulabilirsiniz... ValidationAttribute sınıfından miras alan yapılara bakarsanız Validation sınıflarının arşivlerini bulabilirsiniz...

        Validation'lar ikiye ayrılırlar => Server Side ve Client Side

        Client Side 
        Client Side Validation için Manage Nuget'tan Jquery Unobtrusive Validation kütüphanesini indirmelisiniz...

        Bu kütüphaneyi indirirseniz bunun Jquery'e ihtiyac duyacağını da bilmeniz lazım...

         */

        NorthwindEntities _db;

        public CategoryController()
        {
            _db = DBTool.DBInstance;
        }

        // GET: Category
        public ActionResult ListCategory()
        {
            CategoryVM cvm = new CategoryVM
            {
                Categories = _db.Categories.ToList()
            };

            return View(cvm);
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            //ModelState property'miz bir modelin validated özelliklerini barındıran bir property'dir... (yani bu model gönderilmeye uygun mu Data Annotation'larına sadık mı vs...) ModelState.IsValid dersek bu bize bool döndüren bir sonuç veren bir property'i kullanmak olur ve her şey yolundaysa true döndürür ve işlemlerin devam etmesini sağlamamıza yarar... Tabi Data Annotation'ı veritabanı ayarlamalarına uygun vermemiz gerekir eğer Data Annotation yanlışsa her halükarda hata alma ihtimalimiz doğar...

            //Client Side Validation yapmıyorsanız aşağıdaki şekilde Server Side Validation'ı tetiklemelisiniz...

            //if (!ModelState.IsValid) return View();

            _db.Categories.Add(category);
            _db.SaveChanges();
            return RedirectToAction("ListCategory");
        }
    }
}