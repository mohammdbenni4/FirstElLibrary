using Elkood.Domain.Primitives.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICityRepository : IRepository
    {
        public IQueryable<TEntity> GetFilteredDate<TEntity>(DateOnly startDate, DateOnly endDate)
        where TEntity : BaseEntity<Guid>;
    }
}
