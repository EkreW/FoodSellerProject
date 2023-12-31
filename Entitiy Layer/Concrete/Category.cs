﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy_Layer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CDescription { get; set; }
        [StringLength(250)]
        public string CategoryImageURL { get; set; }
        public bool CStatus { get; set; }

        public ICollection<Foods> Foods { get; set; }

	}
}
