using Account_Payable_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Account_Payable_Application.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User login)
        {
            using (AccountPayableDBEntities db = new AccountPayableDBEntities())
            {
                var user = db.Users.Where(a => a.Email == login.Email && a.Pass == login.Pass).FirstOrDefault();
                if (user != null)
                {
                    var Ticket = new FormsAuthenticationTicket(login.Email, true, 1);
                    string Encrypt = FormsAuthentication.Encrypt(Ticket);
                    var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, Encrypt);
                    cookie.Expires = DateTime.Now.AddHours(1);
                    cookie.HttpOnly = true;
                    Response.Cookies.Add(cookie);

                    if (user.Roles == 1)
                    {
                        return RedirectToAction("Index", "Home"); //modify later
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home"); //modify later

                    }
                }
            }
            return View();
        }

        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}