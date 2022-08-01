using Core.Entidades;
using Infraestructura.Data;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryImpl
{
    public class UsuarioRepositoryImpl : RepositoryImpl<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryImpl(ApplicationDbContext context) : base(context)
        {
        }

        public bool BuscarUsuarioPorId(string usurio)
        {   bool dato=false;
            try
            {
                var a = this.dbContext.Usuarios.Where(x => x.User == usurio).FirstOrDefault();
                if (a != null)
                {
                    dato = true;
                }
            }
            catch (Exception ex) { 
                dato = false;
            }
            return dato;
        }

        public Usuario GetByIdPasswd(string usuario, string password)
        {
            return this.dbContext.Usuarios.Where(x=>x.User==usuario).Where(x=>x.Password==password).FirstOrDefault()!;//se agrega ! para que sepa c# que yo me encargare si la respuesta es null
        }
    }
}
