using AutoMapper;
using MicroS.Services.CouponAPI.Models;
using MicroS.Services.CouponAPI.Models.Dto;

namespace MicroS.Services.CouponAPI
{
    public class MappingConfig
    {

        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
