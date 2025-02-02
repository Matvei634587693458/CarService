using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.Core.Dtos
{
    public class MasterDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int WorkState { get; set; }
        public int Rate { get; set; }
        public string PhotoPath { get; set; } = "images/empty-profile-photo.png";
        public List<CommentDto> Сomments { get; set; }

    }
}
