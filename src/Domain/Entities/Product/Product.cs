﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain.Entities;
public class Product : BaseAuditableEntity<Guid>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public int CategoryId { get; set; }
    public virtual ProductDetail ProductDetail { get; set; }
    public virtual Category Category { get; set; }
}