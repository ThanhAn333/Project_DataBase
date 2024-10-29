using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(win_project_2.Service.StartChat))]

namespace win_project_2.Service
{
    public class StartChat
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}
