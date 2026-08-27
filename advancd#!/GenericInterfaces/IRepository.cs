using System;
using System.Collections.Generic;
using System.Text;

namespace advancd__.GenericInterfaces
{
    internal interface IRepository<IEntity>
    {
        void Add(IEntity entity);

        void Remove(IEntity entity);

        IEntity? GetById(int id);

        List<IEntity> GetAllOfProudct();
    }
}
