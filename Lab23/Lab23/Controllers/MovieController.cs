using System.Threading.Tasks;
using Lab23.Data.Model;
using Lab23.Models;
using Lab23.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace Lab23.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _repository;

        public MovieController(IMovieRepository repository)
        {
            _repository = repository;
        }

        //Get: Movies
        public async Task<IActionResult> Index()
        {
            return View(await _repository.Get());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _repository.Get(id.Value);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }


        // GET: /<controller>/


        public IActionResult RegisterMovie()
        {
            return View("RegisterMovieView");
        }

        public IActionResult SearchView()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> RegisterMovie([Bind("Id, Title, Genre, Runtime")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                await _repository.Register(movie);
                return RedirectToAction(nameof(Index));
            }
            ModelState.AddModelError("", "Invalid Entry. Please try again.");
            return View("RegisterMovieView");
        }

        public async Task <IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movie = await _repository.Get(id.Value);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Genre,Runtime")] Movie movie)
        {
            if (id!= movie.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    await _repository.Update(movie);
                }

                catch (DbUpdateConcurrencyException)
                {
                    if(!await _repository.Exists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(movie);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _repository.Get(id.Value);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> SearchTitle(string title)
        {

            var searchtitle = await _repository.Search(title);

            return View("SearchResultTitle", searchtitle);

        }

        public async Task<IActionResult>SearchGenre(string genre)
        {
            var searchgenre = await _repository.GenreSearch(genre);
            return View("SearchResultGenre", searchgenre);
        }

        
    }
}
