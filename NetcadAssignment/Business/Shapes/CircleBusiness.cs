using NetcadAssignment.DataService;
using NetcadAssignment.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Business
{

    public interface ICircleBusiness : IShapeBusiness<Circle>
    {
        // Adding speacial method for Ellipse 
    }

    public class CircleBusiness : ICircleBusiness
    {

        IFileDataService dataService;

        public CircleBusiness(IFileDataService dataService)
        {
            this.dataService = dataService;
        }


        public async Task<Circle> DrawShape(Circle entity)
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
