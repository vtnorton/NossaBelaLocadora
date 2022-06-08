<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.API.Controllers
{
    class Class2
    {
=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Locadora.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        // GET: api/Serie
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Serie/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Serie
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Serie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
>>>>>>> c33975fd5d68d7567c480417215fb52e41dcb98f
    }
}
