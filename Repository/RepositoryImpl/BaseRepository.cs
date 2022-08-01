using Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryImpl
{
    public abstract class BaseRepository
    {
        protected readonly ApplicationDbContext dbContext;

        public BaseRepository(ApplicationDbContext context)
        {
            dbContext = context;
        }
    }
}
