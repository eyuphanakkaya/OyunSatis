using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Abstract;
using Game.Entities;

namespace Game.Concrate
{
    public class PlayManager : IPlay
    {
        public void SellGame(Play play)
        {
            Console.WriteLine("Oyun Satıldı:"+ play.Name);
        }

      
    }
}
