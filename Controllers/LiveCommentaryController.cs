﻿using MatchdayMadness2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MatchdayMadness2.Controllers
{
    public class LiveCommentaryController : Controller
    {
        private static List<LiveCommentary> commentaries = new List<LiveCommentary>();
        // GET: LiveCommentaryController
        public ActionResult Index()
        {
            return View(commentaries);
        }

        // GET: LiveCommentaryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LiveCommentaryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LiveCommentaryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LiveCommentary commentary)
        {
            {
                commentaries.Add(commentary);
                return RedirectToAction("Index");
            }
        }

        // GET: LiveCommentaryController/Edit/5
        public ActionResult Edit(int id)
        {
            var comment = commentaries.Find(x => x.id == id);
            return View(comment);
        }

        // POST: LiveCommentaryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LiveCommentary commentaryNewData)
        {
            try
            {
                var comment = commentaries.Find(x => x.id == commentaryNewData.id);
                if (comment != null)
                {
                    comment.Commentator = commentaryNewData.Commentator;
                    comment.DescriptiveText = commentaryNewData.DescriptiveText;
                    comment.RealTimeUpdates = commentaryNewData.RealTimeUpdates;
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

        // GET: LiveCommentaryController/Delete/5
        public ActionResult Delete(int id)
        {
            var comment = commentaries.Find(x => x.id == id);
            return View(comment);
        }

        // POST: LiveCommentaryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ExecuteDelete(int id)
        {
            try
            {
                var comment = commentaries.Find(x => x.id == id);
                if (comment != null)
                    commentaries.Remove(comment);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
