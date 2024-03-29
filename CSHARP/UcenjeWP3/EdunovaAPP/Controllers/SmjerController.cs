﻿using EdunovaAPP.Data;
using EdunovaAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace EdunovaAPP.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SmjerController
    {
        // Dependency injection
        // Definiranje privatnog svojstva
        private readonly EdunovaContext _context;

        // U konstruktoru primim instancu i dijelim privatno svojstvo
        public SmjerController(EdunovaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(_context.Smjerovi.ToList());
        }

        [HttpGet]
        [Route("{sifra:int}")]
        public IActionResult GetBySifra(int sifra)
        {
            return new JsonResult(_context.Smjerovi.Find(sifra));
        }

        [HttpPost]
        public IActionResult Post(Smjer smjer)
        {
            _context.Smjerovi.Add(smjer);
            _context.SaveChanges(); 
            return new JsonResult(smjer);
        }

        [HttpPut]
        [Route("{sifra:int}")]
        public IActionResult Put(int sifra, Smjer smjer) 
        {
            var smjerIzBaze = _context.Smjerovi.Find(sifra);
            // Za sada ručno, kasnije će doći Mapper
            smjerIzBaze.Naziv = smjer.Naziv;
            smjerIzBaze.Trajanje = smjer.Trajanje;
            smjerIzBaze.Cijena = smjer.Cijena;
            smjerIzBaze.Verificiran = smjer.Verificiran;

            _context.Smjerovi.Update(smjerIzBaze);
            _context.SaveChanges();

            return new JsonResult(smjerIzBaze);


        }

        [HttpDelete]
        [Route("{sifra:int}")]
        [Produces("application/json")]
        public IActionResult Delete(int sifra)
        {
            var smjerIzBaze = (_context.Smjerovi.Find(sifra));
            _context.Smjerovi.Remove(smjerIzBaze);
            _context.SaveChanges();
            return new JsonResult(new { poruka = "Obrisano" });
        }
    }
}
