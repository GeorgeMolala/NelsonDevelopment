using Microsoft.AspNetCore.Mvc;
using NelsonDevelopment.DataLayer.Helper_Classes;
using NelsonDevelopment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NelsonDevelopment.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class StringConverterController : Controller
    {
        private readonly IDataProcessor _proc;

        public StringConverterController(IDataProcessor proc)
        {
            _proc = proc;
        }


        [HttpPost]
        public async Task<IActionResult> Index([FromBody] SortData sortData)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sortData?.Data))
                {
                    return BadRequest(new { error = "The 'data' field must not be empty." });
                }

                var res = await _proc.GetProcessedData(sortData.Data.ToLower());
                return Ok(res);
            }
            catch(Exception er)
            {
                return StatusCode(500, "An unexpected error occurred");
            }
           
        }
    }
}
