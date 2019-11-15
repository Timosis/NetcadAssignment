using NetcadAssignment.DataService;
using NetcadAssignment.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Business
{
    
    public interface IPolygonBusiness : IShapeBusiness<Polygon>
    {
        // Adding speacial method for Polygon 
    }

    public class PolygonBusiness : IPolygonBusiness
    {
        IFileDataService dataService;

        public PolygonBusiness(IFileDataService dataService)
        {
            this.dataService = dataService;
        }

        public async Task<Polygon> DrawShape(Polygon entity)
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
