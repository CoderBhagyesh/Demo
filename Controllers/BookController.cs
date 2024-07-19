using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AMAZONBOOKS.Models;
using AMAZONBOOKS.Data;

namespace AMAZONBOOKS.Controllers;

public class BookController : Controller 
{
    private readonly ApplicationDbContext _db;

    public BookController(ApplicationDbContext applicationDbContext)
    {
        _db = applicationDbContext;
    }
    public IActionResult Index() 
    {
        var books = _db.Books.Where(books => books.Id == 2).ToList();
        return View(books);
    }

}