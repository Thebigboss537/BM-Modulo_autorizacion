using Auth.Models;
using Auth.Models.Dto;
using AutoMapper;

namespace Auth
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<UsuarioDto, Usuario>();
                config.CreateMap<Usuario, UsuarioDto>();

                config.CreateMap<RolDto, Rol>();
                config.CreateMap<Rol, RolDto>();

            });

            return mappingConfig;
        }

    }
}
