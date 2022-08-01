 using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public interface IUsuarioRepository:IRepository<Usuario>
    {
        Usuario GetByIdPasswd(string usuario,string password);
        bool BuscarUsuarioPorId(string usurio);

    }
}
