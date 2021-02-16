using Rank.Data.Models;
using Rank.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rank.Web.Controllers
{
    public class RankedBeingController : Controller
    {
        IRankedBeingData _db;

        public RankedBeingController(IRankedBeingData db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            var rankedBeings = _db.GetAll();
            return View(rankedBeings);
        }

        public ActionResult Details(int id)
        {
            var rankedBeing = _db.GetSingleRankedBeing(id);
            return View(rankedBeing);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(RankedBeing rankedBeing)
        {
            _db.Add(rankedBeing);
            return Redirect("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var rankedBeing = _db.GetSingleRankedBeing(id);
            return View(rankedBeing);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Edit(RankedBeing rankedBeing)
        {
            _db.Update(rankedBeing);
            return RedirectToAction("Index");
        }
    }
}