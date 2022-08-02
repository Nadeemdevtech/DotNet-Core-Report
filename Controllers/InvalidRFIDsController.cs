using ExitGateReportPanel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ExitGateReportPanel.Controllers
{
    public class InvalidRFIDsController : Controller
    {
        private readonly IConfiguration _configuration;
        public InvalidRFIDsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // GET: InvalidRFIDs
        public ActionResult Index()
        {
            InvalidRFID invalidRFID = new InvalidRFID(_configuration);
            var model = invalidRFID.Get();
            return View(model);
        }

        // GET: InvalidRFIDs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            InvalidRFID model = new InvalidRFID(_configuration);
            InvalidRFID invalidRFID = model.Find((int)id);
            if (invalidRFID == null)
            {
                return NotFound();
            }
            return View(invalidRFID);
        }

        // GET: InvalidRFIDs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InvalidRFIDs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(InvalidRFID invalidRFID)
        {
            if (ModelState.IsValid)
            {
                InvalidRFID model = new InvalidRFID(_configuration);
                model.Insert(invalidRFID);
                return RedirectToAction("Index");
            }

            return View(invalidRFID);
        }

        // GET: InvalidRFIDs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            InvalidRFID model = new InvalidRFID(_configuration);
            InvalidRFID invalidRFID = model.Find((int)id);
            if (invalidRFID == null)
            {
                return NotFound();
            }
            return View(invalidRFID);
        }

        // POST: InvalidRFIDs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(InvalidRFID invalidRFID)
        {
            if (ModelState.IsValid)
            {
                InvalidRFID model = new InvalidRFID(_configuration);
                model.Update(invalidRFID);
                return RedirectToAction("Index");
            }
            return View(invalidRFID);
        }

        // GET: InvalidRFIDs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            InvalidRFID model = new InvalidRFID(_configuration);
            InvalidRFID invalidRFID = model.Find((int)id);
            if (invalidRFID == null)
            {
                return NotFound();
            }
            return View(invalidRFID);
        }

        // POST: InvalidRFIDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InvalidRFID model = new InvalidRFID(_configuration);
            InvalidRFID invalidRFID = model.Find((int)id);
            model.Delete(invalidRFID);
            return RedirectToAction("Index");
        }
    }
}
