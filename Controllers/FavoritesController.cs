using MatchdayMadness2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MatchdayMadness2.Controllers
{
    public class FavoritesController : Controller
    {
        private static List<Favorites> favorites = new List<Favorites>();
        // GET: FavoritesController
        public ActionResult Index()
        {
            return View(favorites);
        }

        // GET: FavoritesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FavoritesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FavoritesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Favorites newFavorite)
        {          
            
                favorites.Add(newFavorite);
                return RedirectToAction("Index");
            
        }

        // GET: FavoritesController/Edit/5
        public ActionResult Edit(int id)
        {
            var favorite1 = favorites.Find(x => x.id == id);
            return View(favorite1);
        }

        // POST: FavoritesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Favorites favoritesNewData)
        {
            try
            {
                var favorite1 = favorites.Find(x => x.id == favoritesNewData.id);
                if (favorite1 != null) 
                {
                    favorite1.FavoriteTeam = favoritesNewData.FavoriteTeam;
                    favorite1.FavoritePlayer = favoritesNewData.FavoritePlayer;
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

        // GET: FavoritesController/Delete/5
        public ActionResult Delete(int id)
        {
            var favorite1 = favorites.Find(x => x.id == id);
            return View(favorite1);
        }

        // POST: FavoritesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExecuteDelete(int id)
        {
            try
            {
                var favorite1 = favorites.Find(x => x.id == id);
                if (favorite1 != null)
                    favorites.Remove(favorite1);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
