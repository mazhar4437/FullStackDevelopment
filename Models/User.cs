using System.ComponentModel.DataAnnotations;

namespace Mazhar___Course_Project.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
       
       [Required]
       public string name { get; set; }
       public string nationalID { get; set; }
    
      public string email { get; set; } 
    public string password { get; set; }
       public string Result()
       {

           return "<b>" + name + " " +  nationalID + "</b>";
       }
    }
}