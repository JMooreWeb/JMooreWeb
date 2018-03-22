using AutoMapper;

namespace JMooreWeb.Data
{
   public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			//// Photo Mappings
			//CreateMap<Photo, PhotoViewModel>()
			//	.ForMember(p => p.ImageUrl, ex => ex.MapFrom(p => "data:image/jpg;base64," + Convert.ToBase64String(p.ImageData)))  // For manual mapping
			//	.ReverseMap();
		}
	}
}
