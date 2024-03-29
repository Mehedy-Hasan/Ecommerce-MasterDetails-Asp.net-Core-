﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int? CategoryId { get; set; }

        //public List<Shop> Shops { get; set; }
        //public List<OrderDetail> Orders { get; set; }
        public  Category Category { get; set; }

       
    }
}
