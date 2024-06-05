using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dropouts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        private readonly OracleDataAccess _oracleDataAccess;

       
        public ValuesController( IConfiguration configuration, OracleDataAccess oracleDataAccess)
        {
          
            _configuration = configuration;
            _oracleDataAccess = oracleDataAccess;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public void InsertData()
        {
            var cj = _configuration.GetConnectionString("cj");
            OracleConnection con = new OracleConnection(cj);

            con.Open();
            OracleCommand cmd11 = new OracleCommand("select distinct i.id_et,e.nom_et,e.pnom_et from esp_inscription i, esp_etudiant e where i.id_et=e.id_et and i.id_et like '223AMT%' ", con);

            cmd11.ExecuteNonQuery();
        }


        [HttpGet]
        public IActionResult PostData(string data)
        {
            try
            {
               InsertData();
                return Ok("Data inserted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
