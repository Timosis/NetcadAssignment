using NetcadAssignment.DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetcadAssignment.Business
{

    public interface IFileBusiness
    {
        Task<Object> GetShapeFromFile(char key);
    }


    public class FileBusiness : IFileBusiness
    {

        IFileDataService dataService;

        public FileBusiness(IFileDataService dataService)
        {
            this.dataService = dataService;
        }

        public Task<Object> GetShapeFromFile(char key)
        {
            var result = dataService.GetShape(key);

            return result;
        }
    }
}
