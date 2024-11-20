using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dorobantu_Andreea_Lab2.Data;
using Dorobantu_Andreea_Lab2.Models;

namespace Dorobantu_Andreea_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Dorobantu_Andreea_Lab2.Data.Dorobantu_Andreea_Lab2Context _context;

        public IndexModel(Dorobantu_Andreea_Lab2.Data.Dorobantu_Andreea_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get; set; } //= default!;
        /*public IList<Book> Book { get; set; }
        public BookData BookD { get; set; }
        public int BookID { get; set; }
        public int CategoryID { get; set; }*/

        public async Task OnGetAsync(int? id, int? categoryID)
        {
            Publisher = await _context.Publisher.ToListAsync();
            /*BookD = new BookData();

            BookD.Books = await _context.Book
                  .Include(b => b.Publisher)
                  .Include(b => b.BookCategories)
                  .ThenInclude(b => b.Category)
                  .AsNoTracking()
                  .OrderBy(b => b.Title)
                  .ToListAsync();

            if (id != null)
            {
                BookID = id.Value;
                Book book = BookD.Books
                    .Where(i => i.ID == id.Value).Single();
                BookD.Categories = book.BookCategories.Select(s => s.Category);*/
            }
        }
    }

