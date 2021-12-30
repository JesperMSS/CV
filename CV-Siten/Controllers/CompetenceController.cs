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
                    try
                    {
                        Competences competences = db.Competences.FirstOrDefault(u => u.Name.ToString().ToLower() == competence.Name.ToString().ToLower());

                        if (competences == null)
                        {
                            db.Competences.Add(competence);
                            db.SaveChanges();
                        }

                        else
                        {
                            ModelState.AddModelError("Name", "Kompetensen finns redan!");
                        }
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError("", (e));
                    }
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

