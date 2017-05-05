using ItRequitment.DAL;
using ItRequitment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItRequitments.Controllers
{
    public class RegistrationController : Controller
    {
        private DataBaseContext dbc = new DataBaseContext();
       
        // GET: Registration
        public ActionResult User()
        {
            return View();
        }

        
        public ActionResult UserAdd()
        {
            var user = new User
            {
                Login = "test",
                Password = "pass",
                Email = "emailtest",
                
            };
            
            dbc.User.Add(user);
            dbc.SaveChanges();
           
            
            return View();
        }
    }
}