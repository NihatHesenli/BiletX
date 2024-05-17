using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Medicio_WEBSITE.Models
{
    public class Doctors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string ImgUrl { get; set; }
        [NotMapped]
        
         public IFormFile ImgFile { get; set; }

    }
}
