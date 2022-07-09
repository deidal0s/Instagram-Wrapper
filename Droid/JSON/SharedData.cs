using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.JSON
{

    public class SharedData
    {
        public Config config { get; set; }
        public string country_code { get; set; }
        public string language_code { get; set; }
        public string locale { get; set; }
        public Entry_Data entry_data { get; set; }
        public string hostname { get; set; }
        public bool is_whitelisted_crawl_bot { get; set; }
        public string connection_quality_rating { get; set; }
        public string deployment_stage { get; set; }
        public string platform { get; set; }
        public string nonce { get; set; }
        public float mid_pct { get; set; }
        public Zero_Data zero_data { get; set; }
        public int cache_schema_version { get; set; }
        public Server_Checks server_checks { get; set; }
        public Knobx knobx { get; set; }
        public To_Cache to_cache { get; set; }
        public string device_id { get; set; }
        public string browser_push_pub_key { get; set; }
        public Encryption encryption { get; set; }
        public bool is_dev { get; set; }
        public bool is_on_vpn { get; set; }
        public Signal_Collection_Config signal_collection_config { get; set; }
        public Consent_Dialog_Config consent_dialog_config { get; set; }
        public object privacy_flow_trigger { get; set; }
        public Www_Routing_Config www_routing_config { get; set; }
        public string rollout_hash { get; set; }
        public string bundle_variant { get; set; }
        public string frontend_env { get; set; }
    }

    public class Config
    {
        public string csrf_token { get; set; }
        public Viewer viewer { get; set; }
        public string viewerId { get; set; }
    }

    public class Viewer
    {
        public string biography { get; set; }
        public object business_address_json { get; set; }
        public string business_contact_method { get; set; }
        public object business_email { get; set; }
        public object business_phone_number { get; set; }
        public bool can_see_organic_insights { get; set; }
        public string category_name { get; set; }
        public string external_url { get; set; }
        public string fbid { get; set; }
        public string full_name { get; set; }
        public bool has_phone_number { get; set; }
        public bool has_profile_pic { get; set; }
        public bool has_tabbed_inbox { get; set; }
        public bool hide_like_and_view_counts { get; set; }
        public string id { get; set; }
        public bool is_business_account { get; set; }
        public bool is_joined_recently { get; set; }
        public bool is_private { get; set; }
        public bool is_professional_account { get; set; }
        public string profile_pic_url { get; set; }
        public string profile_pic_url_hd { get; set; }
        public bool should_show_category { get; set; }
        public bool should_show_public_contacts { get; set; }
        public string username { get; set; }
        public string badge_count { get; set; }
    }

    public class Entry_Data
    {
    }

    public class Zero_Data
    {
    }

    public class Server_Checks
    {
        public bool hfe { get; set; }
    }

    public class Knobx
    {
        public bool _070bc16ba2d873c073001690561934e3 { get; set; }
        public int _086c12b43fda5eee54ed0fa85f2bbea8 { get; set; }
        public bool _17aeb9de94ea257e02570f12cdb2812f { get; set; }
        public bool _27e1c3d9ed3e05886fb474b960e3baa4 { get; set; }
        public bool _3c50bdecc6078abf9e53f13d9246d9e2 { get; set; }
        public bool _417a8e79ba5d5da0284a8efb2178791a { get; set; }
        public bool _5a00d32f3b18ef1b85a8d6af5be1ad47 { get; set; }
        public bool _5f14c608e32ae0b85932fb93091c4546 { get; set; }
        public bool _624aa9c15ed32e7d96b314f2b37a95b4 { get; set; }
        public bool _87084edfc1b9d02c4cdfa207310404fc { get; set; }
        public bool _87cabcd3ff134aea43e9d0eb09f3f1d4 { get; set; }
        public bool _905928c49b2e06c084709ec4bda214ee { get; set; }
        public bool _989a9524772f4eea9e1ec5b9e4ae8230 { get; set; }
        public bool _9f97772ac84b15c6fa35b21d0ea0ea6b { get; set; }
        public bool a64bf3b237e8c66b16b48dff7938337a { get; set; }
        public bool b3b101ebc459cb74c4144fda9cc3bb03 { get; set; }
        public bool b5e70c87e17a373db0b28517f9501115 { get; set; }
        public bool bb3d262bf71e4913224f89cd187f16ac { get; set; }
        public bool c0c77683fd5aa33a316060307cb4e5a1 { get; set; }
        public bool c7d5457b90b24b213643f248aa08086e { get; set; }
        public bool d53b1f90985bfbb0fb93dff0d1fa3bca { get; set; }
        public bool d88aca5bd7de1de58752cadc8c1d8d64 { get; set; }
        public bool f4ee3f85f175439f7c2aa48265f0d25e { get; set; }
        public bool fed3bf7819c74a0cea1603b3ca82d269 { get; set; }
    }

    public class To_Cache
    {
        public Gatekeepers gatekeepers { get; set; }
        public Qe qe { get; set; }
        public bool probably_has_app { get; set; }
    }

    public class Gatekeepers
    {
        public bool _009fa3e450a765929dd7c05311488b84 { get; set; }
        public bool _00a57f00bb706690c3a2c5607ff9980f { get; set; }
        public bool _01dccbb81baf220b8452e3a672876351 { get; set; }
        public bool _021c364f36fa6a748f7b9227760e81da { get; set; }
        public bool _028238834267ea4afff9d002f6cab97e { get; set; }
        public bool _03474aebcf9a12234cdcdb7ae9276394 { get; set; }
        public bool _0404c2081792e2778d56f4079a81ba61 { get; set; }
        public bool _042a3e1ebc7c3b2156e554f72e1d29f2 { get; set; }
        public bool _04c7ff8fcef0cfe31d23d791cc102c99 { get; set; }
        public bool _057403bcc8ef0ccec100c05d80a1c82d { get; set; }
        public bool _0644d5fb7deba7524e3c7b678dbd78b0 { get; set; }
        public bool _08a7014194ccca3eb091e58e37decd07 { get; set; }
        public bool _0adb48636695fb1cf1714130dc225130 { get; set; }
        public bool _0b142c42c86a094bcf695b413eb0ce4e { get; set; }
        public bool _0e327345f4def851eb7750b4361f31db { get; set; }
        public bool _0ff690305d9bb8728c38fc4ec24cb28b { get; set; }
        public bool _10a1411a2fe1bf01df96df532fb308fd { get; set; }
        public bool _10acfd61074c42fe2a6374d2390fcbdd { get; set; }
        public bool _116d33726ea852637a9da7e33f25b409 { get; set; }
        public bool _11764725a639f0fe5d957472e1915d08 { get; set; }
        public bool _122e7df365ecdfcc57a47887270c1501 { get; set; }
        public bool _127d8933d591fb51aef0fb7ba03b034d { get; set; }
        public bool _1317c9d9d93a3543f3c5d0b2fd6c673a { get; set; }
        public bool _134c532c3c1f9dddd5f67075981d7050 { get; set; }
        public bool _1552ecbb62d0dea31503085edd758e2f { get; set; }
        public bool _156afcae976343d13e119d3e5bd6b5aa { get; set; }
        public bool _161b7357ad7e4d2cbf8aa82202e01003 { get; set; }
        public bool _1859cd2c3e8ff257375cf2e4f60e2120 { get; set; }
        public bool _196f1e1fdf1fda944b0e0aa4703dc887 { get; set; }
        public bool _1ad1c0ed8bf19602a3c6d60f0fc4c0e6 { get; set; }
        public bool _1b250d15866e4269d7a58bd453c581dd { get; set; }
        public bool _1df69062dd665a810ab7207b1665fefe { get; set; }
        public bool _1f2edcdcfb4e175b75c1f313863d1478 { get; set; }
        public bool _200153cf92ae22412291337689a84968 { get; set; }
        public bool _211a3b636bf605696f9f15158dc95d92 { get; set; }
        public bool _2166c0dad1ccc40db80194fa8de6df99 { get; set; }
        public bool _2194d568bd419828bb76b0e0c9744e16 { get; set; }
        public bool _21a019f30485d93e79b0ba0fd2f808b4 { get; set; }
        public bool _2230c0c42ce7470be26a0f8784d6cc69 { get; set; }
        public bool _2471b7784ca5c0f1b4537a8f60e760ee { get; set; }
        public bool _248bf91fc7faa918b9cf22e9528ca12e { get; set; }
        public bool _2590997e9202d69e0833442389c02944 { get; set; }
        public bool _261141d1b1ad830fa66b6ba6e3bbf4dc { get; set; }
        public bool _26dd545d92610e047153d8a7360fd376 { get; set; }
        public bool _278e5b89ffb15b2d3baab504abc10a22 { get; set; }
        public bool _27b0c91a7ab2e964d479611776560408 { get; set; }
        public bool _2884495905a649321178092d409fa3e5 { get; set; }
        public bool _297900fb2cf5dfe22a6f3dbf456c613e { get; set; }
        public bool _2bfcbe74be63a9b919cd4ae9b4ac6fec { get; set; }
        public bool _2eb29c0de2d55b2d8b4be65986bf8372 { get; set; }
        public bool _2f92cde862afccbae3bb30f1c938132e { get; set; }
        public bool _322188e0fb60e9a11fee7a54dc3a5bf6 { get; set; }
        public bool _34860d371b74a0fae38de95e2a431364 { get; set; }
        public bool _3500c1040008f41eafda8aa9aa91af7b { get; set; }
        public bool _388850389d9a78f0a0d5e0576a091aaf { get; set; }
        public bool _38a9f670e059538b86be1bee61623034 { get; set; }
        public bool _38d44a280fb2c117b89d728a9dbc7a9e { get; set; }
        public bool _3921688bf34de5871266dab3fa9a41a6 { get; set; }
        public bool _3a987ae91ffb897090d4f5d601222c9b { get; set; }
        public bool _3c4e79a46c0542864ddaf9da491be16e { get; set; }
        public bool _3f9a5c6780e4c66e1bdf8cb76c8ed70b { get; set; }
        public bool _42d3fb1065c7ef67af17483a5f75285c { get; set; }
        public bool _43209909bbc0dc28c34eea93f021a1a6 { get; set; }
        public bool _43bdef11d65051c6efe18183b6656ee1 { get; set; }
        public bool _43c6ab72ff8acaa512e4e3c3c27ad7cc { get; set; }
        public bool _440bc90cfb900bf6c3cfc21c3e8aa31f { get; set; }
        public bool _4433900b7e55ae3bc6ae86ca958aee90 { get; set; }
        public bool _44b1ce5210dba40b1ea696e2cf2d0da6 { get; set; }
        public bool _44d4391c757f1cb95df86b7589aba297 { get; set; }
        public bool _47299a9bb5024cd2857a742f5a5fabdb { get; set; }
        public bool _48eee4ddf4106d3a8e87f36d9a02fa5f { get; set; }
        public bool _49677a833265814f2ae7631643e226e4 { get; set; }
        public bool _4b8788934895fdf92b9b5b7798199ba0 { get; set; }
        public bool _4c42866bd18e97af16c76f38c999296f { get; set; }
        public bool _4ea9cca66701f0bec20983d828b74cbc { get; set; }
        public bool _5089df93bfd81a5e01bbde63bd5a5835 { get; set; }
        public bool _52a1cca9b762e32ba211c878390c09a0 { get; set; }
        public bool _539478cb83925c551798af0170359706 { get; set; }
        public bool _540a27c9b465b678b75a387cf050e8d8 { get; set; }
        public bool _560e94b315ece7f84da9bfc28b672ca6 { get; set; }
        public bool _563dee531b456a184263ce1ebead9238 { get; set; }
        public bool _592a64cd06a1b4cab77cbd3f6363299f { get; set; }
        public bool _5979d62c4994540784ac11f531989c0a { get; set; }
        public bool _5982c9d28f85fdbdc21dfb0735ec68ff { get; set; }
        public bool _5ccf3c37ef206d394c322fe366bd8319 { get; set; }
        public bool _5d803917619ce311cf477b6a887a557f { get; set; }
        public bool _5e3f621f72a8269807ca770831832a72 { get; set; }
        public bool _5f7ef2e49c95d09c160d3cec60577a38 { get; set; }
        public bool _5f9c39069a065b553c6acc8531f96b62 { get; set; }
        public bool _6078fb0c009f15671c6424ec2497c700 { get; set; }
        public bool _60a9c1f041be0fd5725a0cf313a8fe51 { get; set; }
        public bool _61551448ebf346c48b55229c92ab4d6d { get; set; }
        public bool _6653262fac150e6c42a557c6bd153afa { get; set; }
        public bool _67c5d72c5004437ed33ac203c3fd1756 { get; set; }
        public bool _69907bc218c3347a52a5da6aeb16a80a { get; set; }
        public bool _6c6aa71c95325385f33dafd7c463c04d { get; set; }
        public bool _6da094e22990a03d66abfc775aecf15d { get; set; }
        public bool _6e14f1446160d8ca5d686d193c7b21a1 { get; set; }
        public bool _6e611f2dd30fbe8476a8728000594b35 { get; set; }
        public bool _6e8079b871617add378ce0a089c0f6bc { get; set; }
        public bool _6ea6135dfdfb39b86f8f8d3f1240f4a7 { get; set; }
        public bool _6fd4b7a09e7cb05bab67edfaf7aa9e75 { get; set; }
        public bool _71a9f818bb0aaf11afcdc036018dcadf { get; set; }
        public bool _721722c0aa14fe537921748dde2edf9f { get; set; }
        public bool _725c8564d1d8c1327f630736918b73be { get; set; }
        public bool _730e4a631f1c621c5a5694890d6db4b9 { get; set; }
        public bool _73b19abfa50aea653ac4cc4765cdab51 { get; set; }
        public bool _73e986be6c9f17b76b5a1d3f77b6090d { get; set; }
        public bool _741e2eb09b00eaf956fe37e2b595e65f { get; set; }
        public bool _74e36646556409bc8c8b55703bb50262 { get; set; }
        public bool _75859ee30ad41f3f64494bfb80b6a4e9 { get; set; }
        public bool _77f71b34a16230f78061475a8f89382a { get; set; }
        public bool _78f2fa9040ee0f770c0ff3a5642b0e12 { get; set; }
        public bool _79103ae9ab79fcd989e569732a94d437 { get; set; }
        public bool _7927dcf3d72a0acbf6af51ca4595bf2e { get; set; }
        public bool _7961fda33b24480151d1c36c3eafd299 { get; set; }
        public bool _79bd1bc421163e1cf897231646323ff7 { get; set; }
        public bool _79fd847efe5809cba1b78bae1f996c16 { get; set; }
        public bool _7a0e19d6754cf75ee254cebcaa7e326c { get; set; }
        public bool _7af14de9be3c604224bce4b4ade2cc1d { get; set; }
        public bool _7bb20911985813e2cdae12a77c4d355d { get; set; }
        public bool _7beac735a4ac5f601f21878eab6bfcc8 { get; set; }
        public bool _7c14bfbe9652e194f2ae779d7625f459 { get; set; }
        public bool _7e7a90224b45fbaddf39743e676c66c1 { get; set; }
        public bool _80fc0ddcb6d28fb9a2fa8cb8918dfa55 { get; set; }
        public bool _8401bcacc6288385f0731a1259ee6aea { get; set; }
        public bool _8442f4be6a753751b4feac8d5da9cf5d { get; set; }
        public bool _84cfc8676fe3d92b7ca81ab4dc9fc051 { get; set; }
        public bool _8542641b0c43d89c53e45515105c650f { get; set; }
        public bool _859104160b331dfa4f085d7bad6145a3 { get; set; }
        public bool _85d62a6202f78b2f3fbd6952a24729a7 { get; set; }
        public bool _8779449f404ffb860690fc20980e1c48 { get; set; }
        public bool _8991444ceff19abf035ec8b141572a15 { get; set; }
        public bool _8a233c82fb692064aa21aa611f0885cb { get; set; }
        public bool _8a2c1165bf201bb3a72c73a266bfc6d9 { get; set; }
        public bool _8a6abe223f8155ccb46310932417a823 { get; set; }
        public bool _8c3182c92b73fd3ea4f1883a22053e10 { get; set; }
        public bool _913cbcb18f9332b87b8ffc62a78e391a { get; set; }
        public bool _91bd7df51fb95a69a47698f5caa65c6e { get; set; }
        public bool _92bcb17d885901a8669f9d66c6265993 { get; set; }
        public bool _96cb0440b866d02aacd828fd5169bb95 { get; set; }
        public bool _9797a4258aacd9d9a91b25c4fc3f92ed { get; set; }
        public bool _9940a6314acb76d17feabbdaa13d5796 { get; set; }
        public bool _9aaadeb2df480a73a061c64196ba2587 { get; set; }
        public bool _9b598a1c1af670cc04cc38a2a2d1d97e { get; set; }
        public bool _9c80ae0a8f87b0938e896aa59584d0e2 { get; set; }
        public bool _9d37d560d8ec6c357a6d7ed1c07130f0 { get; set; }
        public bool _9e08a7d4bb7d639b866ac7785f9288e2 { get; set; }
        public bool _9e4f5530459c1ead5f1c83c689c159a9 { get; set; }
        public bool _9e5639a163931af222b143749b551ce9 { get; set; }
        public bool _9e85a32c3ce1f3ccd51d616d12b6e28b { get; set; }
        public bool _9e9217698f431e197a7b02ba3057bf8a { get; set; }
        public bool _9eb8bd6b8815f0839f70e040c296aefc { get; set; }
        public bool a00d8cabdfd821a883b4f1907cd6334e { get; set; }
        public bool a0a411f6ca275530466e783767debc13 { get; set; }
        public bool a13791add93cdea753c8438e2cf5b32f { get; set; }
        public bool a1b948a25fc9d1b7a058043ad9bc066d { get; set; }
        public bool a21f68634144b5619b0dcce3cafadf1f { get; set; }
        public bool a2c7c68b5641429d3eac99eea9316e91 { get; set; }
        public bool a30e4b55bb0cacef7687c455f8ca2f61 { get; set; }
        public bool a3e0abc0fb38fc6553920b875587ab7f { get; set; }
        public bool a4cfc4ba1412fe4c15fc1f67bd15a51f { get; set; }
        public bool a56aca1e58f58fe0b7252566e8abc4e8 { get; set; }
        public bool a7a55fbf106e4c6d8251713fe7d38140 { get; set; }
        public bool a893ab61ed8bccaf13501e3aa1e73478 { get; set; }
        public bool a8991778453e41aaa6c563b1476bccf3 { get; set; }
        public bool a8b677a426e5c2636f81de321eb5f8e8 { get; set; }
        public bool a962f004876919f775de5ec1017213dc { get; set; }
        public bool abb876ccfb2de45d92ef983e5a2e4597 { get; set; }
        public bool ac4f8c1892e0d9a7d8cdc4b07e39f057 { get; set; }
        public bool ac5510551ad8a1a805e272bb35bb5a89 { get; set; }
        public bool aca09613b2afff98340a26d9fcc932f8 { get; set; }
        public bool af2ae49bf8c1b9dacbf44a1b2479809f { get; set; }
        public bool af8d97d74472bc9c950c32ae9a7855aa { get; set; }
        public bool b033b5369b8049923e8f765e3221d48e { get; set; }
        public bool b05801b48ab066d8ed658acfefb7d487 { get; set; }
        public bool b206a2aff9fbb7fbd100df3f8d56276d { get; set; }
        public bool b2609562f4ba2600cabe1fa39e6505d5 { get; set; }
        public bool b2e657eebb03fd28e0a69e559361c457 { get; set; }
        public bool b39d0a730af96c72ffdaf708f68ddb37 { get; set; }
        public bool b4c77f5c4d42e3be39a5e9335a9fd9d2 { get; set; }
        public bool b5e651c09afba060832054c6447bea87 { get; set; }
        public bool b6026dde933a4320c79c70798d735b96 { get; set; }
        public bool b70418a85b5f7d66b691974582c73aac { get; set; }
        public bool ba325c6f0b1b5cc6c3eae2c17f7698a0 { get; set; }
        public bool ba8ab0e419b454ba00269fe9aff70029 { get; set; }
        public bool bb690b891a596929ac730d7dc027281b { get; set; }
        public bool bba3d99f7b800eebcfc945395e870324 { get; set; }
        public bool bbef073b2279862cd7b4eda1ffe1e66c { get; set; }
        public bool bdadcd6e49aa211c9efa012d8c5e1cc6 { get; set; }
        public bool bdd069bffb2687380cb748579e69cccb { get; set; }
        public bool bed369d8cb9072d1ae8b7a9289ce9b01 { get; set; }
        public bool c0072eeb3f56fbd7400c216e2b2d81d8 { get; set; }
        public bool c0789ba80ffb69e16b81599a04666e27 { get; set; }
        public bool c18b85bfb0c996fd4fc39006ea0a112d { get; set; }
        public bool c1caa06c12cf5892a3ce417ba89a2fa8 { get; set; }
        public bool c2837fdde6b80a02aab4d75df8fe05af { get; set; }
        public bool c3441c64fc06efd9616a6bc1ce30edbf { get; set; }
        public bool c43995476ee9996c5a94df6910b31503 { get; set; }
        public bool c4e4f6f773dbc834d72148101460a0c0 { get; set; }
        public bool c74acb50c01a15ba0aec394edfcfefbe { get; set; }
        public bool c821e78f6cf744b781a0f921e0cbb162 { get; set; }
        public bool ca0eabb30badaa2e359e0b160cf71d30 { get; set; }
        public bool ca9a5505fe21f21b6001ee089aca5d33 { get; set; }
        public bool cc14ca635af9ba8fcdd3d5295c09f56f { get; set; }
        public bool cc9f70f082a059fea8d1036475425826 { get; set; }
        public bool ce3ccd33342db3f9b838df62fd91c451 { get; set; }
        public bool cfd64ca802725f05763b949668114f47 { get; set; }
        public bool d102d848af9a839019889c4f688165a0 { get; set; }
        public bool d151496913f047aa40f38a5ad0db0021 { get; set; }
        public bool d1584181912879b33b5a37f1b3b6acbb { get; set; }
        public bool d35655349616aa247b37d45a4f8ef432 { get; set; }
        public bool d468ace70817d3319abd74abe15c0653 { get; set; }
        public bool d52e9e734ffa32275bca5804db996d7a { get; set; }
        public bool d5db2642ffa492a4f61ac7d19e4d4a7c { get; set; }
        public bool d77f89e2a614442d2dc9f1e20c4e1956 { get; set; }
        public bool d7f994b8f16d551847a9aba4314e397b { get; set; }
        public bool d8f7819984d0765a4e9ce4c42d046d1a { get; set; }
        public bool d9876f2cb8a2db484645b0588a557829 { get; set; }
        public bool d9b5e8fdb2aecabfd3207bf2e830ed03 { get; set; }
        public bool d9c8c7d6f609a77bcc83c88f3a485733 { get; set; }
        public bool dc5921752615bc7bde476d11f854232b { get; set; }
        public bool dcd4224f36c675a2abf5d50a9648f022 { get; set; }
        public bool dd083dc4381c99f09a62989e026beb46 { get; set; }
        public bool dd6c3934feb3040608131f46c132a7e0 { get; set; }
        public bool dd8b4b43a53627f02e30d44e12651a4a { get; set; }
        public bool de5d9b2a4baa5a6c0f59c90dab784ae7 { get; set; }
        public bool df80149c99dd7f9617fc7e7d8abc24ef { get; set; }
        public bool e2f1d2267900a0725649c39f717dfa69 { get; set; }
        public bool e4bca332e1f7812a45af36245ce8805a { get; set; }
        public bool e4d9f973a861273f3340b5777a74683c { get; set; }
        public bool e62436aacc97d0141bda548cdd82e039 { get; set; }
        public bool e6598436007c651afce9e20a93b18578 { get; set; }
        public bool e6f4762f4fd47948ed114cbaac44ca39 { get; set; }
        public bool e76a8d86dc489a4c6f56855f9481feab { get; set; }
        public bool e8108a8759a6171fd28eeb2018bcb215 { get; set; }
        public bool eab36c5162ffe3f420566fffcb98939a { get; set; }
        public bool eb184193ba8531147a27f62b11335b7d { get; set; }
        public bool ec93037482ddd7452fcc43aa4c5b4b81 { get; set; }
        public bool ecd0d7053fbe7844c83c8d2d67752eeb { get; set; }
        public bool efc209ad306781d799fb779c2bcfd0fd { get; set; }
        public bool f02846a6efb1eee6cd52c622c215d451 { get; set; }
        public bool f113fba8550c4d92333181282d23b120 { get; set; }
        public bool f1a388da5d8022d28be35568cca33750 { get; set; }
        public bool f3cb0e417d8b73758be753a0ddc2afb7 { get; set; }
        public bool f3f200c0ec1146d51588b989846d0e20 { get; set; }
        public bool f4e3c013aeda53bab294846ccca5056f { get; set; }
        public bool f6978b2665a72c1d1fb6ae0b52c652ad { get; set; }
        public bool f7142e0a86f72887d9177045ff85b8ca { get; set; }
        public bool f7e30c8280c2b4f0af9d23514785818a { get; set; }
        public bool f844fdea7f3df35f29a72ad9ee4f00d4 { get; set; }
        public bool f897834bec2171034dad0a84c0a1f9e3 { get; set; }
        public bool f8dee5be0eaed71f2e0f588dec8a58fe { get; set; }
        public bool f9618d0b0388ca82b090d784ee6b200b { get; set; }
        public bool fa1a406c031912f6c786f6276cc68078 { get; set; }
        public bool fba63080eadaca0f63641dae59d0dc83 { get; set; }
        public bool fc279a99c031f977b86ddc44b3a77041 { get; set; }
        public bool fdf32b017a5226cd647444259cafce93 { get; set; }
        public bool fe770dc975d85da306f4eee4c67c048e { get; set; }
        public bool ff57d580cbe890cf1bcfdf2fa3792e27 { get; set; }
    }

    public class Qe
    {
        public App_Upsell app_upsell { get; set; }
        public Igl_App_Upsell igl_app_upsell { get; set; }
        public Notif notif { get; set; }
        public Onetaplogin onetaplogin { get; set; }
        public Felix_Clear_Fb_Cookie felix_clear_fb_cookie { get; set; }
        public Felix_Creation_Duration_Limits felix_creation_duration_limits { get; set; }
        public Felix_Creation_Fb_Crossposting felix_creation_fb_crossposting { get; set; }
        public Felix_Creation_Fb_Crossposting_V2 felix_creation_fb_crossposting_v2 { get; set; }
        public Felix_Creation_Validation felix_creation_validation { get; set; }
        public Post_Options post_options { get; set; }
        public Sticker_Tray sticker_tray { get; set; }
        public Web_Sentry web_sentry { get; set; }
        public _0620E92b561b0c7e08b34ef6cfe894fe _0620e92b561b0c7e08b34ef6cfe894fe { get; set; }
        public _09B4bc79c5f097d39eccc2d996c1e4b8 _09b4bc79c5f097d39eccc2d996c1e4b8 { get; set; }
        public _0E0cef5cf869f76839dea9aab16a294e _0e0cef5cf869f76839dea9aab16a294e { get; set; }
        public _0E5e85d6e8dad1d29137f1cb525b02bc _0e5e85d6e8dad1d29137f1cb525b02bc { get; set; }
        public _1096C23eb866de5c8a4877992592feeb _1096c23eb866de5c8a4877992592feeb { get; set; }
        public _128Adba1f0836406bd4dceaf57a0defa _128adba1f0836406bd4dceaf57a0defa { get; set; }
        public _1629B857d084eab67a272b9faf18c74d _1629b857d084eab67a272b9faf18c74d { get; set; }
        public _17Eee9316ff98419f0da0f87506e1826 _17eee9316ff98419f0da0f87506e1826 { get; set; }
        public _180Cd0bacffc5347bbc1aa217240f792 _180cd0bacffc5347bbc1aa217240f792 { get; set; }
        public _1C46bf25792a3c449303f8a67f0a6e5c _1c46bf25792a3c449303f8a67f0a6e5c { get; set; }
        public _21121A99e8de5f3b73f998f9f114af98 _21121a99e8de5f3b73f998f9f114af98 { get; set; }
        public _2780Af766858d793a2102c5778c3ef37 _2780af766858d793a2102c5778c3ef37 { get; set; }
        public _282188012A6be9b45d0a5625db9131e5 _282188012a6be9b45d0a5625db9131e5 { get; set; }
        public _2B451c9688df7ebbf5722385f91de61d _2b451c9688df7ebbf5722385f91de61d { get; set; }
        public _344Db179e3bcec5410f06ee48511efa2 _344db179e3bcec5410f06ee48511efa2 { get; set; }
        public _34D41efec78ab1ae43833b2d56cebae6 _34d41efec78ab1ae43833b2d56cebae6 { get; set; }
        public _35Ccc053595473bcd993a4ed3dbca953 _35ccc053595473bcd993a4ed3dbca953 { get; set; }
        public _3B554decc698dc13e44ad0e4096e5df4 _3b554decc698dc13e44ad0e4096e5df4 { get; set; }
        public _3Fc844ff1827e2fc88d93a2d2bd9870e _3fc844ff1827e2fc88d93a2d2bd9870e { get; set; }
        public _4000F5b8cf59fc7c79e31701ccf0c06b _4000f5b8cf59fc7c79e31701ccf0c06b { get; set; }
        public _40Dbb020fda6c845333a805bda8d40b2 _40dbb020fda6c845333a805bda8d40b2 { get; set; }
        public _419D84fc70417a7368c5af07f3a08ce8 _419d84fc70417a7368c5af07f3a08ce8 { get; set; }
        public _425606Ede683f28310b9d471f8da2d8d _425606ede683f28310b9d471f8da2d8d { get; set; }
        public _4793Fa4fbe26a206d0b022a2d80efcd3 _4793fa4fbe26a206d0b022a2d80efcd3 { get; set; }
        public _48F4eae17f54d14ef57c6f249211efcd _48f4eae17f54d14ef57c6f249211efcd { get; set; }
        public _4D3254608c803823d8b36d11761a5f49 _4d3254608c803823d8b36d11761a5f49 { get; set; }
        public _4D604dbad43a2551324f85db9b12954a _4d604dbad43a2551324f85db9b12954a { get; set; }
        public _519D9fa15fd1b105dce1db2c0a2b9a81 _519d9fa15fd1b105dce1db2c0a2b9a81 { get; set; }
        public _52Fc4c0bab32a66d19ff035b8cda855c _52fc4c0bab32a66d19ff035b8cda855c { get; set; }
        public _5400De163123fc2242cb0cb35104c546 _5400de163123fc2242cb0cb35104c546 { get; set; }
        public _546F5e4549d5c3e5113213901a0955ca _546f5e4549d5c3e5113213901a0955ca { get; set; }
        public _5619798Ccfda666bcf86b57e2295e8af _5619798ccfda666bcf86b57e2295e8af { get; set; }
        public _568668Ed8c2e7e0c9ad6b5038fece156 _568668ed8c2e7e0c9ad6b5038fece156 { get; set; }
        public _57Ad1c28eb6500bfcf66745d2adca38c _57ad1c28eb6500bfcf66745d2adca38c { get; set; }
        public _5E5af8f80dc2a046fdc66102ffc12122 _5e5af8f80dc2a046fdc66102ffc12122 { get; set; }
        public _65D114d7d4e0f4e43486f3333fd05cdd _65d114d7d4e0f4e43486f3333fd05cdd { get; set; }
        public _6999A0b22e9fc2ff6c338e9839965238 _6999a0b22e9fc2ff6c338e9839965238 { get; set; }
        public _69Eb081996ceb64b16632f2f70b6dd82 _69eb081996ceb64b16632f2f70b6dd82 { get; set; }
        public _6Be7ca7396b3cddece910ac2517156b5 _6be7ca7396b3cddece910ac2517156b5 { get; set; }
        public _6E5d85cb48b33b7d214bae2b7617853c _6e5d85cb48b33b7d214bae2b7617853c { get; set; }
        public _6Fa9853da3ca096111937df4db810fde _6fa9853da3ca096111937df4db810fde { get; set; }
        public _70Afcc770a54f88c3e94c2db1c1d35be _70afcc770a54f88c3e94c2db1c1d35be { get; set; }
        public _725794B89aa16d41efa1d9673fe59264 _725794b89aa16d41efa1d9673fe59264 { get; set; }
        public _748910795D2438fc5f7c2cd5880f7600 _748910795d2438fc5f7c2cd5880f7600 { get; set; }
        public _7879A0608f8451beb8d7e44b862a5abc _7879a0608f8451beb8d7e44b862a5abc { get; set; }
        public _78C189896a493910bf19d7ef30dbae29 _78c189896a493910bf19d7ef30dbae29 { get; set; }
        public _7A18c5d64508be84f073deaf5a4067c4 _7a18c5d64508be84f073deaf5a4067c4 { get; set; }
        public _7B8b228c8838a3c83a240a7cbdd64f67 _7b8b228c8838a3c83a240a7cbdd64f67 { get; set; }
        public _7Dafe49de69c6e063ee69b6aff3cc111 _7dafe49de69c6e063ee69b6aff3cc111 { get; set; }
        public _80E2ab32e819faa407c840b9e4e23953 _80e2ab32e819faa407c840b9e4e23953 { get; set; }
        public _8225863Ca091fba8bfd94f1a1dae7091 _8225863ca091fba8bfd94f1a1dae7091 { get; set; }
        public _84C61c2b1c50ec5123faa391b9261184 _84c61c2b1c50ec5123faa391b9261184 { get; set; }
        public _87Bab2d6a814df80475e8773486cbd5c _87bab2d6a814df80475e8773486cbd5c { get; set; }
        public _8Cd3cce694b5cf6128f806942d5352cd _8cd3cce694b5cf6128f806942d5352cd { get; set; }
        public _8Df26d8baf4eb30273425c3150fba6a0 _8df26d8baf4eb30273425c3150fba6a0 { get; set; }
        public _8Ef9cc057aff11679e6776353a198f5c _8ef9cc057aff11679e6776353a198f5c { get; set; }
        public _8Ff6917bc74043ed4a76752b4d8c9ae3 _8ff6917bc74043ed4a76752b4d8c9ae3 { get; set; }
        public _919C32fd8a384e3660a325c8b197e3a9 _919c32fd8a384e3660a325c8b197e3a9 { get; set; }
        public _932A926d6aa4f347b7d0f918eb0ad0b5 _932a926d6aa4f347b7d0f918eb0ad0b5 { get; set; }
        public _987C220b519c889274052f815cb2f353 _987c220b519c889274052f815cb2f353 { get; set; }
        public _9E031ca52113ba76b2cc892844a88851 _9e031ca52113ba76b2cc892844a88851 { get; set; }
        public A16a7cdeb73250bea3d9ecdb17e8b390 a16a7cdeb73250bea3d9ecdb17e8b390 { get; set; }
        public A28b33540d899b239bf6eccc4904a1da a28b33540d899b239bf6eccc4904a1da { get; set; }
        public A60ed86a010588f48d614cb854e00dd3 a60ed86a010588f48d614cb854e00dd3 { get; set; }
        public A7c29e6af4330be684d07a1d0af658ed a7c29e6af4330be684d07a1d0af658ed { get; set; }
        public A8c0770b67ad2779d6f4964bce2362fb a8c0770b67ad2779d6f4964bce2362fb { get; set; }
        public B4e9ea67e1d3426d3b078ab98465b817 b4e9ea67e1d3426d3b078ab98465b817 { get; set; }
        public Be9638a9bdf8422ed3f5a6c6b3d6a516 be9638a9bdf8422ed3f5a6c6b3d6a516 { get; set; }
        public C19cc5d4211286e6b80a49dffbcb2065 c19cc5d4211286e6b80a49dffbcb2065 { get; set; }
        public C2936192e09a300b2323146b94b94d49 c2936192e09a300b2323146b94b94d49 { get; set; }
        public C76bd1e48217d6516a6120ab8e1a77a9 c76bd1e48217d6516a6120ab8e1a77a9 { get; set; }
        public C7a0564cd779806f1b4985cd8351688e c7a0564cd779806f1b4985cd8351688e { get; set; }
        public C90dc381159282fe1892f45b4e34474d c90dc381159282fe1892f45b4e34474d { get; set; }
        public Cb26bc43780b8850429c3361f16393bb cb26bc43780b8850429c3361f16393bb { get; set; }
        public D6cc94cc0fc4d66dcef28865acf61340 d6cc94cc0fc4d66dcef28865acf61340 { get; set; }
        public D7765c74deaaa5fda26820943dfa4505 d7765c74deaaa5fda26820943dfa4505 { get; set; }
        public D918d46152cb1d958fc00947d64950a9 d918d46152cb1d958fc00947d64950a9 { get; set; }
        public Dc5353102643a57d669296e71c3454f5 dc5353102643a57d669296e71c3454f5 { get; set; }
        public E1ef1f1eee8124c7582d69e9e3f38443 e1ef1f1eee8124c7582d69e9e3f38443 { get; set; }
        public E42bb34173aaba74caf60de2dabb1e9e e42bb34173aaba74caf60de2dabb1e9e { get; set; }
        public E887b17e0ed055dad3d6bdb4a0bbcd03 e887b17e0ed055dad3d6bdb4a0bbcd03 { get; set; }
        public E9c1cdafdf0de769c8e815c1e605678a e9c1cdafdf0de769c8e815c1e605678a { get; set; }
        public Eb7aa23cd8cf072e0db7d1199d045f14 eb7aa23cd8cf072e0db7d1199d045f14 { get; set; }
        public Edf5c87670004cdfb60960d92155a319 edf5c87670004cdfb60960d92155a319 { get; set; }
        public Ee518c44cb4e028e93f7ed7a7ef5b434 ee518c44cb4e028e93f7ed7a7ef5b434 { get; set; }
        public Eea4e102a56972c9d76a5097e1332292 eea4e102a56972c9d76a5097e1332292 { get; set; }
        public Eefe6b0ba93542b043c85ee68ec68d5d eefe6b0ba93542b043c85ee68ec68d5d { get; set; }
        public F32ccf5136ea284a177598172705431b f32ccf5136ea284a177598172705431b { get; set; }
        public F396db07393edc76686eea077d7eaeb3 f396db07393edc76686eea077d7eaeb3 { get; set; }
        public F41a40539142ff53c4a8c004afb4b52f f41a40539142ff53c4a8c004afb4b52f { get; set; }
        public F8fad127506e737a65da0a394ca69abc f8fad127506e737a65da0a394ca69abc { get; set; }
        public Fb18df451b5f046d19e27ed6c76e8d8b fb18df451b5f046d19e27ed6c76e8d8b { get; set; }
    }

    public class App_Upsell
    {
        public string g { get; set; }
        public P p { get; set; }
    }

    public class P
    {
    }

    public class Igl_App_Upsell
    {
        public string g { get; set; }
        public P1 p { get; set; }
    }

    public class P1
    {
    }

    public class Notif
    {
        public string g { get; set; }
        public P2 p { get; set; }
    }

    public class P2
    {
    }

    public class Onetaplogin
    {
        public string g { get; set; }
        public P3 p { get; set; }
    }

    public class P3
    {
    }

    public class Felix_Clear_Fb_Cookie
    {
        public string g { get; set; }
        public P4 p { get; set; }
    }

    public class P4
    {
        public string is_enabled { get; set; }
        public string blacklist { get; set; }
    }

    public class Felix_Creation_Duration_Limits
    {
        public string g { get; set; }
        public P5 p { get; set; }
    }

    public class P5
    {
        public string maximum_length_seconds { get; set; }
        public string minimum_length_seconds { get; set; }
    }

    public class Felix_Creation_Fb_Crossposting
    {
        public string g { get; set; }
        public P6 p { get; set; }
    }

    public class P6
    {
        public string is_enabled { get; set; }
    }

    public class Felix_Creation_Fb_Crossposting_V2
    {
        public string g { get; set; }
        public P7 p { get; set; }
    }

    public class P7
    {
        public string is_enabled { get; set; }
        public string display_version { get; set; }
    }

    public class Felix_Creation_Validation
    {
        public string g { get; set; }
        public P8 p { get; set; }
    }

    public class P8
    {
        public string edit_video_controls { get; set; }
        public string description_maximum_length { get; set; }
        public string max_video_size_in_bytes { get; set; }
        public string minimum_length_for_feed_preview_seconds { get; set; }
        public string title_maximum_length { get; set; }
        public string valid_cover_mime_types { get; set; }
        public string valid_video_extensions { get; set; }
        public string valid_video_mime_types { get; set; }
    }

    public class Post_Options
    {
        public string g { get; set; }
        public P9 p { get; set; }
    }

    public class P9
    {
        public string enable_igtv_embed { get; set; }
        public string use_refactor { get; set; }
    }

    public class Sticker_Tray
    {
        public string g { get; set; }
        public P10 p { get; set; }
    }

    public class P10
    {
    }

    public class Web_Sentry
    {
        public string g { get; set; }
        public P11 p { get; set; }
    }

    public class P11
    {
        public string show_feedback { get; set; }
    }

    public class _0620E92b561b0c7e08b34ef6cfe894fe
    {
        public P12 p { get; set; }
        public L l { get; set; }
        public bool qex { get; set; }
    }

    public class P12
    {
        public bool _519be4f49d3af78a4db0468e36f70621 { get; set; }
        public bool _788e5d60de1e90e51b95e621c516232e { get; set; }
        public bool a34a281c4483301a962b266fd334f26e { get; set; }
        public bool a722070f9e931d1c7a415572019ebda7 { get; set; }
        public bool b9c360d80f29171e932e39a67b02d8a3 { get; set; }
        public bool dec1fe47e3bd674ea738880f344a4621 { get; set; }
    }

    public class L
    {
    }

    public class _09B4bc79c5f097d39eccc2d996c1e4b8
    {
        public P13 p { get; set; }
        public L1 l { get; set; }
        public bool qex { get; set; }
    }

    public class P13
    {
        public bool _115a482da3193d44c4cbf2e737a1e569 { get; set; }
    }

    public class L1
    {
    }

    public class _0E0cef5cf869f76839dea9aab16a294e
    {
        public P14 p { get; set; }
        public L2 l { get; set; }
        public bool qex { get; set; }
    }

    public class P14
    {
        public bool _66e3104958a4b1f8e2a26ffc47a0b748 { get; set; }
    }

    public class L2
    {
    }

    public class _0E5e85d6e8dad1d29137f1cb525b02bc
    {
        public P15 p { get; set; }
        public L3 l { get; set; }
        public bool qex { get; set; }
    }

    public class P15
    {
        public bool _4e021335d0a10c24903b08a25631538e { get; set; }
        public bool _5cc8e941ce9eaf9ec83a70df14656b85 { get; set; }
        public bool _728d447b0fd26675ad633e20da970a1f { get; set; }
        public int a1789d165f436a48648e110dbdb30c7e { get; set; }
        public bool b42a4391cc3a32dcc988b2a583dc9980 { get; set; }
    }

    public class L3
    {
    }

    public class _1096C23eb866de5c8a4877992592feeb
    {
        public P16 p { get; set; }
        public L4 l { get; set; }
        public bool qex { get; set; }
    }

    public class P16
    {
        public bool _1b79e091531d2467b7be4942b0dc23d1 { get; set; }
    }

    public class L4
    {
    }

    public class _128Adba1f0836406bd4dceaf57a0defa
    {
        public P17 p { get; set; }
        public L5 l { get; set; }
        public bool qex { get; set; }
    }

    public class P17
    {
        public bool _24c1783646680eb1b4905135382071a1 { get; set; }
        public bool e4a8e0f3c898d3fc629c53370c9ab024 { get; set; }
    }

    public class L5
    {
    }

    public class _1629B857d084eab67a272b9faf18c74d
    {
        public P18 p { get; set; }
        public L6 l { get; set; }
        public bool qex { get; set; }
    }

    public class P18
    {
        public bool _78dbde4a2e2100c3c1a804130eb1c6e9 { get; set; }
    }

    public class L6
    {
    }

    public class _17Eee9316ff98419f0da0f87506e1826
    {
        public P19 p { get; set; }
        public L7 l { get; set; }
        public bool qex { get; set; }
    }

    public class P19
    {
        public bool _14d669eb456916355eb7f0849aa8c463 { get; set; }
        public bool _5674296d5992b855933c716066375b34 { get; set; }
        public bool _74f1ec01d07c4c158e647c99c64bb4c6 { get; set; }
    }

    public class L7
    {
    }

    public class _180Cd0bacffc5347bbc1aa217240f792
    {
        public P20 p { get; set; }
        public L8 l { get; set; }
        public bool qex { get; set; }
    }

    public class P20
    {
        public string _070b183806480004c58e87fe34af65f4 { get; set; }
    }

    public class L8
    {
    }

    public class _1C46bf25792a3c449303f8a67f0a6e5c
    {
        public P21 p { get; set; }
        public L9 l { get; set; }
        public bool qex { get; set; }
    }

    public class P21
    {
        public bool _01925c04edf774b7f294f8aca6eb3329 { get; set; }
        public bool _0422cc3271f288718e20c128c84a7485 { get; set; }
        public bool _2142c5d4e19795c1fa9040448d8008f3 { get; set; }
        public bool b52676de13a6ca6a1a0ea7247b0c072d { get; set; }
        public bool bfc1476c58b7fcfb903d560322dd4ffa { get; set; }
        public bool d44c0254a8d3a010bdfa7a8e39d17e14 { get; set; }
        public bool f8161e1a0fe1dd22f68e55a7990675c7 { get; set; }
    }

    public class L9
    {
    }

    public class _21121A99e8de5f3b73f998f9f114af98
    {
        public P22 p { get; set; }
        public L10 l { get; set; }
        public bool qex { get; set; }
    }

    public class P22
    {
        public bool _7cd59b0662a8eb2b8b77dc34928b3111 { get; set; }
        public bool _886cd469ee017901582232a7cbbadb39 { get; set; }
    }

    public class L10
    {
    }

    public class _2780Af766858d793a2102c5778c3ef37
    {
        public P23 p { get; set; }
        public L11 l { get; set; }
        public bool qex { get; set; }
    }

    public class P23
    {
        public bool _50372b591eb5911ad5fd277f83e88162 { get; set; }
    }

    public class L11
    {
    }

    public class _282188012A6be9b45d0a5625db9131e5
    {
        public P24 p { get; set; }
        public L12 l { get; set; }
        public bool qex { get; set; }
    }

    public class P24
    {
        public bool _42f2cd6fa53e15b032c207ba139724e3 { get; set; }
        public bool c4dcc2c6c2a7781a95ea7e5142c24bfb { get; set; }
        public bool d054a6e8ab027a19f469a3bb7ef94b6a { get; set; }
    }

    public class L12
    {
    }

    public class _2B451c9688df7ebbf5722385f91de61d
    {
        public P25 p { get; set; }
        public L13 l { get; set; }
        public bool qex { get; set; }
    }

    public class P25
    {
    }

    public class L13
    {
    }

    public class _344Db179e3bcec5410f06ee48511efa2
    {
        public P26 p { get; set; }
        public L14 l { get; set; }
        public bool qex { get; set; }
    }

    public class P26
    {
    }

    public class L14
    {
    }

    public class _34D41efec78ab1ae43833b2d56cebae6
    {
        public P27 p { get; set; }
        public L15 l { get; set; }
        public bool qex { get; set; }
    }

    public class P27
    {
        public bool _085dcb8c8aee1e548e37de701cd9fb70 { get; set; }
    }

    public class L15
    {
    }

    public class _35Ccc053595473bcd993a4ed3dbca953
    {
        public P28 p { get; set; }
        public L16 l { get; set; }
        public bool qex { get; set; }
    }

    public class P28
    {
        public bool _42db60c6269712d750bfedbbab734c92 { get; set; }
        public bool db4ef9c36af3eb36fc45def819c98813 { get; set; }
    }

    public class L16
    {
    }

    public class _3B554decc698dc13e44ad0e4096e5df4
    {
        public P29 p { get; set; }
        public L17 l { get; set; }
        public bool qex { get; set; }
    }

    public class P29
    {
        public bool _4bb4cab18e90bd7568b7c2e82fc5b96d { get; set; }
        public bool _924ff1bfece9d437c31f36cb08d0cd55 { get; set; }
        public bool a6b43c5441ab19b7b39e005e49cc9bb2 { get; set; }
    }

    public class L17
    {
    }

    public class _3Fc844ff1827e2fc88d93a2d2bd9870e
    {
        public P30 p { get; set; }
        public L18 l { get; set; }
        public bool qex { get; set; }
    }

    public class P30
    {
        public bool e4a27023c26aff27129bcdac10319f7d { get; set; }
    }

    public class L18
    {
    }

    public class _4000F5b8cf59fc7c79e31701ccf0c06b
    {
        public P31 p { get; set; }
        public L19 l { get; set; }
        public bool qex { get; set; }
    }

    public class P31
    {
        public bool _07f2483613a3ee9388417126f8709cae { get; set; }
        public bool _5ecd6393464cfa4ef00eee48fabb085f { get; set; }
    }

    public class L19
    {
    }

    public class _40Dbb020fda6c845333a805bda8d40b2
    {
        public P32 p { get; set; }
        public L20 l { get; set; }
        public bool qex { get; set; }
    }

    public class P32
    {
        public bool _699a016b0a3214c623f677285444c7f2 { get; set; }
    }

    public class L20
    {
    }

    public class _419D84fc70417a7368c5af07f3a08ce8
    {
        public P33 p { get; set; }
        public L21 l { get; set; }
        public bool qex { get; set; }
    }

    public class P33
    {
        public bool _50e3516e0deeea0d259542ceaad62ad6 { get; set; }
    }

    public class L21
    {
    }

    public class _425606Ede683f28310b9d471f8da2d8d
    {
        public P34 p { get; set; }
        public L22 l { get; set; }
        public bool qex { get; set; }
    }

    public class P34
    {
        public bool _929e553b694b4e29c37768bee9bfc768 { get; set; }
        public bool dee406ba4ade238d39f217eeda5cd306 { get; set; }
    }

    public class L22
    {
    }

    public class _4793Fa4fbe26a206d0b022a2d80efcd3
    {
        public P35 p { get; set; }
        public L23 l { get; set; }
        public bool qex { get; set; }
    }

    public class P35
    {
        public bool _018a4c4e626a442cac02c9b0aea7893a { get; set; }
        public bool _05956afe0d1745c0b06b31bb66c280b2 { get; set; }
        public int _0d3cbf85b3e4c9306415f68a1ffe278a { get; set; }
        public bool _2058ae09cfa860cbd20916f5238bc31f { get; set; }
        public bool _22d239ce285e9bcafd44d0c7c176c62f { get; set; }
        public string _2354569d7f9b7b410eee989c441efbee { get; set; }
        public bool _346fcc49491b3702a7776ef4122c24cd { get; set; }
        public string _35756d3249266d0c8269cb58f751b7cf { get; set; }
        public bool _4aea4a9c3ba5ec70755da0da630135ea { get; set; }
        public int _4d23f1db39cc77ea98d09e869377b01b { get; set; }
        public bool _4e357f7a9ea5416b0afd2517a1898ad8 { get; set; }
        public bool _51b203318f93c610418e26b5b79f2ad4 { get; set; }
        public bool _5deaed03dfb0d03be073a92608a9944f { get; set; }
        public bool _5e571a8dcb0c4fe62c03ad0a590db219 { get; set; }
        public bool _695285bd80b064794859d242d8cafb47 { get; set; }
        public bool _7c9eda38191e115ed5ec3eaddd828ea1 { get; set; }
        public int _82db62710e04042da7c3501f8dd7b6f0 { get; set; }
        public bool _84c2700eb34ff5c18dfe630888a19613 { get; set; }
        public bool _901f0a4d46fd21ea3b5444653cff44be { get; set; }
        public string _91c1e06dd077f57b9f79b6e8b0d5896b { get; set; }
        public string _925ec4a46caef2ebbaca2fd109cab4dd { get; set; }
        public bool _942ee89fac7274f26554ca100fb37ae3 { get; set; }
        public bool _9bdfdee181e67439396f43d8544f3508 { get; set; }
        public bool a20104d68a2e866d36c8dffdcd3f1922 { get; set; }
        public bool a70662d614e89b6ebc952d39d83e48e4 { get; set; }
        public int a8b19d387d2810b0ff3de6716b3030e7 { get; set; }
        public bool a96cb4364cee522c40efaec861dba4ff { get; set; }
        public bool abc22cfadf809f61e4ccf666071b8d4b { get; set; }
        public bool bb9608c922c53d6d5a58c2231a5cdefb { get; set; }
        public bool c9396d32de96267920317c2b10f756f8 { get; set; }
        public bool cf8162ace58e940baae6903ccc131cf8 { get; set; }
        public bool d1205f1a5b4e74ff7165b43038e32d1f { get; set; }
        public bool e08ab89d1dd0149261e84cb269d60eae { get; set; }
        public string e3ab9e19cc9d414fd7faf7395d8c64a5 { get; set; }
        public bool e7addd82f0fcf52ddceb89ba8e902c4b { get; set; }
        public bool f7115fc7cd40f271861908c2d41be4c5 { get; set; }
        public bool f76f28ddd87c83d95dd9222da11fa291 { get; set; }
        public string fe51ba5e7f3dccc3b72d46ff1fd5b86d { get; set; }
        public bool ff0885e010a2fd2d8ff723cf5170f75d { get; set; }
    }

    public class L23
    {
    }

    public class _48F4eae17f54d14ef57c6f249211efcd
    {
        public P36 p { get; set; }
        public L24 l { get; set; }
        public bool qex { get; set; }
    }

    public class P36
    {
        public bool _9bee2620057d443bb9fb713f7c992f0e { get; set; }
    }

    public class L24
    {
    }

    public class _4D3254608c803823d8b36d11761a5f49
    {
        public P37 p { get; set; }
        public L25 l { get; set; }
        public bool qex { get; set; }
    }

    public class P37
    {
    }

    public class L25
    {
    }

    public class _4D604dbad43a2551324f85db9b12954a
    {
        public P38 p { get; set; }
        public L26 l { get; set; }
        public bool qex { get; set; }
    }

    public class P38
    {
        public bool _3cb10d8a64e8823f9c149ef92053c038 { get; set; }
    }

    public class L26
    {
    }

    public class _519D9fa15fd1b105dce1db2c0a2b9a81
    {
        public P39 p { get; set; }
        public L27 l { get; set; }
        public bool qex { get; set; }
    }

    public class P39
    {
        public bool af13927e95df1353cf37a164e2c2d5b9 { get; set; }
    }

    public class L27
    {
    }

    public class _52Fc4c0bab32a66d19ff035b8cda855c
    {
        public P40 p { get; set; }
        public L28 l { get; set; }
        public bool qex { get; set; }
    }

    public class P40
    {
        public bool _5617c2eba57e50c27805ec4b85754d1b { get; set; }
    }

    public class L28
    {
    }

    public class _5400De163123fc2242cb0cb35104c546
    {
        public P41 p { get; set; }
        public L29 l { get; set; }
        public bool qex { get; set; }
    }

    public class P41
    {
        public bool _2810cf3650e49f9b4e752a49b9420ba6 { get; set; }
    }

    public class L29
    {
    }

    public class _546F5e4549d5c3e5113213901a0955ca
    {
        public P42 p { get; set; }
        public L30 l { get; set; }
        public bool qex { get; set; }
    }

    public class P42
    {
        public bool e4b02cea7a6d7879db8d4f9d4ee85f4a { get; set; }
    }

    public class L30
    {
    }

    public class _5619798Ccfda666bcf86b57e2295e8af
    {
        public P43 p { get; set; }
        public L31 l { get; set; }
        public bool qex { get; set; }
    }

    public class P43
    {
    }

    public class L31
    {
    }

    public class _568668Ed8c2e7e0c9ad6b5038fece156
    {
        public P44 p { get; set; }
        public L32 l { get; set; }
        public bool qex { get; set; }
    }

    public class P44
    {
        public bool _33c6763176079b3fc1dbec9f80ab7705 { get; set; }
        public bool e82587939d8c8e20276760f74280c0fb { get; set; }
    }

    public class L32
    {
    }

    public class _57Ad1c28eb6500bfcf66745d2adca38c
    {
        public P45 p { get; set; }
        public L33 l { get; set; }
        public bool qex { get; set; }
    }

    public class P45
    {
        public bool _81c86bb21d0991a7d717d3557ebca50e { get; set; }
        public bool _8f4dbc758a73716819e2c2780c2d5d34 { get; set; }
        public bool _9f66698cb60b3dba6dd0d93d0b90a003 { get; set; }
        public bool c5b6b9deb55642878a45129573e85703 { get; set; }
    }

    public class L33
    {
    }

    public class _5E5af8f80dc2a046fdc66102ffc12122
    {
        public P46 p { get; set; }
        public L34 l { get; set; }
        public bool qex { get; set; }
    }

    public class P46
    {
        public bool _7eb1503ce5e8c359c67d9429e46ae636 { get; set; }
        public bool cedb5f0b55bb5fdffbe64bec4b2ee3ca { get; set; }
    }

    public class L34
    {
    }

    public class _65D114d7d4e0f4e43486f3333fd05cdd
    {
        public P47 p { get; set; }
        public L35 l { get; set; }
        public bool qex { get; set; }
    }

    public class P47
    {
        public bool _5acf8c5db742aa24fdee4924a1a426a2 { get; set; }
    }

    public class L35
    {
    }

    public class _6999A0b22e9fc2ff6c338e9839965238
    {
        public P48 p { get; set; }
        public L36 l { get; set; }
        public bool qex { get; set; }
    }

    public class P48
    {
    }

    public class L36
    {
    }

    public class _69Eb081996ceb64b16632f2f70b6dd82
    {
        public P49 p { get; set; }
        public L37 l { get; set; }
        public bool qex { get; set; }
    }

    public class P49
    {
        public bool _14f190bffef6b265b47f0606cde52c3d { get; set; }
        public bool _426f2b379502974c3237fd47e278882c { get; set; }
        public bool _6ceed04aa64fd5821a904885b024fafa { get; set; }
        public bool ae81fb6c9d26573dc5d0b2511727fea2 { get; set; }
        public bool c32acef64510cf9ed23a294911edbd13 { get; set; }
    }

    public class L37
    {
    }

    public class _6Be7ca7396b3cddece910ac2517156b5
    {
        public P50 p { get; set; }
        public L38 l { get; set; }
        public bool qex { get; set; }
    }

    public class P50
    {
        public bool _16cfa41e1dedd8cd4eeb02a52e01dfdb { get; set; }
    }

    public class L38
    {
    }

    public class _6E5d85cb48b33b7d214bae2b7617853c
    {
        public P51 p { get; set; }
        public L39 l { get; set; }
        public bool qex { get; set; }
    }

    public class P51
    {
        public bool af069090f87d0afc94dca34ec07d2b87 { get; set; }
        public bool babe870c0e3313f8e57c49b40cadca58 { get; set; }
    }

    public class L39
    {
    }

    public class _6Fa9853da3ca096111937df4db810fde
    {
        public P52 p { get; set; }
        public L40 l { get; set; }
        public bool qex { get; set; }
    }

    public class P52
    {
        public bool ab93588338e21c1330f638f1a2450297 { get; set; }
    }

    public class L40
    {
    }

    public class _70Afcc770a54f88c3e94c2db1c1d35be
    {
        public P53 p { get; set; }
        public L41 l { get; set; }
        public bool qex { get; set; }
    }

    public class P53
    {
        public bool dfda63b579f42990e22bfbb34e6bb2b1 { get; set; }
    }

    public class L41
    {
    }

    public class _725794B89aa16d41efa1d9673fe59264
    {
        public P54 p { get; set; }
        public L42 l { get; set; }
        public bool qex { get; set; }
    }

    public class P54
    {
        public bool _15a4af51677297014b12224b8e07de3b { get; set; }
        public bool _9f8201049dd0b67f113c804ee5a61efc { get; set; }
    }

    public class L42
    {
    }

    public class _748910795D2438fc5f7c2cd5880f7600
    {
        public P55 p { get; set; }
        public L43 l { get; set; }
        public bool qex { get; set; }
    }

    public class P55
    {
    }

    public class L43
    {
    }

    public class _7879A0608f8451beb8d7e44b862a5abc
    {
        public P56 p { get; set; }
        public L44 l { get; set; }
        public bool qex { get; set; }
    }

    public class P56
    {
        public int _4bf9b04d2d462d81231417819e271a5f { get; set; }
    }

    public class L44
    {
    }

    public class _78C189896a493910bf19d7ef30dbae29
    {
        public P57 p { get; set; }
        public L45 l { get; set; }
        public bool qex { get; set; }
    }

    public class P57
    {
        public bool _72c0f02444b62fa8385ca267d9052137 { get; set; }
    }

    public class L45
    {
    }

    public class _7A18c5d64508be84f073deaf5a4067c4
    {
        public P58 p { get; set; }
        public L46 l { get; set; }
        public bool qex { get; set; }
    }

    public class P58
    {
        public bool _44273ead0bca12991479e98ae73cf8c5 { get; set; }
        public bool _6b548f674fe570eb9c76aff6a6827b42 { get; set; }
        public bool _7331a8a4b5fb6acf7968629934a229e7 { get; set; }
        public bool _7dd06b469a36dd81e9a9c972ce86f11e { get; set; }
        public bool a6f9d4c93f0421088e1584eae7d3674a { get; set; }
        public bool d3a7850f615828a50315bfdf04109821 { get; set; }
        public bool f091672721fc04eb3564f408b3e646f7 { get; set; }
    }

    public class L46
    {
    }

    public class _7B8b228c8838a3c83a240a7cbdd64f67
    {
        public P59 p { get; set; }
        public L47 l { get; set; }
        public bool qex { get; set; }
    }

    public class P59
    {
        public bool _517411206c3aaf4d86ac4b5015b4e3af { get; set; }
        public bool _5a0b890202aa215a5a7f31991de3afba { get; set; }
        public bool babdd3e626e59955167dd31a2b98d93d { get; set; }
    }

    public class L47
    {
    }

    public class _7Dafe49de69c6e063ee69b6aff3cc111
    {
        public P60 p { get; set; }
        public L48 l { get; set; }
        public bool qex { get; set; }
    }

    public class P60
    {
        public bool e2d4d8d35732661cb2b0180ced4d0c2d { get; set; }
    }

    public class L48
    {
    }

    public class _80E2ab32e819faa407c840b9e4e23953
    {
        public P61 p { get; set; }
        public L49 l { get; set; }
        public bool qex { get; set; }
    }

    public class P61
    {
        public bool _131df1b73a4995ae3b0d65d73e516a5d { get; set; }
        public bool _2955345422cc6cfa9b8e4ffa98194a76 { get; set; }
    }

    public class L49
    {
    }

    public class _8225863Ca091fba8bfd94f1a1dae7091
    {
        public P62 p { get; set; }
        public L50 l { get; set; }
        public bool qex { get; set; }
    }

    public class P62
    {
        public bool c70623adc26934453be35299db403133 { get; set; }
    }

    public class L50
    {
    }

    public class _84C61c2b1c50ec5123faa391b9261184
    {
        public P63 p { get; set; }
        public L51 l { get; set; }
        public bool qex { get; set; }
    }

    public class P63
    {
    }

    public class L51
    {
    }

    public class _87Bab2d6a814df80475e8773486cbd5c
    {
        public P64 p { get; set; }
        public L52 l { get; set; }
        public bool qex { get; set; }
    }

    public class P64
    {
        public bool _913424980e219898b28bdf39efd05e87 { get; set; }
    }

    public class L52
    {
    }

    public class _8Cd3cce694b5cf6128f806942d5352cd
    {
        public P65 p { get; set; }
        public L53 l { get; set; }
        public bool qex { get; set; }
    }

    public class P65
    {
    }

    public class L53
    {
    }

    public class _8Df26d8baf4eb30273425c3150fba6a0
    {
        public P66 p { get; set; }
        public L54 l { get; set; }
        public bool qex { get; set; }
    }

    public class P66
    {
        public bool d71f5281d23877fb16e51afe6fa0db15 { get; set; }
        public bool f6fb87464ed36798cfb1e6b5f2b6f9e5 { get; set; }
    }

    public class L54
    {
    }

    public class _8Ef9cc057aff11679e6776353a198f5c
    {
        public P67 p { get; set; }
        public L55 l { get; set; }
        public bool qex { get; set; }
    }

    public class P67
    {
        public bool f75356c33a82b6a2c5ad1fade572b3b9 { get; set; }
    }

    public class L55
    {
    }

    public class _8Ff6917bc74043ed4a76752b4d8c9ae3
    {
        public P68 p { get; set; }
        public L56 l { get; set; }
        public bool qex { get; set; }
    }

    public class P68
    {
        public string _663f886eb589b66770d4e578842e62ac { get; set; }
        public bool d05005147e2b93bff31a9324fb82a3ec { get; set; }
    }

    public class L56
    {
    }

    public class _919C32fd8a384e3660a325c8b197e3a9
    {
        public P69 p { get; set; }
        public L57 l { get; set; }
        public bool qex { get; set; }
    }

    public class P69
    {
        public bool f4a453646b021ba4e515b53e84c8950b { get; set; }
    }

    public class L57
    {
    }

    public class _932A926d6aa4f347b7d0f918eb0ad0b5
    {
        public P70 p { get; set; }
        public L58 l { get; set; }
        public bool qex { get; set; }
    }

    public class P70
    {
        public bool _5826ebc561370b032b106ffa74e996ee { get; set; }
    }

    public class L58
    {
    }

    public class _987C220b519c889274052f815cb2f353
    {
        public P71 p { get; set; }
        public L59 l { get; set; }
        public bool qex { get; set; }
    }

    public class P71
    {
        public bool _0f485640f3c48d632035310f46a518ca { get; set; }
        public bool d19ab378e197cd5b171b0b0032263956 { get; set; }
    }

    public class L59
    {
    }

    public class _9E031ca52113ba76b2cc892844a88851
    {
        public P72 p { get; set; }
        public L60 l { get; set; }
        public bool qex { get; set; }
    }

    public class P72
    {
    }

    public class L60
    {
    }

    public class A16a7cdeb73250bea3d9ecdb17e8b390
    {
        public P73 p { get; set; }
        public L61 l { get; set; }
        public bool qex { get; set; }
    }

    public class P73
    {
        public bool _15cc3644f5ebaa9107e07f4c14248a4a { get; set; }
        public bool _4730b74fda3c6e0b2ac30c47fbf5cea8 { get; set; }
        public bool _724faf7fc10c41433915c7cb70a22d8c { get; set; }
        public bool a9af916f374edf10fc56d24dd606d766 { get; set; }
    }

    public class L61
    {
    }

    public class A28b33540d899b239bf6eccc4904a1da
    {
        public P74 p { get; set; }
        public L62 l { get; set; }
        public bool qex { get; set; }
    }

    public class P74
    {
        public bool f0d7586e6b0af94f8dcb1c3419aab13f { get; set; }
    }

    public class L62
    {
    }

    public class A60ed86a010588f48d614cb854e00dd3
    {
        public P75 p { get; set; }
        public L63 l { get; set; }
        public bool qex { get; set; }
    }

    public class P75
    {
        public bool _0bb9ca9c6977806957cc0c0ee9f3b886 { get; set; }
        public bool _47ad004d88fa28d42349f15f799239e6 { get; set; }
        public bool _47f70321a258d9ca29fff06faa2fc858 { get; set; }
    }

    public class L63
    {
    }

    public class A7c29e6af4330be684d07a1d0af658ed
    {
        public P76 p { get; set; }
        public L64 l { get; set; }
        public bool qex { get; set; }
    }

    public class P76
    {
        public bool e81f2fb43c0a8a14f277d0a59d8c1188 { get; set; }
    }

    public class L64
    {
    }

    public class A8c0770b67ad2779d6f4964bce2362fb
    {
        public P77 p { get; set; }
        public L65 l { get; set; }
        public bool qex { get; set; }
    }

    public class P77
    {
        public float a94baf448e9d11ada31b2ff4290df8cb { get; set; }
        public string afede4682ab504a7bc304a8a48e96b4f { get; set; }
    }

    public class L65
    {
    }

    public class B4e9ea67e1d3426d3b078ab98465b817
    {
        public P78 p { get; set; }
        public L66 l { get; set; }
        public bool qex { get; set; }
    }

    public class P78
    {
        public bool dc64dbc2238bdd285d42cecd34a3b620 { get; set; }
    }

    public class L66
    {
    }

    public class Be9638a9bdf8422ed3f5a6c6b3d6a516
    {
        public P79 p { get; set; }
        public L67 l { get; set; }
        public bool qex { get; set; }
    }

    public class P79
    {
        public bool _07614dad80da34fd370900ba3ce23002 { get; set; }
        public bool _55a4175a7d9d7a3c15890bfd6144590e { get; set; }
        public bool _5e9610e15f1ea1edd0178c17f926c5fc { get; set; }
        public bool a443a58fd85811e3d49adef97aafdfe3 { get; set; }
        public bool b65342d9db901bfb02956c969344fad7 { get; set; }
        public bool c2783de7c766040f819ffb294b27601a { get; set; }
    }

    public class L67
    {
    }

    public class C19cc5d4211286e6b80a49dffbcb2065
    {
        public P80 p { get; set; }
        public L68 l { get; set; }
        public bool qex { get; set; }
    }

    public class P80
    {
    }

    public class L68
    {
    }

    public class C2936192e09a300b2323146b94b94d49
    {
        public P81 p { get; set; }
        public L69 l { get; set; }
        public bool qex { get; set; }
    }

    public class P81
    {
        public bool _8e3b1960071cd57c0088f102ac19ec72 { get; set; }
    }

    public class L69
    {
    }

    public class C76bd1e48217d6516a6120ab8e1a77a9
    {
        public P82 p { get; set; }
        public L70 l { get; set; }
        public bool qex { get; set; }
    }

    public class P82
    {
        public bool _670e866093fcd6dacbe15c5734a8273a { get; set; }
    }

    public class L70
    {
    }

    public class C7a0564cd779806f1b4985cd8351688e
    {
        public P83 p { get; set; }
        public L71 l { get; set; }
        public bool qex { get; set; }
    }

    public class P83
    {
        public bool _38d3a612eaa2ac59e21321c659565b61 { get; set; }
        public bool f8fd7cd2dc317a81ec7b3b5c33940957 { get; set; }
    }

    public class L71
    {
    }

    public class C90dc381159282fe1892f45b4e34474d
    {
        public P84 p { get; set; }
        public L72 l { get; set; }
        public bool qex { get; set; }
    }

    public class P84
    {
        public bool _541605322e6c5f39a0a6fee9d0852810 { get; set; }
        public bool _7cab67e8645b0d95f96df38d592e0b45 { get; set; }
        public bool a34cd56a24085aa00e1fa99be1119f2a { get; set; }
    }

    public class L72
    {
    }

    public class Cb26bc43780b8850429c3361f16393bb
    {
        public P85 p { get; set; }
        public L73 l { get; set; }
        public bool qex { get; set; }
    }

    public class P85
    {
        public bool c1f475230dacdd68db236b1bd8ed9ce4 { get; set; }
    }

    public class L73
    {
    }

    public class D6cc94cc0fc4d66dcef28865acf61340
    {
        public P86 p { get; set; }
        public L74 l { get; set; }
        public bool qex { get; set; }
    }

    public class P86
    {
        public bool a6b9b9e0dc1a9ab1d71705ca1883a44b { get; set; }
        public bool b4f9fbd8e6863bf4b67d432db90367cb { get; set; }
        public bool cf7809f98311b6963f0b7846b5b86960 { get; set; }
        public bool e55a95e7bdff2be7eeac05a19fb5edb2 { get; set; }
    }

    public class L74
    {
    }

    public class D7765c74deaaa5fda26820943dfa4505
    {
        public P87 p { get; set; }
        public L75 l { get; set; }
        public bool qex { get; set; }
    }

    public class P87
    {
        public string efac6108ebe61e3f05dfe94f7fed3577 { get; set; }
    }

    public class L75
    {
    }

    public class D918d46152cb1d958fc00947d64950a9
    {
        public P88 p { get; set; }
        public L76 l { get; set; }
        public bool qex { get; set; }
    }

    public class P88
    {
        public bool _09b47335b393ecfc7a6b13effc962f06 { get; set; }
    }

    public class L76
    {
    }

    public class Dc5353102643a57d669296e71c3454f5
    {
        public P89 p { get; set; }
        public L77 l { get; set; }
        public bool qex { get; set; }
    }

    public class P89
    {
    }

    public class L77
    {
    }

    public class E1ef1f1eee8124c7582d69e9e3f38443
    {
        public P90 p { get; set; }
        public L78 l { get; set; }
        public bool qex { get; set; }
    }

    public class P90
    {
        public bool _0c4fa98879112c4ce6ed59420970a76e { get; set; }
        public bool _76e90fee95509c2dbd660d8f027ac37c { get; set; }
    }

    public class L78
    {
    }

    public class E42bb34173aaba74caf60de2dabb1e9e
    {
        public P91 p { get; set; }
        public L79 l { get; set; }
        public bool qex { get; set; }
    }

    public class P91
    {
    }

    public class L79
    {
    }

    public class E887b17e0ed055dad3d6bdb4a0bbcd03
    {
        public P92 p { get; set; }
        public L80 l { get; set; }
        public bool qex { get; set; }
    }

    public class P92
    {
        public bool _1d7c7e36710f7af88bd45959fa74c8c0 { get; set; }
        public bool _6d0b2dea043ba852c49579e9935f4424 { get; set; }
        public bool _75718dc5f308c98c2fe6c2ae26c2ecea { get; set; }
    }

    public class L80
    {
    }

    public class E9c1cdafdf0de769c8e815c1e605678a
    {
        public P93 p { get; set; }
        public L81 l { get; set; }
        public bool qex { get; set; }
    }

    public class P93
    {
        public bool _1a575b2675f3565cc803451d6aa84e88 { get; set; }
    }

    public class L81
    {
    }

    public class Eb7aa23cd8cf072e0db7d1199d045f14
    {
        public P94 p { get; set; }
        public L82 l { get; set; }
        public bool qex { get; set; }
    }

    public class P94
    {
        public bool e540041d41cc0fcfc84991110763dc61 { get; set; }
    }

    public class L82
    {
    }

    public class Edf5c87670004cdfb60960d92155a319
    {
        public P95 p { get; set; }
        public L83 l { get; set; }
        public bool qex { get; set; }
    }

    public class P95
    {
        public bool _2a9189d3516d8b41a2cc4bde9dbcd3ee { get; set; }
    }

    public class L83
    {
    }

    public class Ee518c44cb4e028e93f7ed7a7ef5b434
    {
        public P96 p { get; set; }
        public L84 l { get; set; }
        public bool qex { get; set; }
    }

    public class P96
    {
        public bool e6828e76c2cb016725cad0774e14453b { get; set; }
    }

    public class L84
    {
    }

    public class Eea4e102a56972c9d76a5097e1332292
    {
        public P97 p { get; set; }
        public L85 l { get; set; }
        public bool qex { get; set; }
    }

    public class P97
    {
        public bool _271c5747c5d825ad02e0ae3e106a4b2b { get; set; }
        public bool ba1b59bd49abfec3f0366736f6076d36 { get; set; }
    }

    public class L85
    {
    }

    public class Eefe6b0ba93542b043c85ee68ec68d5d
    {
        public P98 p { get; set; }
        public L86 l { get; set; }
        public bool qex { get; set; }
    }

    public class P98
    {
        public bool _00097e3aad2beecc98dde3fb6f30a2cd { get; set; }
        public bool _1ebd468e67c84f94507888409d7193e7 { get; set; }
    }

    public class L86
    {
    }

    public class F32ccf5136ea284a177598172705431b
    {
        public P99 p { get; set; }
        public L87 l { get; set; }
        public bool qex { get; set; }
    }

    public class P99
    {
        public bool _303ad1a5eedffa753154ef2c6083a4e5 { get; set; }
        public bool _48d7c64d7adf7cbd2f84bfcb56bd6d62 { get; set; }
        public bool _4a4821fbdaf0ad6813abb69f4449ab94 { get; set; }
    }

    public class L87
    {
    }

    public class F396db07393edc76686eea077d7eaeb3
    {
        public P100 p { get; set; }
        public L88 l { get; set; }
        public bool qex { get; set; }
    }

    public class P100
    {
        public bool edbf7d67eee710ed4db977d909356070 { get; set; }
    }

    public class L88
    {
    }

    public class F41a40539142ff53c4a8c004afb4b52f
    {
        public P101 p { get; set; }
        public L89 l { get; set; }
        public bool qex { get; set; }
    }

    public class P101
    {
    }

    public class L89
    {
    }

    public class F8fad127506e737a65da0a394ca69abc
    {
        public P102 p { get; set; }
        public L90 l { get; set; }
        public bool qex { get; set; }
    }

    public class P102
    {
        public bool _5493d13497245ab460765c97d709c8ab { get; set; }
        public bool _9a7b566656e63ff309bcaf621e3f01b6 { get; set; }
        public bool b8b2d06568fda0b73b2327bb02d8613a { get; set; }
        public bool c2fabc88e63c810ec4d439ece96aa56b { get; set; }
    }

    public class L90
    {
    }

    public class Fb18df451b5f046d19e27ed6c76e8d8b
    {
        public P103 p { get; set; }
        public L91 l { get; set; }
        public bool qex { get; set; }
    }

    public class P103
    {
        public bool _4766686dc7ccd92780ebdd9a997321cf { get; set; }
    }

    public class L91
    {
    }

    public class Encryption
    {
        public string key_id { get; set; }
        public string public_key { get; set; }
        public string version { get; set; }
    }

    public class Signal_Collection_Config
    {
        public int bbs { get; set; }
        public object ctw { get; set; }
        public int dbs { get; set; }
        public int fd { get; set; }
        public Hbc hbc { get; set; }
        public int i { get; set; }
        public object rt { get; set; }
        public int sbs { get; set; }
        public Sc sc { get; set; }
        public int sid { get; set; }
    }

    public class Hbc
    {
        public int hbbi { get; set; }
        public int hbcbc { get; set; }
        public int hbi { get; set; }
        public string hbv { get; set; }
        public int hbvbc { get; set; }
    }

    public class Sc
    {
        public int[][] c { get; set; }
        public int t { get; set; }
    }

    public class Consent_Dialog_Config
    {
        public bool is_user_linked_to_fb { get; set; }
        public bool should_show_consent_dialog { get; set; }
        public bool should_show_logged_out_cnil_redesign { get; set; }
        public object should_use_winning_variant_qe { get; set; }
    }

    public class Www_Routing_Config
    {
        public object[] frontend_and_proxygen_routes { get; set; }
        public string frontend_only_routes_COMMENT { get; set; }
        public Frontend_Only_Routes[] frontend_only_routes { get; set; }
    }

    public class Frontend_Only_Routes
    {
        public string path { get; set; }
        public string destination { get; set; }
        public string COMMENT { get; set; }
        public string frontend_gk { get; set; }
        public bool in_vpn_dogfooding { get; set; }
    }

}
