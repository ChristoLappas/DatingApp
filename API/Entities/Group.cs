using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Group
    {        

        [Key]
        public string Name { get; set; }

        public ICollection<Connection> Connections { get; set; } = new List<Connection>();

        public Group(string name)
        {
            Name = name;
        }

        public Group()
        {
            
        }


    }
}