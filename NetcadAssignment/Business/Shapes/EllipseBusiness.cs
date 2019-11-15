using NetcadAssignment.DataService;
using NetcadAssignment.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Business
{

    public interface IEllipseBusiness : IShapeBusiness<Ellipse>
    {
        // Adding speacial method for Ellipse 
    }


    public class EllipseBusiness : IEllipseBusiness
    {
        IFileDataService dataService;

        public EllipseBusiness(IFileDataService dataService)
        {
            this.dataService = dataService;
        }

        public async Task<Ellipse> DrawShape(Ellipse entity)
        {
            try
            {
                await dataService.AddShape(entity);
            }
            catch 
            {

                return null;
            }
            return entity;
        }
    }
}
