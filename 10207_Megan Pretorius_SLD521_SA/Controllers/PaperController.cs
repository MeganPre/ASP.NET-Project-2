using _10207_Megan_Pretorius_SLD521_SA.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _10207_Megan_Pretorius_SLD521_SA.Controllers
{
    [Authorize(Roles = "Author")]
    public class PaperController : Controller
    {
        PaperDbContext dbContext = new PaperDbContext();

        public ActionResult List()
        {
            var papers = dbContext.papers.Where(s => s.UserEmail == User.Identity.Name);
            return View(papers);
        }

        //GET: Paper
        [AllowAnonymous]
        public ActionResult PaperView()
        {
            return View(dbContext.papers.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Paper papers, FormCollection formCollection)
        {
            if (ModelState.IsValid)
            {
                papers.UserEmail = User.Identity.Name;
                papers.TopicId = int.Parse(papers.TopicId.ToString());
                dbContext.papers.Add(papers);
                dbContext.SaveChanges();

                return RedirectToAction("List");
                //return View(paper);
            }
            else
                ModelState.AddModelError("", "Paper Not Added!");
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpGet]

        public ActionResult Edit(int? id)
        {
            var papers = dbContext.papers.Find(id);
            return View(papers);
        }

        [HttpPost]


        public ActionResult Edit(int? id, FormCollection formCollection)
        {
            var papers = dbContext.papers.Find(id);
            if (ModelState.IsValid)
            {
                if (TryUpdateModel(papers))
                {
                    dbContext.SaveChanges();
                    return RedirectToAction("List");
                }
            }
            else
            {
                ModelState.AddModelError("", "Paper Not updated!");
            }
            return View(papers);
        }

        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Delete(int? id, FormCollection formcollection)
        {
            try
            {
                var papers = dbContext.papers.Find(id);
                dbContext.papers.Remove(papers);
                dbContext.SaveChanges();
                return RedirectToAction("List");
            }
            catch
            {
                ModelState.AddModelError("", "Paper Not deleted!");
            }
            return View();
            
        }
    }
}