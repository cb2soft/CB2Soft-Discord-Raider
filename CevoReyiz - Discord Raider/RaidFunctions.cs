using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CevoReyiz___Discord_Raider
{
    public class RaidFunctions
    {
        public static string returnstring(string returnme) { return returnme; }

        private class smessagestrings
        {
            public string content { get; set; }
            public string nonce { get; set; }
            public bool tts { get; set; }
        }



        private class caccountstrings
        {
            public string captcha_key { get; set; }
            public bool consent { get; set; }
            public string email { get; set; }
            public string fingerprint { get; set; }
            public string gift_code_sku_id { get; set; }
            public string invite { get; set; }
            public string password { get; set; }
            public string username { get; set; }
        }


        public static class funcs
        {
            public static HttpResponseMessage joinguild(string token, string invite, bool useproxy, string proxy)
            {
                HttpResponseMessage result;
                if (useproxy)
                {
                    Task<HttpResponseMessage> task = new HttpClient(new HttpClientHandler
                    {
                        Proxy = new WebProxy(proxy)
                    })
                    {
                        DefaultRequestHeaders =
                        {
                            {
                                "Authorization",
                                token
                            }
                        }
                    }.PostAsync("https://discordapp.com/api/v6/invite/" + invite, null);
                    result = task.Result;
                }
                else
                {
                    Task<HttpResponseMessage> task2 = new HttpClient
                    {
                        DefaultRequestHeaders =
                        {
                            {
                                "Authorization",
                                token
                            }
                        }
                    }.PostAsync("https://discordapp.com/api/v6/invite/" + invite, null);
                    result = task2.Result;
                }
                return result;


               /* DiscordMember member = new DiscordMember("NjAxMzQ0NDMyMzEwMzIxMjAy.YfkE5w.sZokEH6U22YbyYBNuhn8LgiZLt8");
                await member.JoinChannel(new[] { "UKngX83R", "HaxmeyHd" });
                await member.SendMessageToAll(textBox1.Text); */
            }

            public static HttpResponseMessage sendMultipleUserData(string token, object data)
            {
                /*if (!File.Exists(path))
                    return null;

                string  encoded = System.Convert.ToBase64String(File.ReadAllBytes(path));*/

                HttpResponseMessage result;
                HttpMethod method = new HttpMethod("PATCH");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token);
                HttpRequestMessage httpRequest = new HttpRequestMessage(method, "https://discord.com/api/v8/users/@me");
                httpRequest.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");

                result = client.SendAsync(httpRequest).Result;
                return result;
            }

            public static HttpResponseMessage sendSingleUserData(string token, object data)
            {
                /*OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Png fls | *.png";

                string encoded = string.Empty;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    encoded = System.Convert.ToBase64String(File.ReadAllBytes(fileDialog.FileName));
                }
                else
                    return null; */

                /*HttpResponseMessage result;
                HttpMethod method = new HttpMethod("PATCH");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token);
                HttpRequestMessage httpRequest = new HttpRequestMessage(method, "https://discord.com/api/v8/users/@me");
                httpRequest.Content = new StringContent(JsonConvert.SerializeObject(new
                {
                    avatar = "data:image/png;base64," + encoded
                    /*email = "cevatburak15@gmail.com",
                    password = "",
                    username = "cevoreyiz16"
                }), Encoding.UTF8, "application/json"); ;

                result = client.SendAsync(httpRequest).Result;
                return result; */

                HttpResponseMessage result;
                HttpMethod method = new HttpMethod("PATCH");
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token);
                HttpRequestMessage httpRequest = new HttpRequestMessage(method, "https://discord.com/api/v8/users/@me");
                httpRequest.Content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            //new
            //{
            //    avatar = "data:image/png;base64," + encoded
            //    /*email = "cevatburak15@gmail.com",
            //    password = "",
            //    username = "cevoreyiz16"*/
            //}), Encoding.UTF8, "application/json"); ;

                result = client.SendAsync(httpRequest).Result;
                return result;
            }



            public static HttpResponseMessage sendmessage(string token, string channelid, string message, bool ttsenabled, bool bypassantispam)
            {
                bool flag = !bypassantispam;
                HttpResponseMessage result;
                if (flag)
                {
                    result = new HttpClient
                    {
                        DefaultRequestHeaders =
                        {
                            {
                                "Authorization",
                                token
                            }
                        }
                    }.PostAsync("https://discordapp.com/api/v6/channels/" + channelid + "/messages", new StringContent(JsonConvert.SerializeObject(new RaidFunctions.smessagestrings
                    {
                        content = message,
                        nonce = null,
                        tts = ttsenabled
                    }), Encoding.UTF8, "application/json")).Result;
                }
                else
                {
                    Random random = new Random();
                    result = new HttpClient
                    {
                        DefaultRequestHeaders =
                        {
                            {
                                "Authorization",
                                token
                            }
                        }
                    }.PostAsync("https://discordapp.com/api/v6/channels/" + channelid + "/messages", new StringContent(JsonConvert.SerializeObject(new RaidFunctions.smessagestrings
                    {
                        content = message + " " + random.Next(),
                        nonce = null,
                        tts = ttsenabled
                    }), Encoding.UTF8, "application/json")).Result;
                }
                return result;
            }
            public static HttpResponseMessage sendReaction(string token, string channelID, string messageID, string emoji, bool useproxy, string proxy)
            {
                HttpResponseMessage result;
                if (useproxy)
                {
                    Task<HttpResponseMessage> task = new HttpClient(new HttpClientHandler
                    {
                        Proxy = new WebProxy(proxy)
                    })
                    {
                        DefaultRequestHeaders =
                        {
                            {
                                "Authorization",
                                token
                            }
                        }
                    }.PutAsync("https://discord.com/api/v8/channels/" + channelID + "/messages/" + messageID + "/reactions/" + emoji + "/@me", null);
                    result = task.Result;
                }
                else
                {
                    Task<HttpResponseMessage> task2 = new HttpClient
                    {
                        DefaultRequestHeaders =
                        {
                            {
                                "Authorization",
                                token
                            }
                        }
                    }.PutAsync("https://discord.com/api/v8/channels/"+channelID+"/messages/"+messageID+"/reactions/"+emoji+"/@me", null);
                    result = task2.Result;
                }
                return result;
            }
        }
    }
}
