using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PropertyRenumbering.Data;
using PropertyRenumbering.Dto;
using PropertyRenumbering.Models;

namespace PropertyRenumbering.Controllers
{
    public class PropertyRegistrationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PropertyRegistrationController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PropertyRegistration
        public IActionResult Index()
        {
            //var applicationDbContext = _context.PropertyRegistration.Include(p => p.allocationType).Include(p => p.landUse).Include(p => p.locality).Include(p => p.propertyType).Include(p => p.LandUseTypeId);
            //return View(await applicationDbContext.ToListAsync());

            var query = from a in _context.PropertyRegistration
                        join b in _context.PropertyTypes on a.PropertyTypeId equals b.PropertyTypeId into bGroup
                        from b in bGroup.DefaultIfEmpty()
                        join c in _context.Localities on a.LocalityId equals c.LocalityId into cGroup
                        from c in cGroup.DefaultIfEmpty()
                        join d in _context.LandUses on a.LandUseId equals d.LandUseId into dGroup
                        from d in dGroup.DefaultIfEmpty()
                        join e in _context.LandUseTypes on a.LandUseTypeId equals e.LandUseTypeId into eGroup
                        from e in eGroup.DefaultIfEmpty()
                        join f in _context.AllocationTypes on a.AllocationTypeId equals f.AllocationTypeId into fGroup
                        from f in fGroup.DefaultIfEmpty()
                        //where a.LocalityId == 6
                        select new PropertyRegistrationReadDto
                        {
                            NewPropertyNumber = a.NewPropertyNumber,
                            OldPropertyNumber = a.OldPropertyNumber,
                            CustomerName = a.CustomerName,
                            PropertyType = b.PropertyTypes,
                            Locality = c.LocalityName,
                            LandUse = d.LandUseName,
                            LandUseType = e.LandUseTypeName,
                            AllocationType = f.AllocationTypes,
                            BlockNumber = a.BlockNumber,
                            PlotNumber = a.PlotNumber
                        };



            return View(query);
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
            ViewData["OldPropertyNumber"] = new SelectList(_properties, "OldPropertyNumber", "CustomerName");

            return View();
        }

        // GET: PropertyRegistration/C10
        public IActionResult CThree()
        {
            ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypes");
            ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseName");
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityName");
            ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes");
            ViewData["BlockId"] = new SelectList(_context.Blocks, "BlockId", "Block");


            var _landusetypes = new List<LandUseType>();
            ViewData["LandUseTypeId"] = new SelectList(_landusetypes, "LandUseTypeId", "LandUseTypeName");

            var _properties = new List<ExistingDetails>();
            ViewData["OldPropertyNumber"] = new SelectList(_properties, "OldPropertyNumber", "CustomerName");

            return View();
        }


        // GET: PropertyRegistration/C10
        public IActionResult CTen()
        {
            ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypes");
            ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseName");
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityName");
            ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes");
            ViewData["BlockId"] = new SelectList(_context.Blocks, "BlockId", "Block");


            var _landusetypes = new List<LandUseType>();
            ViewData["LandUseTypeId"] = new SelectList(_landusetypes, "LandUseTypeId", "LandUseTypeName");

            var _properties = new List<ExistingDetails>();
            ViewData["OldPropertyNumber"] = new SelectList(_properties, "OldPropertyNumber", "CustomerName");

            return View();
        }

        public IActionResult CEleven()
        {
            ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypes");
            ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseName");
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityName");
            ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes");
            ViewData["BlockId"] = new SelectList(_context.Blocks, "BlockId", "Block");


            var _landusetypes = new List<LandUseType>();
            ViewData["LandUseTypeId"] = new SelectList(_landusetypes, "LandUseTypeId", "LandUseTypeName");

            var _properties = new List<ExistingDetails>();
            ViewData["OldPropertyNumber"] = new SelectList(_properties, "OldPropertyNumber", "CustomerName");

            return View();
        }

