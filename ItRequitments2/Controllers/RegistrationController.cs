using ItRequitment.DAL;
using ItRequitment.Models;
using ItRequitment.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Web.Mvc;
using System.Text;

namespace ItRequitment.Controllers
{
    public class RegistrationController : Controller
    {
        private DataBaseContext dbc = new DataBaseContext();
        
       
        // GET: Registration
        public ActionResult User()
        {
            return View();
        }
        public ActionResult Company()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserAdd(User user)
        {
            if(!ModelState.IsValid)
            {                
                return View("User", user);
            }
           else
            {
                     

                dbc.User.Add(user);
                dbc.SaveChanges();
                return View();
            }      
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompanyAdd(Company company)
        {
            if (!ModelState.IsValid)
            {
                return View("Company", company);
            }
            else
            {
                dbc.Company.Add(company);
                dbc.SaveChanges();
                return View("CompanyAdd");
            }
        }
    }
}