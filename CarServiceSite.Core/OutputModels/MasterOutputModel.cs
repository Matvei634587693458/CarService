using CarServiceSite.Core.Dtos;

namespace CarServiceSite.Core.OutputModels
{
    public class MasterOutputModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int WorkState { get; set; }
        public int Rate { get; set; }
        public string PhotoPath { get; set; }
        public List<CommentOutputModel> Сomments { get; set; }
    }
}
