using CarServiceSite.Core.OutputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.Core.InputModels
{
    public class CommentInputModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rate { get; set; }
        public ClientInputModel Client { get; set; }
    }
}
