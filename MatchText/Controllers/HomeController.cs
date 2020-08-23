using System;
using Microsoft.AspNetCore.Mvc;
using MatchText.Models;
using MatchText.Services;

namespace MatchText.Controllers
{
    public class HomeController : Controller
    {
        private IMatchTextService _matchTextService;

        public HomeController(IMatchTextService matchTextService)
        {
            _matchTextService = matchTextService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(MatchTextModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.Matches = _matchTextService.FindMatches(model.Text, model.SubText);

            return View(model);
        }

    }
}
