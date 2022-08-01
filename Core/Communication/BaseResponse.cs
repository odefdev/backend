
using Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Communication
{

    public abstract class BaseResponse<TEntity>
    {
        public bool Success { get; private set ; }
        public string Message { get; private set; }
        public TEntity Resource { get; private set; }

        protected BaseResponse(TEntity resource)
        {
            Success = true;
            Message = string.Empty;
            Resource = resource;
        }

        protected BaseResponse(string message)
        {
            Success = false;
            Message = message;
            Resource = default;
        }

        protected BaseResponse()
        {
        }
    }

    public class UsuarioResponse : BaseResponse<UsuarioDto>
    {
        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="category">Saved category.</param>
        /// <returns>Response.</returns>
        public UsuarioResponse(UsuarioDto usuarioDto) : base(usuarioDto)
        { }

        /// <summary>
        /// Creates am error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public UsuarioResponse(string message) : base(message)
        { }
    }
}
