using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Insurance.ViewModels;
using Insurance.Models;




namespace InsuranceAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=DESKTOP-N51R0HN\SQLEXPRESS;Initial Catalog = Insurance; Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public ActionResult Index()
        {
            return View();
        }
    [HttpPost]
    public ActionResult UserInput(string firstName, string lastName, string emailAddress, int dateOfBirth, int carYear, string carMake, string carModel, bool dui, int speedingTickets, bool fullCoverage)
    {
            var userinput = new UserInput();
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
        {
            return View("~/Views/Shared/Error.cshtml");
        }
        else
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var signup = new UserInput();
                signup.FirstName = firstName;
                signup.LastName = lastName;
                signup.EmailAddress = emailAddress;
                signup.DateOfBirth = dateOfBirth;
                    signup.CarYear = carYear;
                    signup.CarMake = carMake;
                    signup.CarModel = carModel;
                    signup.DUI = dui;
                    signup.SpeedingTickets = speedingTickets;
                    signup.FullCoverage = fullCoverage;
                db.UserInputs.Add(signup);
                db.SaveChanges();
            }
                
                int quote = 50;
                if (dateOfBirth < 25 || dateOfBirth > 100)
                {
                    quote = quote + 25;
                    if (dateOfBirth < 18)
                    {
                        quote = quote + 75;
                        if (carYear < 2000 || carYear > 2015)
                        {
                            quote = quote + 25;
                            if (carMake == "Porsche")
                            {
                                quote = quote + 25;
                                if (carMake == "Porsche" && carModel == "911 Carrera")
                                {
                                    quote = quote + 25;
                                    if (speedingTickets > 0)
                                    {    var respuesta = string.ToLower(dui)
                                        quote = quote + (speedingTickets * 10);
                                        if (dui == true)
                                        {
                                            int percent = (quote / 4);
                                            quote = (quote + percent);
                                           
                                            if (fullCoverage == true)
                                            {
                                                int covpercent = (quote / 2);
                                                quote = (quote + covpercent);
                                                return View("Success" + quote);
                                            }
                                            else
                                            {
                                                return View("Success" + quote);
                                            }
                                        }
                                        else
                                        {
                                            return View("Success" + quote);
                                        }
                                    }
                                    else
                                    {
                                        return View("Success" + quote);
                                    }
                                }
                                else
                                {
                                    return View("Success" + quote);
                                }
                            }
                            else
                            {
                                return View("Success" + quote);
                            }
                        }
                        else
                        {
                            return View("Success" + quote);
                        }
                    }
                    else
                    {
                        return View("Success" + quote);
                    }


                }

                return View("Success" + quote);
        }
    }
} 
}

   

