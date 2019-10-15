using System;
using System.Threading.Tasks;

namespace DatingApp.API.Model
{
    public class Like
    {
        public int LikerId { get; set; }
        public int LikeeId { get; set; }

        public User Liker { get; set; }

        public User Likee { get; set; }

        public static implicit operator Task<object>(Like v)
        {
            throw new NotImplementedException();
        }
    }
}