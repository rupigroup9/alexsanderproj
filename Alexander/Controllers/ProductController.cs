﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Alexander.Models;

namespace Alexander.Controllers
{
    public class ProductController : ApiController
    {
        public List<Product> Get()
        {
            Product prod = new Product();
            return prod.get_Products();
        }
    }
}
