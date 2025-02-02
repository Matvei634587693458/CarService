using AutoMapper;
using CarServiceSite.BLL.Mappers;
using CarServiceSite.Core.Dtos;
using CarServiceSite.Core.InputModels;
using CarServiceSite.Core.OutputModels;
using CarServiceSite.DAL;

namespace CarServiceSite.BLL
{

    public class MasterManager
    {

        private MasterRepository _masterRepository;
        private Mapper _mapper;

        public MasterManager()
        {
            this._masterRepository = new MasterRepository();
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MasterMapperProfile());
                cfg.AddProfile(new ClientMapperProfile());
                cfg.AddProfile(new CommentMapperProfile());
            });
            this._mapper = new Mapper(configuration);
        }

        public MasterOutputModel? GetMasterOutputModelById(int id)
        {
            MasterDto? dto = this._masterRepository.GetMasterDtoById(id);
            if (dto != null)
            {
                MasterOutputModel result = this._mapper.Map<MasterOutputModel>(dto);
                return result;
            }
            else
            {
                return null;
            }
        }

        public void AddCommentForMasterByMasterId(int masterId, CommentInputModel comment) 
        {
            CommentDto dto = this._mapper.Map<CommentDto>(comment);
            this._masterRepository.AddCommentForMasterByMasterId(masterId, dto);
        }

    }
}
