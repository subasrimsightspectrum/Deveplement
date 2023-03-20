using ATSAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCoreWithEF.Context;
using WebApiCoreWithEF.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ATSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        // GET: api/<PostsController>
        private AngularContext _context;
        private readonly IUserdetails Userdetails;

        public PostsController(AngularContext context, IUserdetails Userdetails)
        {
            _context = context;
            this.Userdetails = Userdetails;
        }
        [HttpGet]
        public IEnumerable<UserDetails> Get()
        {
            return _context.Users;
            //return user;  
        }

        //public async Task<IEnumerable<UserDetails>> GetAsync()
        //{
        //    var camera = await this.Userdetails.;
        //    return _context.Users;
        //}

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PostsController>
        [HttpPost]
        public void Post([FromBody] UserDetails userDetail)
        {
            _context.Users.Add(userDetail);
            _context.SaveChanges();
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserDetails userDetail)
        {
            var user = _context.Users.FirstOrDefault(s => s.UserId == id);
            if (user != null)
            {
                _context.Entry<UserDetails>(user).CurrentValues.SetValues(userDetail);
                _context.SaveChanges();
            }
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var user = _context.Users.FirstOrDefault(s => s.UserId == id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }
}
