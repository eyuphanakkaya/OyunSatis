﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;


namespace Game.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckRealPerson(Gamer gamer);
    }
}
