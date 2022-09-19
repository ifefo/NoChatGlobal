using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;

namespace NoChatGlobalRP
{
    public class NoChatGlobalRPPlugin : RocketPlugin<NoChatGlobalRPConfig>
    {
        public NoChatGlobalRPPlugin Instance;
        protected override void Load()
        {
            Instance = this;
            UnturnedPlayerEvents.OnPlayerChatted += Chat;
            Rocket.Core.Logging.Logger.Log("Mini Plugin Hecho Por Margarita#8172 - ENG HOSTING");
        }

        private void Chat(UnturnedPlayer player, ref Color color, string message, EChatMode chatMode, ref bool cancel)
        {
            if (!player.IsAdmin)
            {
                if(chatMode == EChatMode.GLOBAL & !message.Contains("/"))
                {
                    cancel = true;
                    UnturnedChat.Say(player, Configuration.Instance.mensaje, true);
                }
            }
        }

        protected override void Unload()
        {
            UnturnedPlayerEvents.OnPlayerChatted -= Chat;
        }
    }
}
