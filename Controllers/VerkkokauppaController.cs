using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ot9.Models;


namespace ot9.Controllers {

    [ApiController]
    [Route("api/tuotteet")]
    public class VerkkokauppaController : ControllerBase {

        [HttpGet]
        public List<TuoteTieto> Get(string max) {

            Tuotehallinta tuotehallinta = new Tuotehallinta();


            if (max != null) {

                List<TuoteTieto> lista = tuotehallinta.haeOsa(max);

                return lista;


            } else {

                List<TuoteTieto> lista = tuotehallinta.haeKaikki();

                return lista;
            }

            
        }

        [HttpGet("{id}")]
          public List<TuoteTieto> Hae(string id) {

              Tuotehallinta tuotehallinta = new Tuotehallinta();

              List<TuoteTieto> lista = tuotehallinta.haeYksi(id);

               return lista;

          }

        [HttpPost]
        public IActionResult Post([FromBody] TuoteTieto uusituote) {

            try {

                 Tuotehallinta tuotehallinta = new Tuotehallinta();

                tuotehallinta.LisaaUusi(uusituote);

                return Ok("Tuote Lisätty");

            } catch {

                return StatusCode(500);
            }

           
        }

         [HttpDelete("{id}")]
        public IActionResult Delete(int id) {

            try {

                 Tuotehallinta tuotehallinta = new Tuotehallinta();

                 tuotehallinta.Poista(id);

                return Ok("Tuote poistettu");

            } catch {

                return StatusCode(500);
            }

           
        }

    }
}

