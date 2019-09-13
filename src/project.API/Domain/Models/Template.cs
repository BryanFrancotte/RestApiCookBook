using System;

namespace project.API.Domain.Models
{
    public class Template
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public EStatus Status { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}