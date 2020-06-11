﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Shared.Models;

namespace Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        // GET: api/<TrainerController>
        [HttpGet]
        public IEnumerable<Trainer> Get()
        {
            // do getting
            return new Trainer[] { new Trainer(), new Trainer() };
        }

        // GET api/<TrainerController>/5
        [HttpGet("{id}")]
        public Trainer Get(int id)
        {
            // do getting
            return new Trainer();
        }

        // POST api/<TrainerController>
        [HttpPost]
        public ActionResult Post([FromBody] string name)
        {
            // do creating
            return Ok($"Trainer {name} created.");
        }

        // PUT api/<TrainerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            // do updating
            return Ok($"Trainer {id} updated.");
        }

        // DELETE api/<TrainerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            // do deleting...
            return Ok($"Trainer {id} delted.");
        }
    }
}