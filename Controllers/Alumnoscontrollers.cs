using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Becas.Models;
using Becas.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Becas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlumnosController : ControllerBase
    {
        public AlumnosController ()
    {

    }
      
     [HttpGet]

     public ActionResult<List<Alumnos>> GetAll() => AlumnosServices.GetAll();
   
     [HttpGet("{Id}")]  

      public ActionResult<Alumnos> Get (int Id)
    {
       var Alumnos = AlumnosServices.Get(Id);
        if (Alumnos == null)
          
        
            return NotFound();
            return  Alumnos; 
    }
     
      [HttpPost]

      public IActionResult Create(Alumnos alumnos)   
    {
        AlumnosServices.Add(alumnos);
        return CreatedAtAction(nameof(Create), new {Id = alumnos}, alumnos);
    }
     [HttpDelete("{Id}")]

     public IActionResult   Delete(int Id)   
     {
     var alumnos = AlumnosServices.Get(Id);
     if(alumnos is null)
     return NotFound();

     AlumnosServices.Delete(Id);
     
     return NoContent();
     }
[HttpPut("{Id}")]
 public IActionResult Update(int Id, Alumnos alumnos)
{
     if(Id != alumnos.Id)
     return BadRequest();

     var existingAlumnos = AlumnosServices.Get(Id);
     if(existingAlumnos is null)
     return NotFound();

     AlumnosServices.Update(alumnos);
     return NoContent();
}
}
}