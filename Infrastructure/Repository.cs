using Heroes.Abstract;

namespace Heroes.Infrastructure
{
    public class Repository<T> : IRepository<T> where T : Entity
    {

    }
}