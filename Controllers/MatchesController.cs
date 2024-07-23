using MatchdayMadness2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MatchdayMadness2.Controllers
{
    public class MatchesController : Controller
    {
        private static List<Matches> matches = new List<Matches>();
        // GET: MatchesController
        public ActionResult Index()
        {
            return View(matches);
        }

        // GET: MatchesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MatchesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MatchesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Matches newMatches)
        {
            {
                matches.Add(newMatches);
                return RedirectToAction("Index");
            }
        }

        // GET: MatchesController/Edit/5
        public ActionResult Edit(int id)
        {
            var matches1 = matches.Find(x => x.id == id);
            return View(matches1);
        }

        // POST: MatchesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Matches matchesNewData)
        {
            try
            {
                var matches1 = matches.Find(x => x.id == matchesNewData.id);
                if (matches1 != null)
                {
                    matches1.Stadium = matchesNewData.Stadium;
                    matches1.Date = matchesNewData.Date;
                    matches1.Result = matchesNewData.Result;
                    matches1.Status = matchesNewData.Status;
                    matches1.HomeTeam = matchesNewData.HomeTeam;
                    matches1.AwayTeam = matchesNewData.AwayTeam;
                }
                else
                {
                    return View();
                }
                return RedirectToAction(nameof(Index));
            }

            catch
            {
                return View();
            }
        }

        // GET: MatchesController/Delete/5
        public ActionResult Delete(int id)
        {
            var matches1 = matches.Find(x => x.id == id);
            return View(matches1);
        }

        // POST: MatchesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EXecuteDelete(int id)
        {
            try
            {
                var matches1 = matches.Find(x => x.id == id);
                if (matches1 != null)
                    matches.Remove(matches1);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
