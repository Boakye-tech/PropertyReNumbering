using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertyRenumbering.Data;
using PropertyRenumbering.Models;

namespace PropertyRenumbering.Controllers
{
    public class PropertyRegistration : Controller
    {
        private readonly ApplicationDbContext _context;

        public PropertyRegistration(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PropertyRegistration
        public IActionResult Index()
        {
            //var applicationDbContext = _context.PropertyRegistration.Include(p => p.allocationType).Include(p => p.landUse).Include(p => p.locality).Include(p => p.propertyType).Include(p => p.LandUseTypeId);
            //return View(await applicationDbContext.ToListAsync());
            return View();
        }

        // GET: PropertyRegistration/Details/5
        public IActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var propertyRegistration = await _context.PropertyRegistration
            //    .Include(p => p.allocationType)
            //    .Include(p => p.landUse)
            //    .Include(p => p.locality)
            //    .Include(p => p.propertyType)
            //    .FirstOrDefaultAsync(m => m.NewPropertyNumber == id);
            //if (propertyRegistration == null)
            //{
            //    return NotFound();
            //}
            //return View(propertyRegistration);

            return View();
        }

        // GET: PropertyRegistration/Create
        public IActionResult Create()
        {
            ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypes");
            ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseName");
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityName");
            ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes");
            ViewData["BlockId"] = new SelectList(_context.Blocks, "BlockId", "Block");


            var _landusetypes = new List<LandUseType>();
            ViewData["LandUseTypeId"] = new SelectList(_landusetypes, "LandUseTypeId", "LandUseTypeName");

            var _properties = new List<ExistingDetails>();
            ViewData["PropertyNumber"] = new SelectList(_properties, "PropertyNumber", "CustomerName");

            return View();
        }

        public List<LandUseType> LandUseTypes(int landuseid)
        {
            List<LandUseType> landUseTypes = new List<LandUseType>();

            landUseTypes = _context.LandUseTypes.Where(l => l.LandUseId == landuseid).ToList();
            return landUseTypes;
        }


        public List<ExistingDetails> ExistingDetails(string block)
        {
            List<ExistingDetails> details = new List<ExistingDetails>();

            var eblock = $"/{block}/";

            details = _context.ExistingDetails.Where(e => e.PropertyNumber!.Contains(eblock)).ToList();
            return details;
        }

        public ExistingDetails CustomerName(string propertyNumber)
        {
            ExistingDetails? details = _context.ExistingDetails.Where(e => e.PropertyNumber == propertyNumber).SingleOrDefault();
            return details!;
        }

        public AllocationType AllocationType(int id)
        {
            AllocationType? details = _context.AllocationTypes.Where(e => e.AllocationTypeId == id).SingleOrDefault();
            return details!;
        }

        public LandUse LandUse(int id)
        {
            LandUse? details = _context.LandUses.Where(e => e.LandUseId == id).SingleOrDefault();
            return details!;
        }

        public LandUseType LandUseType(int id)
        {
            LandUseType? details = _context.LandUseTypes.Where(e => e.LandUseTypeId == id).SingleOrDefault();
            return details!;
        }

        public Locality Locality(int id)
        {
            Locality? details = _context.Localities.Where(e => e.LocalityId == id).SingleOrDefault();
            return details!;
        }

        // POST: PropertyRegistration/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyId,PropertyTypeId,NewPropertyNumber,OldPropertyNumber,LocalityId,LandUseId,LandUseTypeId,AllocationTypeId,BlockNumber,PlotNumber")] PropertyRegistration propertyRegistration)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propertyRegistration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypes");
            ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseName");
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityName");
            ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes");
            return View(propertyRegistration);
        }

        // GET: PropertyRegistration/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertyRegistration = await _context.PropertyRegistration.FindAsync(id);
            if (propertyRegistration == null)
            {
                return NotFound();
            }
            ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypeInitial", propertyRegistration.AllocationTypeId);
            ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseInitial", propertyRegistration.LandUseId);
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityInitial", propertyRegistration.LocalityId);
            ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes", propertyRegistration.PropertyTypeId);
            return View(propertyRegistration);
        }

        // POST: PropertyRegistration/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PropertyId,PropertyTypeId,NewPropertyNumber,OldPropertyNumber,LocalityId,LandUseId,LandUseTypeId,AllocationTypeId,BlockNumber,PlotNumber")] PropertyRegistration propertyRegistration)
        {
            //if (id != propertyRegistration.NewPropertyNumber)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(propertyRegistration);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!PropertyRegistrationExists(propertyRegistration.NewPropertyNumber))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }
            //    return RedirectToAction(nameof(Index));
            //}
            //ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypeInitial", propertyRegistration.AllocationTypeId);
            //ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseInitial", propertyRegistration.LandUseId);
            //ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityInitial", propertyRegistration.LocalityId);
            //ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes", propertyRegistration.PropertyTypeId);
            //return View(propertyRegistration);
            return View();
        }

        // GET: PropertyRegistration/Delete/5
        public IActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var propertyRegistration = await _context.PropertyRegistration
            //    .Include(p => p.allocationType)
            //    .Include(p => p.landUse)
            //    .Include(p => p.locality)
            //    .Include(p => p.propertyType)
            //    .FirstOrDefaultAsync(m => m.NewPropertyNumber == id);
            //if (propertyRegistration == null)
            //{
            //    return NotFound();
            //}

            //return View(propertyRegistration);
            return View();
        }

        // POST: PropertyRegistration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var propertyRegistration = await _context.PropertyRegistration.FindAsync(id);
            if (propertyRegistration != null)
            {
                _context.PropertyRegistration.Remove(propertyRegistration);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertyRegistrationExists(string id)
        {
            return _context.PropertyRegistration.Any(e => e.NewPropertyNumber == id);
        }
    }
}
