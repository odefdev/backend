using Infraestructura.Data;
using Repository.Repository;
using Repository.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitofWork.Core;

namespace UnitofWork.CoreImpl
{
    public class UnitOfWorkImpl : IUnitOfWork
    {
        private readonly ApplicationDbContext dbContext;


        public UnitOfWorkImpl(ApplicationDbContext applicationDbContext)
        {
            this.dbContext = applicationDbContext;
            //UsuarioRepository = new UsuarioRepositoryImpl(this.dbContext);

        }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
