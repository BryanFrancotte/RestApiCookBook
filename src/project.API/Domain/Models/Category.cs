using System;
using System.Collections.Generic;

namespace project.API.Domain.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public IList<Template> Templates { get; set; }
    }
}