using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mazhar___Course_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Mazhar___Course_Project.Data;
using Microsoft.EntityFrameworkCore;

namespace Mazhar___Course_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController:ControllerBase
    {

           private DataContext DataContext_db {get; set;}

       public  UserController(DataContext datacontext) {
         
            this.DataContext_db = datacontext;

        }
 
        [HttpGet]
       public ActionResult<IEnumerable<User>> Get()
        {
            return DataContext_db.users;

            
        }
  [HttpGet("{id}")]
 public ActionResult<User> Get(int id)
        {
           // return "value";
         return DataContext_db.users.FirstOrDefault(x => x.id == id);
          // return DataContext_db.users.Find(id);
        }

        // GET api/values/5
      //  [HttpGet("{id}")]
     //   public ActionResult<string> Get(double id)
      //  {
           // return "value";
       //     return DataContext_db.users.Find(id).Result();
     //   }

        // POST api/values
        [HttpPost]
        public void Post(User user)
        {
           DataContext_db.Add(user);
           DataContext_db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] User user)
        {
            var value = DataContext_db.users.AsNoTracking().FirstOrDefault(x => x.id == id);
            if(value != null)
            {
             DataContext_db.users.Update(user);
             DataContext_db.SaveChanges();
           
            return Ok("Success");
           // OkResult="Success";
          // Console.Write("Success");
        // Ok("Success").Value = "Success";

            }
            else{

               return BadRequest("Invalid ID");
            }
     
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var value = DataContext_db.users.AsNoTracking().FirstOrDefault(x => x.id == id);
            if(value != null)
            {
             DataContext_db.users.Remove(value);
             DataContext_db.SaveChanges();
           
            return Ok("Deleted Succesfully");
        
            }
            else{

              return BadRequest("Invalid ID");
            }
        }


 [HttpPost("login")]
        public ActionResult<bool> login(LoginDTO dto)
        {
            var user = DataContext_db.users.FirstOrDefault(x =>
            x.email == dto.email
            && x.password == dto.password);

            if (user != null)
                return Ok(true);

            return BadRequest(false);
        }

                       
    }
}