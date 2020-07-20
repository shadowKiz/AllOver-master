using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using AllOver.Models;
namespace AllOver.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public HomeController()
        {
        }

        public HomeController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        [AllowAnonymous]
        [Authorize(Roles = "Cliente")]
        public ActionResult Index()
        {
            if (Request.IsAuthenticated)
            {
                var currentUserId = User.Identity.GetUserId();
                var manager = new UserManager<AllOver.Models.ApplicationUser>(new UserStore<AllOver.Models.ApplicationUser>(new AllOver.Models.ApplicationDbContext()));
                var currentUser = manager.FindById(currentUserId);
                var nombre = currentUser.FistName;
                var apellido = currentUser.LastName;
                ViewBag.FistName = nombre;
                ViewBag.LastName = apellido;
            }

            return View();
        }
        [AllowAnonymous]
        [Authorize(Roles = "Cliente")]
        public ActionResult About()
        {
            if (Request.IsAuthenticated)
            {
                var currentUserId = User.Identity.GetUserId();
                var manager = new UserManager<AllOver.Models.ApplicationUser>(new UserStore<AllOver.Models.ApplicationUser>(new AllOver.Models.ApplicationDbContext()));
                var currentUser = manager.FindById(currentUserId);
                var nombre = currentUser.FistName;
                var apellido = currentUser.LastName;
                ViewBag.FistName = nombre;
                ViewBag.LastName = apellido;
            }
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [ AllowAnonymous]
        [Authorize(Roles = "Cliente")]
        public ActionResult Catalogo()
        {
            if (Request.IsAuthenticated)
            {
                var currentUserId = User.Identity.GetUserId();
                var manager = new UserManager<AllOver.Models.ApplicationUser>(new UserStore<AllOver.Models.ApplicationUser>(new AllOver.Models.ApplicationDbContext()));
                var currentUser = manager.FindById(currentUserId);
                var nombre = currentUser.FistName;
                var apellido = currentUser.LastName;
                ViewBag.FistName = nombre;
                ViewBag.LastName = apellido;
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize(Roles = "Cliente")]
        public ActionResult Tiendasfisicas()
        {
            if (Request.IsAuthenticated)
            {
                var currentUserId = User.Identity.GetUserId();
                var manager = new UserManager<AllOver.Models.ApplicationUser>(new UserStore<AllOver.Models.ApplicationUser>(new AllOver.Models.ApplicationDbContext()));
                var currentUser = manager.FindById(currentUserId);
                var nombre = currentUser.FistName;
                var apellido = currentUser.LastName;
                ViewBag.FistName = nombre;
                ViewBag.LastName = apellido;
            }

            return View();
        }

        [Authorize(Roles = "Cliente")]
        public ActionResult Tiendasonline()
        {
            if (Request.IsAuthenticated)
            {
                var currentUserId = User.Identity.GetUserId();
                var manager = new UserManager<AllOver.Models.ApplicationUser>(new UserStore<AllOver.Models.ApplicationUser>(new AllOver.Models.ApplicationDbContext()));
                var currentUser = manager.FindById(currentUserId);
                var nombre = currentUser.FistName;
                var apellido = currentUser.LastName;
                ViewBag.FistName = nombre;
                ViewBag.LastName = apellido;
            }

            return View();
        }
        [AllowAnonymous]
       
        public ActionResult Producto()
        {
            if (Request.IsAuthenticated)
            {
                var currentUserId = User.Identity.GetUserId();
                var manager = new UserManager<AllOver.Models.ApplicationUser>(new UserStore<AllOver.Models.ApplicationUser>(new AllOver.Models.ApplicationDbContext()));
                var currentUser = manager.FindById(currentUserId);
                var nombre = currentUser.FistName;
                var apellido = currentUser.LastName;
                ViewBag.FistName = nombre;
                ViewBag.LastName = apellido;
            }

            return View();
        }

    }

}

    
