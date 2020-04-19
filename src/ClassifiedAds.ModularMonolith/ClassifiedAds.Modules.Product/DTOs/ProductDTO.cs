﻿using System;

namespace ClassifiedAds.Modules.Product.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
