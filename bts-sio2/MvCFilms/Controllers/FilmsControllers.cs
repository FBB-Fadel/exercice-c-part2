using Microsoft.AspNetCore.Mvc;
using MvcFilms.Models;

namespace MvcFilms.Controllers;

public class FilmsController : Controller
{
    private static readonly List<Film> films = new()
    {
        new Film { Id = 1, Titre = "Alien", Annee = 1979, Réalisateur="sam" },
        new Film { Id = 2, Titre = "Dune", Annee = 2021, Réalisateur="tom" },
        new Film { Id = 3, Titre = "Interstellar", Annee = 2014, Réalisateur="peter" },
        new Film { Id = 4, Titre = "X-men evolution", Annee = 2003, Réalisateur="professeurX"},
    };

    public IActionResult Index()
    {
        return View(films);
    }
    public IActionResult Details(int? id)
{
    var film = films.FirstOrDefault(f => f.Id == id); // Recherche du film
    
    if (film == null)
    {
        return NotFound(); 
    }
    
    return View(film); 
}
}