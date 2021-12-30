using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CV_Siten.Models;


namespace CV_Siten.Controllers
{
    public class CompetenceController : Controller
    {
        // GET: Competence
        public ActionResult Index(Competences competence)
        {
            if (ModelState.IsValid)
            {
                using (DB db = new DB())
                {
                    
                    
                        db.Competences.Add(competence);
                        db.SaveChanges();
                    
                    
                }
            }
                return View();
        }

        public ActionResult AddCompetence()
        {
            return View();
        }
    }
} 