using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL.Services;
using BLL;

namespace PL.Util
{
    public class GameModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGameService>().To<GameService>();
           

        }
    }
}