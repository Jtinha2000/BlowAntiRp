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
    public class Main : RocketPlugin<Config>
    {
        public static Main Instance { get; set; }
        protected override void Load()
        {
            Instance = this;
        }
        public void CooldawnStartGps(UnturnedPlayer a)
        {
            StartCoroutine(WaitGps(a));
        }
        private IEnumerator WaitGps(UnturnedPlayer a)
        {
            foreach (ushort obj in Main.Instance.Configuration.Instance.AudioEffects)
            {
                EffectManager.sendEffect(obj, Provider.findTransportConnection(a.CSteamID), a.Position);
            }
            foreach (ushort obj in Main.Instance.Configuration.Instance.VisualEffects)
            {
                EffectManager.sendUIEffect(obj, (short)obj, Provider.findTransportConnection(a.CSteamID), true);
            }
            yield return new WaitForSeconds(Main.Instance.Configuration.Instance.TimeToDisappear);
            foreach (ushort obj in Main.Instance.Configuration.Instance.AudioEffects)
            {
                EffectManager.askEffectClearByID(obj, Provider.findTransportConnection(a.CSteamID));
            }
            foreach (ushort obj in Main.Instance.Configuration.Instance.VisualEffects)
            {
                EffectManager.askEffectClearByID(obj, Provider.findTransportConnection(a.CSteamID));
            }
        }
        protected override void Unload()
        {
            
        }
    }
}
