using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    public class Gamer:IEntity
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Surname { get; set; }
        public string NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
