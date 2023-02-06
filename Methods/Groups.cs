using Newtonsoft.Json;
using OpenVkNetApi.Models.FriendsModels;
using OpenVkNetApi.Models.GroupsModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Groups
    {
        private string AccessToken;
        private string InstanceUrl;
        OvkApi api = new OvkApi();
        //для использования методов не требующих авторизации
        public Groups() { }
        //для использования методов требующих авторизации
        public Groups(string token, string instance)
        {
            this.AccessToken = token;
            this.InstanceUrl = instance;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="Offset"></param>
        /// <param name="Count"></param>
        /// <param name="Fields"></param>
        /// <returns></returns>
        public async Task<GroupsList> Get(int UserId=0, int Offset = 0, int Count = 100, string Fields = "verified,has_photo,photo_max_orig,photo_max,photo_50,photo_100,photo_200,photo_200_orig,photo_400_orig,members_count")
        {
            return JsonConvert.DeserializeObject<dynamic>(await api.GetRequest($"{InstanceUrl}/method/Groups.get?access_token={AccessToken}&user_id={UserId}&offset={Offset}&count={Count}&fields={Fields}")).response.ToObject(typeof(GroupsList));
        }
    }
}
