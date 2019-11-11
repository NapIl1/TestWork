using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AprioritDenysKarpenko;

namespace AprioritDenysKarpenko.Controllers
{
    public class FoldersController : Controller
    {
        private readonly IRepository repository;

        public FoldersController(IRepository repository)
        {
            this.repository = repository;
        }

        // GET: Folders/Details/5
        public async Task<ActionResult> Details(string path)
        {
            if (path == null)
            {
                path = "Creating Digital Images";
            }

            var folder = path.Split('/').Last();
            ViewBag.route = path;

            var folders = await repository.GetFoldersByNameAsync(folder);

            if (folders == null)
            {
                return HttpNotFound();
            }

            return View(folders);
        }
    }
}
