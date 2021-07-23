using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signUps = db.SignUps.Where(x => x.Removed == null).ToList();

                var signUpVms = new List<SignUpVm>();
                foreach (var signUp in signUps)
                {
                    var signupVm = new SignUpVm();
                    signupVm.Id = signUp.Id;
                    signupVm.FirstName = signUp.FirstName;
                    signupVm.LastName = signUp.LastName;
                    signupVm.EmailAddress = signUp.EmailAddress;
                    signUpVms.Add(signupVm);
                }

                return View(signUpVms);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signUp = db.SignUps.Find(Id);
                signUp.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}