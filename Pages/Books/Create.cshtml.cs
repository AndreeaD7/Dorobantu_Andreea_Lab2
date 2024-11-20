using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dorobantu_Andreea_Lab2.Data;
using Dorobantu_Andreea_Lab2.Models;

namespace Dorobantu_Andreea_Lab2.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Dorobantu_Andreea_Lab2.Data.Dorobantu_Andreea_Lab2Context _context;

        public CreateModel(Dorobantu_Andreea_Lab2.Data.Dorobantu_Andreea_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["PublisherID"] = new SelectList(_context.Set<Publisher>(), "ID","PublisherName");
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
