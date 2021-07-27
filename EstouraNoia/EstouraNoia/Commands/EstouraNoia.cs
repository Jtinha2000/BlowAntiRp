using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.Core.Logging;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Provider;
using SDG.Framework;
using Rocket.Core;
using SDG.Unturned;
using Rocket.API.Collections;
using Rocket.Unturned.Events;
using System.Collections;
using UnityEngine;

namespace EstouraNoia.Commands
{
    class EstouraNoia : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Both;

        public string Name => "Estourar";

        public string Help => "Use /Estourar (nick) e estoure o noia! Plugin patrocinado pelo proerd";

        public string Syntax => "/Estourar <name>";

        public List<string> Aliases => new List<string> { "Estourar", "Explodir"};

        public List<string> Permissions => new List<string>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            if (command.Length < 1)
            {
                UnturnedChat.Say(caller, "Usa o comando direito macaco, usa: /Estourar (nick)");
                return;
            }
            UnturnedPlayer a = UnturnedPlayer.FromName(command[0]);
            Main.Instance.CooldawnStartGps(a);
        }
    }
}
