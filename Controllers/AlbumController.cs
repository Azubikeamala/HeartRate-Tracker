

//using Microsoft.AspNetCore.Mvc;
//using AlbumApp.Entities;
//using Microsoft.EntityFrameworkCore;
//using System.Linq;
//using System.Collections.Generic;

//namespace AlbumApp.Controllers
//{
//    public class AlbumController : Controller
//    {
//        private readonly AlbumsDbContext _albumDbContext;

//        // Dependency injection
//        public AlbumController(AlbumsDbContext albumDbContext)
//        {
//            _albumDbContext = albumDbContext;
//        }

//        // List all albums
//        public IActionResult List()
//        {
//            var albums = _albumDbContext.Albums.ToList();
//            return View(albums);
//        }

//        // Items view (alternative listing)
//        public IActionResult Items()
//        {
//            var albums = _albumDbContext.Albums.ToList();
//            return View(albums);
//        }

//        // Create form (GET)
//        public IActionResult Create()
//        {
//            return View(new Album());
//        }

//        // Create new album (POST)
//        [HttpPost]
//        public IActionResult Create(Album album)
//        {
//            if (ModelState.IsValid)
//            {
//                _albumDbContext.Albums.Add(album);
//                _albumDbContext.SaveChanges();
//                return RedirectToAction("List");
//            }
//            return View(album);
//        }

//        // Edit album (GET)
//        public IActionResult Edit(int id)
//        {
//            var album = _albumDbContext.Albums.Find(id);
//            if (album is null)
//            {
//                return NotFound();
//            }
//            return View(album);
//        }

//        // Update album (POST)
//        [HttpPost]
//        public IActionResult Edit(Album album)
//        {
//            if (ModelState.IsValid)
//            {
//                _albumDbContext.Albums.Update(album);
//                _albumDbContext.SaveChanges();
//                return RedirectToAction("List");
//            }
//            return View(album);
//        }

//        // Album details
//        public IActionResult Details(int id)
//        {
//            var album = _albumDbContext.Albums.Find(id);
//            if (album is null)
//            {
//                return NotFound();
//            }
//            return View(album);
//        }

//        //// Confirm delete (GET)
//        //public IActionResult Delete(int id)
//        //{
//        //    var album = _albumDbContext.Albums.Find(id);
//        //    if (album is null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    return View(album);
//        //}
//        [HttpPost]
//        public IActionResult Delete(int id)
//        {
//            var album = _albumDbContext.Albums.Find(id);
//            if (album is not null)
//            {
//                _albumDbContext.Albums.Remove(album);
//                _albumDbContext.SaveChanges();
//            }
//            return RedirectToAction("List");
//        }


//        // Delete album (POST)
//        [HttpPost, ActionName("Delete")]
//        public IActionResult DeleteConfirmed(int id)
//        {
//            var album = _albumDbContext.Albums.Find(id);
//            if (album is not null)
//            {
//                _albumDbContext.Albums.Remove(album);
//                _albumDbContext.SaveChanges();
//            }
//            return RedirectToAction("List");
//        }
//    }
//}


using Microsoft.AspNetCore.Mvc;
using AlbumApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace AlbumApp.Controllers
{
    public class AlbumController : Controller
    {
        private readonly AlbumsDbContext _albumDbContext;

        // Dependency injection
        public AlbumController(AlbumsDbContext albumDbContext)
        {
            _albumDbContext = albumDbContext;
        }

        // List all albums
        public IActionResult List()
        {
            var albums = _albumDbContext.Albums.ToList();
            return View(albums);
        }

        // Items view (alternative listing)
        public IActionResult Items()
        {
            var albums = _albumDbContext.Albums.ToList();
            return View(albums);
        }

        // Create form (GET)
        public IActionResult Create()
        {
            return View(new Album());
        }

        // Create new album (POST)
        //[HttpPost]
        //public IActionResult Create(Album album)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _albumDbContext.Albums.Add(album);
        //        _albumDbContext.SaveChanges();
        //        return RedirectToAction("List");
        //    }
        //    return View(album);
        //}
        [HttpPost]
        public IActionResult Create(Album album)
        {
            if (ModelState.IsValid)
            {
                _albumDbContext.Albums.Add(album);
                int rowsAffected = _albumDbContext.SaveChanges(); // Ensure changes are committed

                if (rowsAffected > 0)
                {
                    TempData["Message"] = "Album added successfully!";
                }
                else
                {
                    TempData["Message"] = "Failed to add album.";
                }

                return RedirectToAction("List");
            }
            return View(album);
        }



        // Edit album (GET)
        public IActionResult Edit(int id)
        {
            var album = _albumDbContext.Albums.Find(id);
            if (album is null)
            {
                return NotFound();
            }
            return View(album);
        }

        // Update album (POST)
        [HttpPost]
        public IActionResult Edit(Album album)
        {
            if (ModelState.IsValid)
            {
                _albumDbContext.Albums.Update(album);
                _albumDbContext.SaveChanges();
                return RedirectToAction("List");
            }
            return View(album);
        }

        // Album details
        public IActionResult Details(int id)
        {
            var album = _albumDbContext.Albums.Find(id);
            if (album is null)
            {
                return NotFound();
            }
            return View(album);
        }

        // Confirm delete (GET)
        public IActionResult Delete(int id)
        {
            var album = _albumDbContext.Albums.Find(id);
            if (album is null)
            {
                return NotFound();
            }
            return View(album);
        }

        // Delete album (POST)
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var album = _albumDbContext.Albums.Find(id);
            if (album is not null)
            {
                _albumDbContext.Albums.Remove(album);
                _albumDbContext.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}

