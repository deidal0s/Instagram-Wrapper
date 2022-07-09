using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Utils
{
    public static class Global
    {
        public static long AppId = 567067343352427;

        public static string BloksVersionId = "54a609be99b71e070ffecba098354aa8615da5ac4ebc1e44bb7be28e5b244972";

        public static string Capabilities = "3brTv10=";

        public static string NavChain = "9cb:self_profile:14:main_profile,ProfileMediaTabFragment:self_profile:15:button,A2w:account_switch_fragment:16:button,ProfileMediaTabFragment:self_profile:17:button,2Bk:bloks-fullscreencom.instagram.pro_home.surface:18:button,ProfileMediaTabFragment:self_profile:19:button,8jo:bottom_sheet_profile:20:button,8jo:bottom_sheet_profile:21:button,AQ1:settings_category_options:22:button";

        public static string UserAgent = "Instagram 212.0.0.38.119 Android (30/11; 420dpi; 2186x1080; samsung; SM-A525F; a52q; qcom; en_AU; 329675731)";

        public static string Mid = "Yf395gABAAFdRFpo2qsLcb_ZI3v-";

        public static string SessionId = "UFS-befc29d1-b52a-4120-a889-8b6d06252b39-1";

        public static string GenerateAndroidId()
        {
            return $"android-{RandomString(16)}";
        }

        public static string GenerateDeviceId()
        {
            string one = RandomString(8);
            string two = RandomString(4);
            string three = RandomString(4);
            string four = RandomString(4);
            string five = RandomString(12);

            return $"{one}-{two}-{three}-{four}-{five}";
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
