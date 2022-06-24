using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Abstract
{
    public abstract class BaseGamerManager : IGamer
    {
        public virtual
            void Delete(Gamer gamer)
        {
            Console.WriteLine("Veri Tabanından Silindi:"+gamer.Name);
        }

        public virtual
            void Save(Gamer gamer)
        {
            Console.WriteLine("Veri Tabanına Eklendi:" + gamer.Name);
        }

        public virtual
            void Update(Gamer gamer)
        {
            Console.WriteLine("Veri Tabanı Güncellendi:" + gamer.Name);
        }
    }
}
