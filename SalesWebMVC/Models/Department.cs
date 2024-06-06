using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department() { }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
