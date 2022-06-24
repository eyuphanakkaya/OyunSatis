using Game.Abstract;
using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Concrate
{
    public class GamerManager:BaseGamerManager
    {
        private IGamerCheckService gamerCheckService;

        public override void Save(Gamer gamer)
        {
            if (gamerCheckService.CheckRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("Gerçek Kişi Değil");
            }
            
            
        }
        public override void Delete(Gamer gamer)
        {
            if (gamerCheckService.CheckRealPerson(gamer))
            {
                base.Delete(gamer);
            }
            else
            {
                throw new Exception("Gerçek Kişi Değil");
            }
        }
        public override void Update(Gamer gamer)
        {
            if (gamerCheckService.CheckRealPerson(gamer))
            {
                base.Update(gamer);
            }
            else
            {
                throw new Exception("Gerçek Kişi Değil");
            }
            
        }
    }
}
