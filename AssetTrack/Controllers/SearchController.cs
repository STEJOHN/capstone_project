using AssetTrack.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AssetTrack.Controllers
{
    public class SearchController : Controller
    {
        private readonly AssetTrackContext _context;

        public SearchController(AssetTrackContext context)
        {
            _context = context;
        }


        [Authorize]
        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return "From [HttpPost]Index: filter on " + searchString;
        }


        [Authorize]
        // GET: Asset
        public async Task<IActionResult> Index(string searchString)
        {
            //Using LINQ to create query 
            var assets = from t in _context.Asset
                         select t;


            if (!String.IsNullOrWhiteSpace(searchString))
            {
                assets = assets.Where(i => i.Location!.Contains(searchString) ||

                i.MSF!.Contains(searchString) ||
                i.Date!.ToString().Contains(searchString) ||
                i.User!.Contains(searchString) ||
                i.Notes!.Contains(searchString) ||
                i.PartNumber!.Contains(searchString) ||
                i.PartType!.Contains(searchString) ||
                i.SerialNumber!.Contains(searchString) ||
                i.TaskNumber!.Contains(searchString

                ));
            }


            //return View(await _context.Things.ToListAsync());
            return View(await assets.ToListAsync());
        }

    }
}
