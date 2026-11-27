using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_02.Context;

namespace MVC_02.Controllers
{
    public class PlansController : Controller
    {
        private GymDBContext context = new GymDBContext();
        public async Task<IActionResult> Index()
        {
            var plans = await context.Plans.ToListAsync();
            return View(plans);
        }
    }
}
