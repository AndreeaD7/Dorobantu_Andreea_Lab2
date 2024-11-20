using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dorobantu_Andreea_Lab2.Data;
using Dorobantu_Andreea_Lab2.Models;
using Dorobantu_Andreea_Lab2.Models.ViewModels;

namespace Dorobantu_Andreea_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Dorobantu_Andreea_Lab2.Data.Dorobantu_Andreea_Lab2Context _context;

        public IndexModel(Dorobantu_Andreea_Lab2.Data.Dorobantu_Andreea_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get; set; } = default!;
        public PublisherIndexData PublisherData { get; set; }
        public int PublisherID { get; set; }
        public int BookID { get; set; }

        public async Task OnGetAsync(int? id, int? categoryID)
        {
            PublisherData = new PublisherIndexData();
            PublisherData.Publishers = await _context.Publisher
                .Include(i => i.Books)
                    .ThenInclude(c => c.Author)
                .OrderBy(i => i.PublisherName)
                .ToListAsync();

            if (id != null)
            {
                PublisherID = id.Value;
                Publisher publisher = PublisherData.Publishers
                    .Where(i => i.ID == id.Value).Single();
                PublisherData.Books = publisher.Books;
            }
            /*Publisher = await _context.Publisher.ToListAsync();
            BookD = new BookData();

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

