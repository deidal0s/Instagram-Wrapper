using Droid.JSON;
using Droid.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Droid
{
    public class Droid
    {
        public HttpClient Client { get; set; }

        private CookieContainer Cookies { get; set; }

        private string Username { get; set; }

        private string Password { get; set; }

        private string AndroidId { get; set; }

        public SelfUser SelfUser { get; set; }

        public Droid(string login, string password)
        {
            AndroidId = Global.GenerateAndroidId();
            Cookies = new CookieContainer();

            var h = new HttpClientHandler();
            h.UseCookies = true;
            h.CookieContainer = Cookies;

            Client = new HttpClient(h);
            Client.DefaultRequestHeaders.Host = "i.instagram.com";
            Client.DefaultRequestHeaders.Add("ig-intended-user-id", "0");
            Client.DefaultRequestHeaders.Add("priority", "u=3");
            Client.DefaultRequestHeaders.Add("user-agent", Global.UserAgent);
            Client.DefaultRequestHeaders.Add("x-bloks-is-layout-rtl", "false");
            Client.DefaultRequestHeaders.Add("x-bloks-is-panorama-enabled", "true");
            Client.DefaultRequestHeaders.Add("x-bloks-version-id", Global.BloksVersionId);
            Client.DefaultRequestHeaders.Add("x-fb-client-ip", "True");
            Client.DefaultRequestHeaders.Add("x-fb-http-engine", "Liger");
            Client.DefaultRequestHeaders.Add("x-fb-server-cluster", "True");
            Client.DefaultRequestHeaders.Add("x-ig-android-id", AndroidId);
            Client.DefaultRequestHeaders.Add("x-ig-app-id", Global.AppId.ToString());
            Client.DefaultRequestHeaders.Add("x-ig-app-locale", "en_AU");
            Client.DefaultRequestHeaders.Add("x-ig-app-startup-country", "AU");
            Client.DefaultRequestHeaders.Add("x-ig-bandwidth-speed-kbps", new Random().Next(100, 10000).ToString());
            Client.DefaultRequestHeaders.Add("x-ig-bandwidth-totalbytes-b", new Random().Next(100000, 100000).ToString());
            Client.DefaultRequestHeaders.Add("x-ig-bandwidth-totaltime-ms", new Random().Next(100, 1000).ToString());
            Client.DefaultRequestHeaders.Add("x-ig-capabilities", Global.Capabilities);
            Client.DefaultRequestHeaders.Add("x-ig-connection-type", "WIFI");
            Client.DefaultRequestHeaders.Add("x-ig-device-id", Global.GenerateDeviceId());
            Client.DefaultRequestHeaders.Add("x-ig-device-locale", "en_AU");
            Client.DefaultRequestHeaders.Add("x-ig-family-device-id", Global.GenerateDeviceId());
            Client.DefaultRequestHeaders.Add("x-ig-mapped-locale", "en_US");
            Client.DefaultRequestHeaders.Add("x-ig-nav-chain", Global.NavChain);
            Client.DefaultRequestHeaders.Add("x-ig-timezone-offset", "36000");
            Client.DefaultRequestHeaders.Add("x-ig-www-claim", "0");
            Client.DefaultRequestHeaders.Add("x-mid", Global.Mid);
            Client.DefaultRequestHeaders.Add("x-pigeon-rawclienttime", DateTimeOffset.UtcNow.ToUnixTimeMilliseconds().ToString());
            Client.DefaultRequestHeaders.Add("x-pigeon-session-id", Global.SessionId);

            Username = login;
            Password = password;
        }

        public async Task<SharedData> GetSharedDataAsync()
        {
            var request = await Client.GetAsync("https://www.instagram.com/data/shared_data/");
            var response = await request.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SharedData>(response);
        }

        public async Task<bool> LoginAsync()
        {
            var loginData = new
            {
                jazoest = "22214",
                country_codes = new object[1]
                {
                    new
                    {
                        country_code = "61",
                        source = new string[1]
                        {
                            "default"
                        }
                    }
                },
                phone_id = Global.GenerateDeviceId(),
                enc_password = $"#PWD_INSTAGRAM:0:{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}:{Password}",
                username = Username,
                device_id = AndroidId,
                google_tokens = new object[0],
                login_attempt_count = "0",
                adid = Global.GenerateDeviceId(),
                guid = Global.GenerateDeviceId()
            };

            var body = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("signed_body", $"SIGNATURE.{JsonConvert.SerializeObject(loginData)}")
            });

            var request = await Client.PostAsync("https://i.instagram.com/api/v1/accounts/login/", body);
            var response = await request.Content.ReadAsStringAsync();

            if (request.Headers.Contains("ig-set-authorization"))
            {
                if (response.Contains("Please wait a few minutes before you try again"))
                    return false;
                else
                {
                    SelfUser = JObject.Parse(response).GetValue("logged_in_user").ToObject<SelfUser>();
                    Client.DefaultRequestHeaders.Add("Authorization", request.Headers.GetValues("ig-set-authorization").First());
                    return true;
                }
            }
            else
                return false;
        }

        public async Task<bool> UpdatePronounsAsync(string[] nouns, bool followersOnly = false)
        {
            string pronouns = "[";

            for (int i = 0; i < nouns.Count(); i++)
            {
                var noun = nouns[i];

                if (i == nouns.Count())
                    pronouns += $"\"{noun}\"";
                else
                    pronouns += $"\"{noun}\",";
            }

            pronouns = pronouns.Remove(pronouns.LastIndexOf(','));

            pronouns += "]";

            var body = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("pronouns", pronouns),
                new KeyValuePair<string, string>("is_pronouns_followers_only", followersOnly ? "on" : "off"),
                new KeyValuePair<string, string>("_uuid", Global.GenerateDeviceId()),
                new KeyValuePair<string, string>("bk_client_context", "{\"bloks_version\":\"" + Global.BloksVersionId + "\",\"styles_id\":\"facebook\"}"),
                new KeyValuePair<string, string>("bloks_versioning_id", Global.BloksVersionId)
            });

            var request = await Client.PostAsync("https://i.instagram.com/api/v1/bloks/apps/com.instagram.equity.pronouns.update_pronouns.action/", body);
            var response = await request.Content.ReadAsStringAsync();

            return request.StatusCode == HttpStatusCode.OK && !response.Contains("Oops, an error occurred.");
        }

        public async Task<bool> IsUsernameAvailableAsync(string name)
        {
            try
            {
                var data = new
                {
                    username = name,
                    _uid = SelfUser.pk,
                    __uid = Global.GenerateDeviceId()
                };

                var body = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("signed_body", $"SIGNATURE.{JsonConvert.SerializeObject(data)}")
            });

                var request = await Client.PostAsync("https://i.instagram.com/api/v1/users/check_username/", body);
                var response = await request.Content.ReadAsStringAsync();

                return request.StatusCode == HttpStatusCode.OK && response.Contains("\"available\":true");
            }
            catch
            {
                return await IsUsernameAvailableAsync(name);
            }
        }

        public async Task<bool> EditProfileAsync(string username = "", string site = "", string number = "", string name = "", string bio = "", string email = "")
        {
            var data = new
            {
                external_url = site,
                phone_number = number,
                username = username,
                first_name = name,
                biography = bio,
                email = email,
                _uid = SelfUser.pk,
                __uid = Global.GenerateDeviceId(),
                device_id = AndroidId
            };

            var body = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("signed_body", $"SIGNATURE.{JsonConvert.SerializeObject(data)}")
            });

            var request = await Client.PostAsync("https://i.instagram.com/api/v1/accounts/edit_profile/", body);

            return request.StatusCode == HttpStatusCode.OK;
        }
    }
}
