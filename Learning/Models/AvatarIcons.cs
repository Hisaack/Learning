using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Models
{
    public class AvatarIcon
    {
        public string IconPath { get; set; }

    }

    public static class Icon
    {
        public static List<AvatarIcon> LoadAvatarIcons()
        {
            var avatarIcons = new List<AvatarIcon>()
            {
                new AvatarIcon(){IconPath = "ms-appx:///Assets/female-01.png"},
                new AvatarIcon(){IconPath = "ms-appx:///Assets/female-02.png"},
                new AvatarIcon(){IconPath = "ms-appx:///Assets/female-03.png"},
                new AvatarIcon(){IconPath = "ms-appx:///Assets/male-01.png"},
                new AvatarIcon(){IconPath = "ms-appx:///Assets/male-02.png"},
                new AvatarIcon(){IconPath = "ms-appx:///Assets/male-03.png"}
            };
            return avatarIcons;
        }
        
    }
}
