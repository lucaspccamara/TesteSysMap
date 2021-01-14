using Api_SysMap.Models;
using Api_SysMap.Objects;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_SysMap.Controllers
{
    [ApiController]
    public class ApiController : Controller
    {
        [HttpPost]
        [Route("/sum")]
        public ActionResult SumRequest([FromBody] DataInput dataInput)
        {
            return Ok(new SumOutput() { sum = new Numbers().sum(dataInput.entry) });
        }

        [HttpPost]
        [Route("/avarage")]
        public ActionResult AvarageRequest([FromBody] DataInput dataInput)
        {
            return Ok(new AvarageOutput() { avarage = new Numbers().avarage(dataInput.entry) });
        }
    }
}
