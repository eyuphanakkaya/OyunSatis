using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Abstract;
using Game.Entities;
using Game.Concrate;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() {Name="Eyüphan",Surname="Akkaya",NationalId="1245875514",DateOfBirth=new DateTime(2000,06,03) };

            BaseGamerManager baseGamerManager = new GamerManager();
            baseGamerManager.Save(gamer);
            baseGamerManager.Update(gamer);
            baseGamerManager.Delete(gamer);





            Console.ReadKey();
        }
    }
}
