using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        //Iactorservice - gets data from database
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }

        //creating new actor
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(
            [Bind("FullName, ProfilePictureUrl, Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Add(actor);
            return RedirectToAction(nameof(Index));

        }

        public  IActionResult Details(int id)
        {
            var actorDetails = _service.GetById(id);
            if(actorDetails == null)
            {
                return View("Not foundEmpty");
            }
            else
            {
                return View(actorDetails);
            }
        }

        //creating new actor
        public IActionResult Edit(int id)
        {
            var actorDetails = _service.GetById(id);
            if (actorDetails == null)
            {
                return View("Not found");
            }
            else
            {
                return View(actorDetails);
            }
        }

        [HttpPost]
        public IActionResult Edit(int id,
            [Bind("Id, FullName, ProfilePictureUrl, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            _service.Update(id, actor);
            return RedirectToAction(nameof(Index));

        }

        //deleting
        public IActionResult Delete(int id)
        {
            var actorDetails = _service.GetById(id);
            if (actorDetails == null)
            {
                return View("Not found");
            }
            else
            {
                return View(actorDetails);
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var actorDetails = _service.GetById(id);
            if (actorDetails == null)
            {
                return View("Not found");
            }

            _service.Delete(id);
            
            return RedirectToAction(nameof(Index));

        }
    }
}