        public IActionResult CTwelve()
        {
            ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypes");
            ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseName");
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityName");
            ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes");
            ViewData["BlockId"] = new SelectList(_context.Blocks, "BlockId", "Block");


            //var _landusetypes = new List<LandUseType>();
            //ViewData["LandUseTypeId"] = new SelectList(_landusetypes, "LandUseTypeId", "LandUseTypeName");

            //var _properties = new List<ExistingDetails>();
            //ViewData["OldPropertyNumber"] = new SelectList(_properties, "OldPropertyNumber", "CustomerName");

            return View();
        }

        public IActionResult CFifteen()
        {
            ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypes");
            ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseName");
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityName");
            ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes");
            ViewData["BlockId"] = new SelectList(_context.Blocks, "BlockId", "Block");


            //var _landusetypes = new List<LandUseType>();
            //ViewData["LandUseTypeId"] = new SelectList(_landusetypes, "LandUseTypeId", "LandUseTypeName");

            //var _properties = new List<ExistingDetails>();
            //ViewData["OldPropertyNumber"] = new SelectList(_properties, "OldPropertyNumber", "CustomerName");

            return View();
        }


        public IActionResult CSixteen()
        {
            ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypes");
            ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseName");
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityName");
            ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes");
            ViewData["BlockId"] = new SelectList(_context.Blocks, "BlockId", "Block");


            //var _landusetypes = new List<LandUseType>();
            //ViewData["LandUseTypeId"] = new SelectList(_landusetypes, "LandUseTypeId", "LandUseTypeName");

            //var _properties = new List<ExistingDetails>();
            //ViewData["OldPropertyNumber"] = new SelectList(_properties, "OldPropertyNumber", "CustomerName");

            return View();
        }

        public IActionResult Kpone()
        {
            ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypes");
            ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseName");
            ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityName");
            ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes");
            ViewData["BlockId"] = new SelectList(_context.Blocks, "BlockId", "Block");


            var _landusetypes = new List<LandUseType>();
            ViewData["LandUseTypeId"] = new SelectList(_landusetypes, "LandUseTypeId", "LandUseTypeName");

            var _properties = new List<ExistingDetails>();
            ViewData["OldPropertyNumber"] = new SelectList(_properties, "OldPropertyNumber", "CustomerName");

            return View();
        }
        public List<LandUseType> LandUseTypes(int landuseid)
        {
            List<LandUseType> landUseTypes = new List<LandUseType>();

            landUseTypes = _context.LandUseTypes.Where(l => l.LandUseId == landuseid).ToList();
            return landUseTypes;
        }


        public List<ExistingDetails> ExistingDetails(string block, int localityId)
        {
            List<ExistingDetails> details = new List<ExistingDetails>();

            var eblock = $"/{block}/";
            //&& e.OldPropertyNumber!.Contains("RP")
            details = _context.ExistingDetails.Where(e => e.Renumbered == 0  && e.LocalityId == localityId && e.OldPropertyNumber!.Contains(eblock)).ToList();
            return details;
        }

        public List<ExistingDetails> C10_ExistingDetails(string block, int localityId)
        {
            List<ExistingDetails> details = new List<ExistingDetails>();

            var eblock = $"{block}/";

            details = _context.ExistingDetails.Where(e => e.Renumbered == 0 && e.LocalityId == localityId && e.OldPropertyNumber!.Contains(eblock)).ToList();
            return details;
        }

