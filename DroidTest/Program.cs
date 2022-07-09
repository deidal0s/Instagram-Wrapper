using Discord.WebSocket;
using Droid.Utils;
using DroidTest.JSON;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DroidTest
{
    class Program
    {
        public static Droid.Droid droid { get; set; }
        
        public static DiscordSocketClient Client { get; set; }

        public static Stuff stuff { get; set; }

        public static Dictionary<DroidAccount, Droid.Droid> Clients = new Dictionary<DroidAccount, Droid.Droid>();

        public static List<string> proxies = new List<string>();

        static void Main(string[] args)
        {
            new Program().Start().GetAwaiter().GetResult();
        } 

        public static async Task<HttpClient> randClient()
        {
            try
            {
                HttpClientHandler h = new HttpClientHandler();
                h.Proxy = new WebProxy($"http://{proxies[new Random().Next(0, proxies.Count)]}");
                HttpClient c = new HttpClient(h);
                c.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.99 Safari/537.36");
                var req = await c.GetAsync("https://www.instagram.com/data/shared_data/");
                var response = await req.Content.ReadAsStringAsync();
                c.DefaultRequestHeaders.Add("x-csrftoken", JObject.Parse(response).GetValue("config").ToObject<JObject>().GetValue("csrf_token").ToObject<string>());
                c.DefaultRequestHeaders.Add("x-asbd-id", "198387");
                c.DefaultRequestHeaders.Add("x-ig-app-id", "936619743392459");
                return c;
            }
            catch
            {
                return await randClient();
            }
        }

        public static async Task<bool> EmailExists(string email)
        {
            try
            {
                var client = await randClient();
                var body = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("email_or_username", email),
                    new KeyValuePair<string, string>("recaptcha_challenge_field", ""),
                    new KeyValuePair<string, string>("flow", ""),
                    new KeyValuePair<string, string>("app_id", ""),
                    new KeyValuePair<string, string>("source_account_id", "")
                });
                var request = await client.PostAsync("https://www.instagram.com/accounts/account_recovery_send_ajax/", body);
                var response = await request.Content.ReadAsStringAsync();
                return response != "{\"message\":\"No users found\",\"status\":\"fail\"}";
            }
            catch
            {
                return await EmailExists(email);
            }
        }

        private async Task Start()
        {
            if (!File.Exists("Stuff.json"))
                File.WriteAllText("Stuff.json", JsonConvert.SerializeObject(new Stuff(), Formatting.Indented));

            stuff = JsonConvert.DeserializeObject<Stuff>(File.ReadAllText("Stuff.json"));

            proxies = File.ReadAllLines("Proxies.txt").ToList();

            //Client = new DiscordSocketClient();

            //Client.MessageReceived += Client_MessageReceived;
            //Client.Ready += Client_Ready;

            //await Client.StartAsync();
            //await Client.LoginAsync(Discord.TokenType.Bot, "");

            Console.Title = "Droid";

            Console.Write("Email > ");
            string user = Console.ReadLine();

            Console.Write("Pass > ");
            string pass = Console.ReadLine();

            droid = new Droid.Droid(user, pass);
            var x = await droid.LoginAsync();

            if (x)
            {
                Console.Clear();

                Console.WriteLine($"[LOG] Online on @{droid.SelfUser.username}!");

                Console.WriteLine("Type 'drop' when ready.");

                for (; ; )
                {
                    Console.Write("> ");
                    string xlol = Console.ReadLine();

                    switch (xlol)
                    {
                        case "drop":
                            Console.WriteLine("Dropped username.");
                            await droid.ReleaseUsernameAsync(user);
                            break;
                        case "check":
                            try
                            {
                                new Thread(async () =>
                                {
                                    foreach (var xacc in File.ReadAllLines("check.txt"))
                                    {
                                        new Thread(async () =>
                                        {
                                            if (await droid.IsUsernameAvailableAsync(xacc))
                                                Console.WriteLine($"[LOG] {xacc} is__available!");
                                            else
                                                Console.WriteLine($"[LOG] {xacc} not available!");
                                        }).Start();
                                    }
                                }).Start();
                            }
                            catch { }
                            break;
                        case "guess7":
                            foreach(var chara in File.ReadAllLines("check.txt"))
                            {
                                if (await EmailExists($"7{chara}.in"))
                                    Console.WriteLine($"pickpocket@7{chara}.in");
                                else
                                    Console.WriteLine($"It's not pickpocket@7{chara}.in");
                            }
                            break;
                        case "spamchange":
                            Console.WriteLine("Spam changing username.");
                            await droid.ReleaseUsernameAsync(user);
                            break;
                        case "swap":
                            break;
                        case "namechanger":
                            System.Timers.Timer timer = new System.Timers.Timer();
                            timer.Interval = 1000;
                            timer.AutoReset = true;
                            timer.Elapsed += Timer_Elapsed;
                            timer.Enabled = true;
                            Console.WriteLine("Name changer started using 14d bypass.");
                            break;
                    }
                }
            }

            await Task.Delay(-1);
        }

        private async Task Client_Ready()
        {
            Console.WriteLine("[LOG] Online");

            await Client.SetStatusAsync(Discord.UserStatus.Online);

            await Client.SetGameAsync($"Prefix: {stuff.Prefix}");
        }

        private async Task Client_MessageReceived(SocketMessage arg)
        {
            if (arg.Channel.GetType() == typeof(SocketTextChannel))
            {
                if (!arg.Content.StartsWith(stuff.Prefix))
                    return;

                var fixedwords = arg.Content.Replace(stuff.Prefix, "");
                var words = fixedwords.Split(' ');
                var command = words[0];

                switch(command.ToLower())
                {
                    case "ping":
                        Stopwatch _ = new Stopwatch();
                        _.Start();
                        var x = await arg.Channel.SendMessageAsync(".");
                        _.Stop();
                        await x.ModifyAsync(m => m.Content = $"Pong! **{_.ElapsedMilliseconds}**ms");
                        break;
                    case "add":
                        await arg.DeleteAsync();
                        await arg.Channel.SendMessageAsync($"This command is used via **direct message only!**");
                        break;
                    case "accounts":
                        if (!CanUse(arg.Author))
                            return;

                        var user = GetUser(arg.Author.Id);

                        if (user.Accounts.Count() == 0)
                            return;

                        await arg.Channel.SendMessageAsync($"You have {GetUser(arg.Author.Id).Accounts.Count} account(s) in store, to get further information type {stuff.Prefix}accountsinfo once you've run {stuff}login [index]/all");
                        break;
                    case "login":
                        if (!CanUse(arg.Author))
                            return;

                        if (words.Count() == 1)
                        {
                            await arg.Channel.SendMessageAsync($"Please specify an argument! {stuff.Prefix}login all OR {stuff.Prefix}login [INDEX]");
                            return;
                        }

                        if (words[1].ToLower() == "all")
                        {
                            user = GetUser(arg.Author.Id);

                            if (user.Accounts.Count() == 0)
                                return;

                            int count = 0;
                            foreach(var account in user.Accounts)
                            {
                                if (Clients.Where(f => f.Key.Login == account.Login).Count() > 0)
                                    break;

                                var cx = new Droid.Droid(account.Login, account.Password);
                                if (await cx.LoginAsync())
                                {
                                    count++;
                                    Clients.Add(account, cx);
                                }
                            }

                            await arg.Channel.SendMessageAsync($"Login complete. {count}/{user.Accounts.Count()} of your logins were successful.");
                        }
                        else
                        {
                            if (!int.TryParse(words[1], out int index))
                                return;

                            user = GetUser(arg.Author.Id);

                            if (user.Accounts.Count() == 0)
                                return;

                            if (user.Accounts.Count < index)
                                return;

                            var account = user.Accounts[index];

                            if (account == null)
                                return;

                            if (Clients.Where(f => f.Key.Login == account.Login).Count() > 0)
                                return;

                            var c = new Droid.Droid(account.Login, account.Password);

                            if (await c.LoginAsync())
                            {
                                Clients.Add(account, c);
                                await arg.Channel.SendMessageAsync("Login successful, your account is now ready.");
                            }
                        }
                        break;
                    case "accountsinfo":
                        if (!CanUse(arg.Author))
                            return;

                        user = GetUser(arg.Author.Id);

                        if (user.Accounts.Count() == 0)
                            return;

                        Dictionary<DroidAccount, Droid.Droid> localAccs = new Dictionary<DroidAccount, Droid.Droid>();

                        foreach(var ff in Clients.Keys)
                        {
                            foreach(var ffv in Clients.Values)
                            {
                                foreach (var ff2 in user.Accounts)
                                {
                                    if (ff.Login == ff2.Login && ff.Password == ff2.Password)
                                        localAccs.Add(ff, ffv);
                                }
                            }
                        }

                        if (localAccs.Count() == 0)
                            return;

                        string message = $"You have {localAccs.Values.Count()} account(s) online! Their usernames are;\n";

                        foreach(var xlol in localAccs.Values)
                        {
                            message += xlol.SelfUser.username + "\n";
                        }

                        await arg.Channel.SendMessageAsync(message);
                        break;
                    case "pronouns":
                        if (!CanUse(arg.Author))
                            return;

                        if (words.Count() == 1)
                        {
                            await arg.Channel.SendMessageAsync($"Please specify an argument! E.g {stuff.Prefix}pronouns she/her/they");
                            return;
                        }

                        user = GetUser(arg.Author.Id);

                        if (user.Accounts.Count() == 0)
                            return;

                        localAccs = new Dictionary<DroidAccount, Droid.Droid>();

                        foreach (var ff in Clients.Keys)
                        {
                            foreach (var ffv in Clients.Values)
                            {
                                foreach (var ff2 in user.Accounts)
                                {
                                    if (ff.Login == ff2.Login && ff.Password == ff2.Password)
                                        localAccs.Add(ff, ffv);
                                }
                            }
                        }

                        if (localAccs.Count() == 0)
                            return;

                        var nouns = words[1].Split('/');

                        if (nouns.Length == 0)
                            return;

                        List<string> wow = new List<string>(nouns);

                        int success = 0;
                        foreach(var acc in localAccs.Values)
                        {
                            if (await acc.UpdatePronounsAsync(wow.ToArray(), false))
                                success++;
                        }

                        await arg.Channel.SendMessageAsync($"Pronouns update complete. {success}/{localAccs.Values.Count} account(s) pronoun's were updated.");
                        break;
                    case "name":
                        if (!CanUse(arg.Author))
                            return;

                        if (words.Count() == 1)
                        {
                            await arg.Channel.SendMessageAsync($"Please specify an argument! E.g {stuff.Prefix}name test");
                            return;
                        }

                        user = GetUser(arg.Author.Id);

                        if (user.Accounts.Count() == 0)
                            return;

                        localAccs = new Dictionary<DroidAccount, Droid.Droid>();

                        foreach (var ff in Clients.Keys)
                        {
                            foreach (var ffv in Clients.Values)
                            {
                                foreach (var ff2 in user.Accounts)
                                {
                                    if (ff.Login == ff2.Login && ff.Password == ff2.Password)
                                        localAccs.Add(ff, ffv);
                                }
                            }
                        }

                        if (localAccs.Count() == 0)
                            return;

                        int sx = 0;
                        foreach(var a in localAccs.Values)
                        {
                            if (await a.ChangeNameBypass(words[1]))
                                sx++;
                        }

                        await arg.Channel.SendMessageAsync($"Name update complete. {sx}/{localAccs.Values.Count} account(s) name's were updated.");
                        break;
                }
            }
            else if (arg.Channel.GetType() == typeof(SocketDMChannel))
            {
                if (!arg.Content.StartsWith(stuff.Prefix))
                    return;

                var fixedwords = arg.Content.Replace(stuff.Prefix, "");
                var words = fixedwords.Split(' ');
                var command = words[0];

                switch(command.ToLower())
                {
                    case "add":
                        if (words.Count() < 2)
                        {
                            await arg.Channel.SendMessageAsync($"Invalid usage! Correct usage: {stuff.Prefix}add [login] [password]");
                            return;
                        }

                        if (!CanUse(arg.Author))
                            return;

                        var username = words[1]; 
                        var password = words[2];
                        var user = GetUser(arg.Author.Id);

                        if (HasAcc(user, username))
                            return;

                        GetUser(arg.Author.Id).Accounts.Add(new DroidAccount()
                        {
                            Login = username,
                            Password = password
                        });

                        File.WriteAllText("Stuff.json", JsonConvert.SerializeObject(stuff, Formatting.Indented));

                        await arg.Channel.SendMessageAsync("Account added.");
                        break;
                    case "start":
                        if (CanUse(arg.Author))
                            return;

                        stuff.Users.Add(new DroidUser()
                        {
                            DiscordId = arg.Author.Id,
                            Username = arg.Author.Username,
                            PlanType = 1,
                            WhitelistDate = DateTime.Now.ToShortDateString(),
                            Accounts = new List<DroidAccount>()
                        });

                        File.WriteAllText("Stuff.json", JsonConvert.SerializeObject(stuff, Formatting.Indented));

                        await arg.Channel.SendMessageAsync($"Your profile has been setup. Type {stuff.Prefix}help to see a list of commands you can use.");
                        break;
                }
            }
        }

        public bool CanUse(SocketUser user)
        {
            return stuff.Users.Where(x => x.DiscordId == user.Id).Count() != 0;
        }

        public bool HaveAccounts(SocketUser user)
        {
            if (!CanUse(user))
                return false;

            if (stuff.Users.First(x => x.DiscordId == user.Id).Accounts.Count > 0)
                return true;

            return false;
        }

        public DroidUser GetUser(ulong id)
        {
            return stuff.Users.First(x => x.DiscordId == id);
        }

        public bool HasAcc(DroidUser user, string login)
        {
            return user.Accounts.Where(x => x.Login == login).Count() != 0;
        }

        private async void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            List<string> pronounChoices = new List<string>()
            {
                "he",
                "she",
                "co",
                "they",
                "them",
                "hers",
                "his",
                "ze",
                "zir",
                "zem",
                "xe",
                "xer",
                "xem"
            };

            List<string> names = new List<string>()
            {
                "i am god",
                "i hate minorities",
                "never gonna give you up",
                "never gonna let you down",
                "walking around with no hands",
                "jst like you 4 the image",
                "yuh yuh yuh",
                "t.me/methane",
                "t.me/fellahs",
                "@fellahs on tg",
                "i do tele swaps",
                "hmu about swaps",
                "hmu about ogs on tele",
                "balling claimer on top",
                "fuck yo claimer nigga",
                "niggas are awesome",
                "just kiddin they aint",
                "this ones 4 us brah",
                "we're all gonna make it"
            };

            List<string> pronouns = new List<string>();

            for(var i = 0; i < 5; i++)
            {
                var pronoun = pronounChoices[new Random().Next(0, pronouns.Count)];
                pronouns.Add(pronoun);
            }

            //await droid.UpdatePronounsAsync(pronouns.ToArray(), false);
            var name = names[new Random().Next(0, names.Count())];
            await droid.ChangeNameBypass(name);
            Console.WriteLine($"[LOG] Name changed to {name}");
        }
    }
}
