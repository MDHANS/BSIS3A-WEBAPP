using System.Collections.Generic;
using bsisweb_app.Data;
using bsisweb_app.Models;
using bsisweb_app.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace bsisweb_app.Controllers
{
    public class TypeController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public TypeViewModel TypeVM { get; set; }

        public TypeController(ApplicationDbContext db)
        {
            _db = db;

            TypeVM = new TypeViewModel()
            {
                Items = _db.Items.ToList(),
                Type = new Models.Type()
            };
        }

        [HttpGet]
        public IActionResult Index()
        {
            var type = _db.Types.Include(m=>m.Item);
            return View(type);
        }
    }
}