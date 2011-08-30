﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Samba.Infrastructure.Data;

namespace Samba.Domain.Models.Menus
{
    public class MenuItemPriceDefinition : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PriceTag { get; set; }
    }
}