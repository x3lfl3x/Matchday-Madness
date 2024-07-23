using MatchdayMadness2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MatchdayMadness2.Controllers
{
    public class TeamsController : Controller
    {
        private static DB _db;
        public TeamsController(DB db)
        {
            _db = db;
        }
        private static List<Teams> teams = new List<Teams>();
        // GET: TeamsController
        public ActionResult Index()
        {
            teams=_db.Teams.ToList();
            return View(teams);
        }

        // GET: TeamsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_db.Teams.Find(id));
        }

        // GET: TeamsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TeamsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Teams newTeam)
        {
            _db.Teams.Add(newTeam);
            _db.SaveChanges();
            return RedirectToAction("Index");   
        }

        // GET: TeamsController/Edit/5
        public ActionResult Edit(int id)
        {
            var teamneEdit = _db.Teams.Find(id);
            return View(teamneEdit);
        }

        // POST: TeamsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Teams teamneEdit)
        {
            try
            {
                var teamOrg = _db.Teams.Find(teamneEdit.id);
                if (teamOrg != null)
                {
                    teamOrg.Name = teamneEdit.Name;
                    teamOrg.League = teamneEdit.League;
                    teamOrg.Coach = teamneEdit.Coach;
                    teamOrg.MatchesPlayed = teamneEdit.MatchesPlayed;
                    teamOrg.Stadium = teamneEdit.Stadium;
                    teamOrg.Formation = teamneEdit.Formation;    
                    teamOrg.Wins = teamneEdit.Wins;
                    teamOrg.Loses = teamneEdit.Loses;
                    teamOrg.Draws = teamneEdit.Draws;
                    _db.SaveChanges();
                }else
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

        // GET: TeamsController/Delete/5
        public ActionResult Delete(int id)
        {
            //var team = teams.Find(x => x.id == id);
            var teamNeFshirje=_db.Teams.Find(id);
            return View(teamNeFshirje);
        }

        // POST: TeamsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExecuteDelete(int id)
        {
            try
            {
                /*var team = teams.Find(x => x.id == id);
                if (team != null)
                    teams.Remove(team);*/
                var teamNeFshirje = _db.Teams.Find(id);
                _db.Teams.Remove(teamNeFshirje);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
