using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudBookSite.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CrudBookSite.Pages.BookList{
    public class IndexModel : PageModel{
        private readonly ApplicationDbContext _db;
        public IEnumerable<Book> Books {get; set;}

        public IndexModel(ApplicationDbContext db){
            _db = db;
        }
        public async Task OnGet(){
            Books = await _db.Books.ToListAsync();
        }
    }
}