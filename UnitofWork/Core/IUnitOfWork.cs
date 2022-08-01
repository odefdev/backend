

using Repository.Repository;

namespace UnitofWork.Core
{
    public interface IUnitOfWork :IDisposable
    {

        int Complete();
    }
}
