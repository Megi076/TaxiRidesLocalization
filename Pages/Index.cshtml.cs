using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TaxiRidesLocalization.Data;
using TaxiRidesLocalization.Models;
using Microsoft.AspNetCore.Mvc;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    // Сите 17 колони
    public List<TaxiRide> Rides { get; set; } = new();
    public int TotalPages { get; set; }

    [BindProperty(SupportsGet = true)]
    public int page { get; set; } = 1;

    [BindProperty(SupportsGet = true)]
    public string? culture { get; set; }

    public async Task OnGetAsync()
    {
        int pageSize = 5; // Можете да го промените за да го контролирате бројот на записи на страница
        int totalCount = await _context.TaxiRides2.CountAsync();

        TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

        // Преземање на сите 17 колони
        Rides = await _context.TaxiRides2
            .OrderByDescending(r => r.pickupTime)  // Може да се прилагоди за да се сортира по друга колона
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }
}
