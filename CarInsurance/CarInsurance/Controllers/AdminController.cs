using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace CarInsurance.Views.Admin
{
    public class AdminController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Admin
        public ActionResult Index(int? id)
        {

            //IList<Client> clientList = from a in _dbFeed.Client.Include("Auto") select a

            //// Make list of insurees -- Entity won't let you save to db inside a foreach loop.
            //List<Insuree> insurees = select * from db.insurees;

            var insurees = db.Insurees.Where(x => x.Id != null).ToList();

            foreach (var insuree in insurees)
            {

                decimal startQuote = 50m;
                TimeSpan age = DateTime.Now - insuree.DateOfBirth;
                double ageYears = age.Days / 365.25;
                if (ageYears < 19)
                {
                    startQuote += 100;
                }
                else if (ageYears < 26)
                {
                    startQuote += 50;
                }
                else
                {
                    startQuote += 25;
                }

                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                    startQuote += 25;
                }

                if (insuree.CarMake == "Porche")
                {
                    startQuote += 25;

                    if (insuree.CarModel == "Carerra")
                    {
                        startQuote += 25;
                    }
                }

                startQuote += (insuree.SpeedingTickets * 10);

                if (insuree.DUI)
                {
                    startQuote *= (decimal)1.25;
                }

                if (insuree.CoverageType)
                {
                    startQuote *= (decimal)1.5;
                }

                insuree.Quote = startQuote;

                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }

            }
            return View(db.Insurees.ToList());
        }

    }
}