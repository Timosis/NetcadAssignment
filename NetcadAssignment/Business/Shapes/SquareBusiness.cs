using NetcadAssignment.DataService;
using NetcadAssignment.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Business
{

    public interface ISquareBusiness : IShapeBusiness<Square>
    {
        // Adding speacial method for Square 
    }

    public class SquareBusiness : ISquareBusiness
    {

        IFileDataService dataService;

        public SquareBusiness(IFileDataService dataService)
        {
            this.dataService = dataService;
        }

        public async Task<Square> DrawShape(Square entity)
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
