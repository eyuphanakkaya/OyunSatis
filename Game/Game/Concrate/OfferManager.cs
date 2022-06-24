using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Abstract;
using Game.Entities;

namespace Game.Concrate
{
    public class OfferManager : IOffer
    {
        public void Add(Offer offer)
        {
            Console.WriteLine("Kampanya Eklendi:"+offer.OfferPrice);
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine("Kampanya Silindi:" + offer.Id);
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("Kampanya Güncellendi:" + offer.Id );
        }
    }
}
