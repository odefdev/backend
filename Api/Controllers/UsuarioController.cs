using Microsoft.AspNetCore.Mvc;
using Core.Communication;
using Core.Dto;
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

        [HttpGet]
        [ProducesResponseType(typeof(BaseResponse<UsuarioDto>), 200)]
        public async Task<ActionResult<BaseResponse<UsuarioDto>>> GetEmpleados(UsuarioDto usuarioDto)
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
        [HttpPost]
        public ActionResult<BaseResponse<UsuarioDto>> AgregarUsuario([FromBody] UsuarioDto usuario)
        {
            return CreatedAtRoute("GetUsuario",new { user=usuario.User},usuario);//esto envia status code 201
        }
    }
}
