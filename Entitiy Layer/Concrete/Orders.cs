﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy_Layer.Concrete
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }
        [StringLength(50)]
        public string OrderName { get; set; }
        [StringLength(200)]
        public string OrderDetails { get; set; }
        [StringLength(200)]
        public string Orderİmage { get; set; }
        public string OrderStatus { get; set; }

        
    }
}
