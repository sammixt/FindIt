﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO
{
    public class LocalGovt
    {
        
        public int Id { get; set; }
        public int StateId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
