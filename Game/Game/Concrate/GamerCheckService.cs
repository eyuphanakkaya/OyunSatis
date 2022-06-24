using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Abstract;
using Game.Entities;

namespace Game.Concrate
{
    public class GamerCheckService : IGamerCheckService
    {
        public bool CheckRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
