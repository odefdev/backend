

using Core.Entidades;
using Core.Communication;
using Core.Dto;


namespace Service.Services
{
    public interface IUsuarioService : IGenericService<Usuario>
    {
        BaseResponse<UsuarioDto> GetByIdPasswd(string usuario, string password);
        // BaseResponse<UsuarioDTO> Add(Usuario entity);
      
    }
}
