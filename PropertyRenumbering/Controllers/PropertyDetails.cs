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
    public class PropertyDetails : Controller
    {
        private readonly ApplicationDbContext _context;

        public PropertyDetails(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PropertyDetails
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PropertyDetails.Include(p => p.locality);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PropertyDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertyDetails = await _context.PropertyDetails
                .Include(p => p.locality)
                .FirstOrDefaultAsync(m => m.NewPropertyNumber == id);
            if (propertyDetails == null)
            {
                return NotFound();
            }

            return View(propertyDetails);
        }

        // GET: PropertyDetails/Create
        public IActionResult Create()
        {
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityName");
            return View();
        }

        // POST: PropertyDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PropertyId,PropertyTypeId,NewPropertyNumber,OldPropertyNumber,LocalityId,LandUseId,LandUseTypeId,Acreage,Acreage2,BlockNumber,PlotNumber,PlotSizeId,Lane,Neighbourhood,CustomerCode,LargeScale,DebtorType,GroupNumber,SellingPrice,CurrencyId,UnitsOccupied,MonthlyRent,RightOfEntry,LeasePeriodId,PropertyHeightId,UserName")] PropertyDetails propertyDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propertyDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityInitial", "LocalityName");
            return View(propertyDetails);
        }

        // GET: PropertyDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertyDetails = await _context.PropertyDetails.FindAsync(id);
            if (propertyDetails == null)
            {
                return NotFound();
            }
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityInitial", propertyDetails.LocalityId);
            return View(propertyDetails);
        }

        // POST: PropertyDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PropertyId,PropertyTypeId,NewPropertyNumber,OldPropertyNumber,LocalityId,LandUseId,LandUseTypeId,Acreage,Acreage2,BlockNumber,PlotNumber,PlotSizeId,Lane,Neighbourhood,CustomerCode,LargeScale,DebtorType,GroupNumber,SellingPrice,CurrencyId,UnitsOccupied,MonthlyRent,RightOfEntry,LeasePeriodId,PropertyHeightId,UserName")] PropertyDetails propertyDetails)
        {
            //if (id != propertyDetails.)
            //{
            //    return NotFound();
            //}

            //if (ModelState.IsValid)
            //{
            //    try
            //    {
            //        _context.Update(propertyDetails);
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!PropertyDetailsExists(propertyDetails.NewPropertyNumber))
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
            //ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityInitial", propertyDetails.LocalityId);
            //return View(propertyDetails);
            return View(); 
        }

        // GET: PropertyDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propertyDetails = await _context.PropertyDetails
                .Include(p => p.locality)
                .FirstOrDefaultAsync(m => m.NewPropertyNumber == id);
            if (propertyDetails == null)
            {
                return NotFound();
            }

            return View(propertyDetails);
        }

        // POST: PropertyDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var propertyDetails = await _context.PropertyDetails.FindAsync(id);
            if (propertyDetails != null)
            {
                _context.PropertyDetails.Remove(propertyDetails);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropertyDetailsExists(string id)
        {
            return _context.PropertyDetails.Any(e => e.NewPropertyNumber == id);
        }
    }
}
