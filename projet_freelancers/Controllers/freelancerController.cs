using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projet_freelancers.Models;

namespace projet_freelancers.Controllers
{
    public class freelancerController : Controller
    {
        // GET: entreprises
        public ActionResult Index()
        {
            using (OurDbContext db = new OurDbContext())
            {
                return View(db.entreprise.ToList());
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(entreprise account)
        {
            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    db.entreprise.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.message = account.Prenom + " " + account.Nom + "sucessfully registered";
            }
            return View();
        }
        //login
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(entreprise user)
        {
            using (OurDbContext db = new OurDbContext())
            {
                var usr = db.entreprise.Single(u => u.Pseudo == user.Pseudo && u.Password == user.Password);
                if (usr != null)
                {
                    Session["Id"] = usr.Id.ToString();
                    Session["pseudo"] = usr.Pseudo.ToString();
                    return RedirectToAction("LoggedIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is wrong.");
                }
            }
            return View();
        }
        public ActionResult loggedin()
        {
            if (Session["Id"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}