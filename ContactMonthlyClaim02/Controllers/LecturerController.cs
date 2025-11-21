using ContactMonthlyClaim02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class LecturerController : Controller
{
    private readonly ApplicationDbContext _context;

    public LecturerController(ApplicationDbContext context)
    {
        _context = context;
    }

    // View all claims (for tracking)
    public IActionResult ClaimTracking()
    {
        var claims = _context.Claims.ToList();
        return View(claims);
    }

    // Submit a new claim
    [HttpPost]
    public IActionResult SubmitClaim(Claim claim)

    {
        if (ModelState.IsValid)
        {
            claim.Status = "Pending";
            claim.DateSubmitted = DateTime.Now;
            _context.Claims.Add(claim);
            _context.SaveChanges();
            return RedirectToAction("ClaimTracking");
        }
        return View(claim);
    }

    // Admin/Coordinator updates claim status
    [HttpPost]
    public IActionResult UpdateClaimStatus(int id, string status)
    {
        var claim = _context.Claims.FirstOrDefault(c => c.Id == id);
        if (claim != null)
        {
            claim.Status = status;
            _context.SaveChanges();
        }

        return Json(new { success = true, newStatus = status });
    }
}


