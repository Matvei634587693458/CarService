using CarServiceSite.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceSite.Core.OutputModels
{
    public class CommentOutputModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rate { get; set; }
        public ClientOutputModel Client { get; set; }
    }
}
