using System;
using System.ComponentModel.DataAnnotations;

namespace CMDT.Domain.Models
{
    //Template -- Id_Customer_Env_releeaseDAte
   public class Tag {

        [Required(ErrorMessage = "Id Required")] 
        [StringLength(50,MinimumLength=4)]
        public string Id { get; set; }
       
        [Required(ErrorMessage = "Customer Required")] 
        [StringLength(200,MinimumLength=4)]
        public string Customer { get; set; }

        [Required(ErrorMessage = "Enviroment Required")]
        [StringLength(200,MinimumLength=3)]
        public string Environment { get; set; }

        [Required(ErrorMessage = "ReleaseDate Required")]
        public DateTime ReleaseDate { get; set; }
    }
}