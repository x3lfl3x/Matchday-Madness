using MatchdayMadness2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MatchdayMadness2.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new List<User>();
        // GET: UserController
        public ActionResult Index()
        {
            return View(users);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User newUser)
        {
            {
                users.Add(newUser);  
                return RedirectToAction("Index");
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            var user1 = users.Find(x => x.id == id);
            return View(user1);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User userNewData)
        {
            try
            {
                var user1 = users.Find(x => x.id == userNewData.id);
                if (user1 != null)
                {
                    user1.username = userNewData.username;
                    user1.email = userNewData.email;
                    user1.password = userNewData.password;
                    user1.phoneNumber = userNewData.phoneNumber;
                    user1.dateOfBirth = userNewData.dateOfBirth;
                } else
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

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            var user1 = users.Find(x => x.id == id);
            return View(user1);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExecuteDelete(int id) 
        {
            try
            {
                var user1 = users.Find(x => x.id == id);
                if (user1 != null)
                    users.Remove(user1);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
