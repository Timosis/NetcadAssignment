using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Business
{
    public interface IShapeBusiness<TEntity>
    {
        Task<TEntity> DrawShape(TEntity entity);
    }
}
