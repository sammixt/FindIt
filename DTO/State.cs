using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
   public class State
    {
        
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
