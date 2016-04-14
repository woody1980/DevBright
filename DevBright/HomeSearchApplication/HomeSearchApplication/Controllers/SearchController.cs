using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeSearchApplication.Models;

namespace HomeSearchApplication.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View();
        }

        // GET: Search/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Search/SearchResults/5
        public ActionResult SearchResults(string name)
        {
            var model = from t in _review
                        where t.Name == name
                        select t;

            return View(model);
        }


        public ActionResult MoreInfo()
        {
            return View();
        }

        // GET: Search/Create
        public ActionResult Create(string name, string email, string title)
        {
            _lead.Add(new Lead()
            {
                Name = name,
                Email = email,
                Title = title
            });

            var Model = _lead;

            return View(Model);
        }

        // POST: Search/Create
        [HttpPost]
        public ActionResult Create(int something)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {

                return View();
            }
        }

        // GET: Search/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Search/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Search/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Search/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        static List<Homes> _review = new List<Homes>
        {
            new Homes
            {
                Name = "Victorian",
                Price = 20,
                Zip = 60655,
                Bedrooms = 2,
                Img ="/Images/vic1.jpg"
            },
            new Homes
            {
                Name = "Victorian",
                Price = 202,
                Zip = 61704,
                Bedrooms = 3,
                Img ="/Images/vic2.jpg"

            },
            new Homes
            {
                Name = "Victorian",
                Price = 30,
                Zip = 61704,
                Bedrooms = 4,
                Img ="/Images/vic3.jpg"
            },
            new Homes
            {
                Name = "Victorian",
                Price = 120,
                Zip = 22222,
                Bedrooms = 5,
                Img ="/Images/vic4.jpg"
            },
              new Homes
            {
                Name = "Colonial",
                Price = 100,
                Zip = 60655,
                Bedrooms = 4,
                Img ="/Images/colon1.jpg"
            },
              new Homes
            {
                Name = "Colonial",
                Price = 80,
                Zip = 61704,
                Bedrooms = 4,
                Img ="/Images/colon2.jpg"
            },
              new Homes
            {
                Name = "Colonial",
                Price = 20,
                Zip = 22222,
                Bedrooms = 3,
                Img ="/Images/colon3.jpg"
            },
              new Homes
            {
                Name = "Colonial",
                Price = 110,
                Zip = 60655,
                Bedrooms = 5,
                Img ="/Images/colon4.jpg"
            },
              new Homes
            {
                Name = "Colonial",
                Price = 75,
                Zip = 61704,
                Bedrooms = 3,
                Img ="/Images/colon5.jpg"
            },
              new Homes
            {
                Name = "Cape Cod",
                Price = 30,
                Zip = 22222,
                Bedrooms = 4,
                Img ="/Images/cod1.jpg"
            },
              new Homes
            {
                Name = "Cape Cod",
                Price = 140,
                Zip = 61704,
                Bedrooms = 2,
                Img ="/Images/cod2.jpg"
            },
              new Homes
            {
                Name = "Cape Cod",
                Price = 140,
                Zip = 60655,
                Bedrooms = 5,
                Img ="/Images/cod3.jpg"
            },
              new Homes
            {
                Name = "Cape Cod",
                Price = 20,
                Zip = 22222,
                Bedrooms = 3,
                Img ="/Images/cod4.jpg"
            },
              new Homes
            {
                Name = "Cape Cod",
                Price = 140,
                Zip = 61704,
                Bedrooms = 3,
                Img ="/Images/cod5.jpg"
            }
        };

        static List<Lead> _lead = new List<Lead>();
    }
}
