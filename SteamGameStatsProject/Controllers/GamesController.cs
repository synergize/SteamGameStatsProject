using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SteamGameStatsProject.Models;

namespace SteamGameStatsProject.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games/Stats
        public ActionResult Stats()
        {
            var stats = new Stats() {Name = "Rust"};
            return View(stats);
        }
    }
}