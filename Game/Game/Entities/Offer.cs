using Game.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Entities
{
    public class Offer:IEntity
    {
        public int Id { get; set; }
        public string PlayId { get; set; }
        public string OfferPrice { get; set; }
    }
}
