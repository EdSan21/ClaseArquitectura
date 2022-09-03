using CoreModel.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaseArqComp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cliente : ControllerBase
    {
        //GET api/values/5
        [HttpGet("DatosCliente/{id}")]
        public ActionResult<string> DatosCliente(int id)
        {
            return "Datos del cliente";
        }
        //FromBody = lee estructura
        [HttpGet("EstadoDeCuenta")]
        public async Task<IActionResult> EstadoDeCuenta ([FromBody] EstadoCuenta NIT)
        {
            try
            {
                var Restultado = "El número es NIT: " + NIT.nit;
                return Ok(Restultado);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en el método: ", ex.Message);
                throw new Exception(ex.Message);
            }
            //ver URL
        }
        [Route("IngresoCliente")]
        [HttpPost]
        public async Task<ActionResult> IngresoCliente([FromBody] ModeloRProblemas modelo)
        {

        }
    }
}
