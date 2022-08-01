
using Core.Communication;
using Core.Dto;
using Repository.Repository;
using Service.Services;
using System.Linq.Expressions;
using UnitofWork.Core;

namespace Service.ServicesImpl
{
    public class UsuarioServiceImpl : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioServiceImpl(IUnitOfWork unitOfWork, IUsuarioRepository repo) : base()
        {
            this._usuarioRepository = repo;
            this._unitOfWork = unitOfWork;
        }



        public BaseResponse<UsuarioDto> GetByIdPasswd(string usuario, string password)
        {
            bool usuarioExiste = this._usuarioRepository.BuscarUsuarioPorId(usuario);
            if (usuarioExiste)
            {
                var u = this._usuarioRepository.GetByIdPasswd(usuario, password);
                if (u == null)
                {
                    return new UsuarioResponse("Contraseña Incorrecta");
                }
                else
                {
                    UsuarioDto dto = new UsuarioDto();
                    dto.NombreUsuario = u.NombreUsuario;
                    dto.User = u.User;
                    return new UsuarioResponse(dto);
                }
            }
            else {
                return new UsuarioResponse("Usuario No Existe");
            }



        }
        
    }
    
}
