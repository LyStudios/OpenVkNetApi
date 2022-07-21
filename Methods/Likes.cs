using Newtonsoft.Json;
using OpenVkNetApi.Models;
using OpenVkNetApi.Models.Likes;
using System.Threading.Tasks;

namespace OpenVkNetApi.Methods
{
    public class Likes
    {
        OVkApi api = new OVkApi();
        public async Task<LikesModel> Add(AuthorizedUser user, string type, int owner_id, int item_id)
        {
            return JsonConvert.DeserializeObject<LikesModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Likes.add?access_token={user.access_token}&type={type}&owner_id={owner_id}&item_id={item_id}"));
        }
        public async Task<LikesModel> Delete(AuthorizedUser user, string type, int owner_id, int item_id)
        {
            return JsonConvert.DeserializeObject<LikesModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Likes.delete?access_token={user.access_token}&type={type}&owner_id={owner_id}&item_id={item_id}"));
        }
        public async Task<bool> IsLiked(AuthorizedUser user, string type, int owner_id, int item_id, int user_id)
        {
            int liked = JsonConvert.DeserializeObject<IsLikedModel>(await api.GetRequestAsync($"{user.instanceUrl}/method/Likes.isLiked?access_token={user.access_token}&type={type}&owner_id={owner_id}&item_id={item_id}&user_id={user_id}")).response.liked;
            switch (liked)
            {
                case 0:
                    return false;
                case 1:
                    return true;
                default:
                    return false;
            }
        }
    }
}
