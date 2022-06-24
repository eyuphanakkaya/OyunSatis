using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.Abstract
{
    public interface IOffer
    {
        void Add(Offer offer);
        void Delete(Offer offer);
        void Update(Offer offer);



    }
}
