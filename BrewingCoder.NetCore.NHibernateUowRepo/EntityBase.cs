using BrewingCoder.NetCore.NHibernateUowRepo.Contracts;

namespace BrewingCoder.NetCore.NHibernateUowRepo
{
    public abstract class EntityBase : IEntity
    {
        public virtual uint Id { get; set; }
    }
}
