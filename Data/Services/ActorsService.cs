using eTickets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        //data comes from db context
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = _context.Actors.FirstOrDefault(n => n.Id == id);
            _context.Actors.Remove(result);
            _context.SaveChanges();
        }

        public IEnumerable<Actor> GetAll()
        {
            var result = _context.Actors.ToList();
            return result;
        }

        public Actor GetById(int id)
        {
            var result = _context.Actors.FirstOrDefault(n => n.Id == id);
            return result;
        }

        public Actor Update(int id, Actor newActor)
        {
            _context.Update(newActor);
            _context.SaveChanges();
            return newActor;
        }
    }
}
