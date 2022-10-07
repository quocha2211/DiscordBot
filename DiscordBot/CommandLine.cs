using Discord;
using Discord.Commands;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace myDiscordBot.Modules
{
    public class CommandLine : ModuleBase
    {
        [Command("Hello")]
        public async Task Hello()
        {
            await ReplyAsync("Hi! Chào mừng " + Context.Message.Author.Mention + " đến với GkzCoding. ");
        }
    }
}