using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Net;
using System.Net.Http.Headers;

namespace dropouts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TController> _logger;
        private readonly IConfiguration _configuration;

        public TController(ILogger<TController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet(Name = "saber")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //public void InsertData()
        //{
        //    var cj = _configuration.GetConnectionString("cj");
        //    OracleConnection con = new OracleConnection(cj);

        //    con.Open();
        //    OracleCommand cmd11 = new OracleCommand("select distinct i.id_et,e.nom_et,e.pnom_et from esp_inscription i, esp_etudiant e where i.id_et=e.id_et and i.id_et like '223AMT%' ", con);

        //    cmd11.ExecuteNonQuery();
        //}


        [HttpGet]
        public IActionResult PostData(string data)
        {
            try
            {
              //  InsertData();
                return Ok("Data inserted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }



    }
}
