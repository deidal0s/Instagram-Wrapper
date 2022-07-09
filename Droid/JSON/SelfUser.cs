using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.JSON
{
    public class SelfUser
    {
            public long pk { get; set; }
            public string username { get; set; }
            public string full_name { get; set; }
            public bool is_private { get; set; }
            public string profile_pic_url { get; set; }
            public bool is_verified { get; set; }
            public int follow_friction_type { get; set; }
            public bool has_anonymous_profile_picture { get; set; }
            public bool can_boost_post { get; set; }
            public bool is_business { get; set; }
            public int account_type { get; set; }
            public int professional_conversion_suggested_account_type { get; set; }
            public object is_call_to_action_enabled { get; set; }
            public bool can_see_organic_insights { get; set; }
            public bool show_insights_terms { get; set; }
            public int total_igtv_videos { get; set; }
            public string reel_auto_archive { get; set; }
            public bool has_placed_orders { get; set; }
            public string allowed_commenter_type { get; set; }
            public bool has_highlight_reels { get; set; }
            public Nametag nametag { get; set; }
            public bool can_hide_category { get; set; }
            public bool can_hide_public_contacts { get; set; }
            public bool should_show_category { get; set; }
            public bool should_show_public_contacts { get; set; }
            public bool is_using_unified_inbox_for_direct { get; set; }
            public int biz_user_inbox_state { get; set; }
            public bool wa_addressable { get; set; }
            public int wa_eligibility { get; set; }
            public long interop_messaging_user_fbid { get; set; }
            public bool can_see_primary_country_in_settings { get; set; }
            public long fbid_v2 { get; set; }
            public bool allow_contacts_sync { get; set; }
            public string phone_number { get; set; }
    }

    public class Nametag
    {
        public int mode { get; set; }
        public int gradient { get; set; }
        public string emoji { get; set; }
        public int selfie_sticker { get; set; }
    }
}
