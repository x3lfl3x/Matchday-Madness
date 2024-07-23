using MatchdayMadness2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace MatchdayMadness2.Controllers
{
    public class PlayersController : Controller
    {
        private static DB _db;
        public PlayersController(DB db)
        {
            _db = db;
        }
        // GET: PlayersController
        public ActionResult Index()
        {           
           var players=_db.Players.ToList();
            return View(players);
        }

        // GET: PlayersController/Details/5
        public ActionResult Details(int id)
        {

            var player = _db.Players.Include(x=>x.Teams).Where(x=>x.ID.Equals(id)).FirstOrDefault(x => x.ID == id);
            return View(player);
            
        }

        // GET: PlayersController/Create
        public ActionResult Create()
        {
            var teams=_db.Teams.ToList();
            var teamsSelectList = new SelectList(teams, "id", "Name");
            ViewBag.Teams = teamsSelectList;
            return View();
        }

        // POST: PlayersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Players newPlayer)
        {
            _db.Players.Add(newPlayer);
            _db.SaveChanges();
            
            return RedirectToAction("Index");
        }

        // GET: PlayersController/Edit/5
        public ActionResult Edit(int id)
        {
            var playerneEdit = _db.Players.Find(id);
            var teams = _db.Teams.ToList();
            var teamsSelectList = new SelectList(teams, "id", "Name", playerneEdit.Team_ID);
            ViewBag.Teams = teamsSelectList;
            return View(playerneEdit);
        }

        // POST: PlayersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Players playersNewData)
        {
            try
            {
                var playerOrg = _db.Players.Find(playersNewData.ID);
                if (playerOrg != null)
                {
                    playerOrg.Name = playersNewData.Name;
                    playerOrg.Age = playersNewData.Age;
                    playerOrg.Position = playersNewData.Position;
                    playerOrg.Team_ID = playersNewData.Team_ID;
                    _db.SaveChanges();
                }else 
                {
                    return View() ;
                }
                    return RedirectToAction(nameof(Index));
               
            }
            catch
            {
                return View();
            }
        }

        // GET: PlayersController/Delete/5
        public ActionResult Delete(int id)
        {
            var playerNeFshirje = _db.Players.Find(id);
            return View(playerNeFshirje);
        }

        // POST: PlayersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExecuteDelete(int id )
        {
            try
            {
                var playerNeFshirje = _db.Players.Find(id);
                _db.Players.Remove(playerNeFshirje);
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
