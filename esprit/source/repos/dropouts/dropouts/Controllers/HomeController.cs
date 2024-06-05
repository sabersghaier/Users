using System.Collections.Generic;
using System.Linq;
using dropouts;
using dropouts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/[controller]")]
public class HomeController : ControllerBase
{
    private readonly dbtestContext _dbContext;

    public HomeController(dbtestContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpGet]
    public IEnumerable<InscriArchiv> Get_inscri_archive()
    {
        return _dbContext.InscriArchivs.ToList();
    }

    //[HttpGet]
    //public IEnumerable<EspInscription> GetEspInscriptionss()
    //{
    //    return _dbContext.EspInscriptions.Where(x => x.IdEt.Equals("223AMT3850")).ToList();
    //}


    [HttpGet("{id}")]
    public List<EspInscription>? GetEspInscriptionsById(string id)
    {
        var result= (from x in _dbContext.EspInscriptions where x.IdEt.Equals(id) select x).ToList();
    
        if (result == null)
        {
           // return NotFound();
        }
        return result;
    }
    [HttpGet("{id}/{annee}/getId_Annee")]
    public List<EspInscription>? GetEspInscriptionsById(string id, string annee)
    {
        var EspInscriptions = _dbContext.EspInscriptions.Where(x => x.IdEt.Equals(id) && x.AnneeDeb.Equals(annee)).ToList();
        if (EspInscriptions == null)
        {
           // return NotFound();
        }
        return EspInscriptions;
    }
    [HttpGet("{id2}/getAlllikes")]
    public List<EspInscription>? GetlikeById(string id2)
    {
        var result = (from x in _dbContext.EspInscriptions where x.IdEt.Contains(id2) select x).ToList();

        if (result == null)
        {
            // return NotFound();
        }
        return result;
    }

    //[HttpPost]
    //public ActionResult<EspInscription> CreateEspInscriptions([FromBody] EspInscription EspInscriptions)
    //{
    //    _dbContext.EspInscriptions.Add(EspInscriptions);
    //    _dbContext.SaveChanges();
    //    return CreatedAtAction(nameof(GetEspInscriptionsById), new { id = EspInscriptions.IdEt }, EspInscriptions);
    //}

    //[HttpPut("{id}")]
    //public IActionResult UpdateEspInscriptions(int id, [FromBody] EspInscription updatedEspInscriptions)
    //{
    //    var EspInscriptions = _dbContext.EspInscriptions.Find(id);
    //    if (EspInscriptions == null)
    //    {
    //        return NotFound();
    //    }

    //    EspInscriptions.TypeInsc = updatedEspInscriptions.TypeInsc;
    //    _dbContext.SaveChanges();
    //    return NoContent();
    //}

    //[HttpDelete("{id}")]
    //public IActionResult DeleteEspInscriptions(int id)
    //{
    //    var EspInscriptions = _dbContext.EspInscriptions.Find(id);
    //    if (EspInscriptions == null)
    //    {
    //        return NotFound();
    //    }

    //    _dbContext.EspInscriptions.Remove(EspInscriptions);
    //    _dbContext.SaveChanges();
    //    return NoContent();
    //}
}
