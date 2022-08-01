using Microsoft.AspNetCore.Mvc;
using ModeloDto.Communication;
using ModeloDto.Dto;
using Service.Services;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(BaseResponse<UsuarioDTO>), 200)]
        public async Task<ActionResult<BaseResponse<UsuarioDTO>>> GetEmpleados(UsuarioDTO usuarioDto)
        {

            try
            {
                return Ok( this._usuarioService.GetByIdPasswd(usuarioDto.User, usuarioDto.Password));

         
            }
            catch (Exception ex)
            {

            
                return BadRequest(ex.ToString());
            }

            //return Ok(response);
        }
    }
}
