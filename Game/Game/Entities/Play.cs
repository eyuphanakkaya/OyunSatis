using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    public class Play:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