        public ExistingDetails CustomerName(string propertyNumber)
        {
            ExistingDetails? details = _context.ExistingDetails.Where(e => e.OldPropertyNumber == propertyNumber).SingleOrDefault();
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
        //public async Task<IActionResult> Create([Bind] PropertyRegistration propertyRegistration)
        public async Task<IActionResult> Create([FromForm] PropertyRegistration propertyRegistration)
        {
            try 
            {
                if (ModelState.IsValid)
                {
                    _context.Add(propertyRegistration);

                    var existingData = await _context.ExistingDetails.FirstOrDefaultAsync(p => p.OldPropertyNumber == propertyRegistration.OldPropertyNumber);
                    existingData!.Renumbered = 1;

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Create));
                }
                //ViewData["AllocationTypeId"] = new SelectList(_context.AllocationTypes, "AllocationTypeId", "AllocationTypes");
                //ViewData["LandUseId"] = new SelectList(_context.LandUses, "LandUseId", "LandUseName");
                //ViewData["LocalityId"] = new SelectList(_context.Localities, "LocalityId", "LocalityName");
                //ViewData["PropertyTypeId"] = new SelectList(_context.PropertyTypes, "PropertyTypeId", "PropertyTypes");
                return View(propertyRegistration);
            }
            catch(Exception ex) 
            {
                TempData["ErrorMessage"] = ex.InnerException!.Message;
                return RedirectToAction(nameof(Create));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CThree([FromForm] PropertyRegistration propertyRegistration)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(propertyRegistration);

                    var existingData = await _context.ExistingDetails.FirstOrDefaultAsync(p => p.OldPropertyNumber == propertyRegistration.OldPropertyNumber);
                    existingData!.Renumbered = 1;

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(CThree));
                }
                return View(propertyRegistration);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException!.Message;
                return RedirectToAction(nameof(CThree));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CTen([FromForm] PropertyRegistration propertyRegistration)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(propertyRegistration);

                    var existingData = await _context.ExistingDetails.FirstOrDefaultAsync(p => p.OldPropertyNumber == propertyRegistration.OldPropertyNumber);
                    existingData!.Renumbered = 1;

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(CTen));
                }
                return View(propertyRegistration);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException!.Message;
                return RedirectToAction(nameof(CTen)); 
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CEleven([FromForm] PropertyRegistration propertyRegistration)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(propertyRegistration);

                    var existingData = await _context.ExistingDetails.FirstOrDefaultAsync(p => p.OldPropertyNumber == propertyRegistration.OldPropertyNumber);
                    existingData!.Renumbered = 1;

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(CEleven));
                }
                return View(propertyRegistration);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException!.Message;
                return RedirectToAction(nameof(CEleven));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CTwelve([FromForm] PropertyRegistration propertyRegistration)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(propertyRegistration);

                    var existingData = await _context.ExistingDetails.FirstOrDefaultAsync(p => p.OldPropertyNumber == propertyRegistration.OldPropertyNumber);
                    existingData!.Renumbered = 1;

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(CTwelve));
                }
                return View(propertyRegistration);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException!.Message;
                return RedirectToAction(nameof(CTwelve));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CFifteen([FromForm] PropertyRegistration propertyRegistration)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(propertyRegistration);

                    var existingData = await _context.ExistingDetails.FirstOrDefaultAsync(p => p.OldPropertyNumber == propertyRegistration.OldPropertyNumber);
                    existingData!.Renumbered = 1;

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(CFifteen));
                }
                return View(propertyRegistration);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException!.Message;
                return RedirectToAction(nameof(CFifteen));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CSixteen([FromForm] PropertyRegistration propertyRegistration)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(propertyRegistration);

                    var existingData = await _context.ExistingDetails.FirstOrDefaultAsync(p => p.OldPropertyNumber == propertyRegistration.OldPropertyNumber);
                    existingData!.Renumbered = 1;

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(CSixteen));
                }
                return View(propertyRegistration);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException!.Message;
                return RedirectToAction(nameof(CSixteen));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Kpone([FromForm] PropertyRegistration propertyRegistration)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(propertyRegistration);

                    var existingData = await _context.ExistingDetails.FirstOrDefaultAsync(p => p.OldPropertyNumber == propertyRegistration.OldPropertyNumber);
                    existingData!.Renumbered = 1;

                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(CTen));
                }
                return View(propertyRegistration);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = ex.InnerException!.Message;
                return RedirectToAction(nameof(CTen));
            }
        }

        private bool PropertyRegistrationExists(string id)
        {
            return _context.PropertyRegistration.Any(e => e.NewPropertyNumber == id);
        }
    }
}
