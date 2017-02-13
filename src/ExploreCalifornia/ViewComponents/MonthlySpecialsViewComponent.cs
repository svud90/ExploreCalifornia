using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.ViewComponents
{
    [ViewComponent]
    public class MonthlySpecialsViewComponent : ViewComponent
    {
        private readonly SpecialsDataContext _db;
        public MonthlySpecialsViewComponent(SpecialsDataContext db)
        {
            _db = db;
        }

        public IViewComponentResult Invoke()
        {
            var specials = _db.GetMonthlySpecials(3);
            return View(specials);
        }
    }
}
