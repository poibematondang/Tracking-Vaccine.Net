﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProduceTrackingVaccine.ServiceReference2;

namespace ProduceTrackingVaccine.Controllers
{
    public class AutentikasiController : Controller
    {
        // GET: Autentikasi
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string username, string password)
        {
            Service1Client service1Client = new Service1Client();
            if (service1Client.Login(username, password))
            {
                akun GetAccount = service1Client.GetAccount(username);
                if (GetAccount.role.Equals("Produsen"))
                {
                    return RedirectToAction("Home", "Produsen");
                }
            }
            return RedirectToAction("Index");
        }
    }
}