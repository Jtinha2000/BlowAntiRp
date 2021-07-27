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

namespace EstouraNoia
{
    public class Config : IRocketPluginConfiguration
    {
        public float TimeToDisappear { get; set; }
        public List<ushort> AudioEffects = new List<ushort>();
        public List<ushort> VisualEffects = new List<ushort>();
        public void LoadDefaults()
        {
            TimeToDisappear = 60;
            AudioEffects.Add(4411);
            VisualEffects.Add(1144);
        }
    }
}
