using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetcadAssignment.Business;
using NetcadAssignment.Models;
using NetcadAssignment.Models.Enum;

namespace NetcadAssignment.Controllers
{
    public class HomeController : Controller
    {
        public ICircleBusiness circleBusiness;
        public IEllipseBusiness ellipseBusiness;
        public IPolygonBusiness polygonBusiness;
        public ISquareBusiness squareBusiness;
        public IFileBusiness fileBusiness;

        public HomeController( 
            ICircleBusiness circleBusiness,
            IEllipseBusiness ellipseBusiness, 
            IPolygonBusiness polygonBusiness, 
            ISquareBusiness squareBusiness,
            IFileBusiness fileBusiness
            )                                                            
        {
            this.circleBusiness = circleBusiness;
            this.ellipseBusiness = ellipseBusiness;
            this.polygonBusiness = polygonBusiness;
            this.squareBusiness = squareBusiness;
            this.fileBusiness = fileBusiness;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add_Shape()
        {
            return PartialView("~/Views/Home/AddShape.cshtml");
        }

        public async Task<RedirectToActionResult> Create_Shape(ShapeVm vm)
        {
            vm.Key = char.ToUpper(vm.Key);
            switch (vm.ShapeType)
            {
                case ShapeType.Circle:
                    await circleBusiness.DrawShape(new Circle(vm.LengthA, ShapeType.Circle,vm.IsFilled,vm.Key, (Color)Enum.Parse(typeof(Color), vm.Color), vm.BorderThickness,vm.BorderColor,vm.XCoordinate,vm.YCoordinate));
                    break;
                case ShapeType.Ellipse:
                    await ellipseBusiness.DrawShape( new Ellipse(vm.LengthA,vm.LengthB,ShapeType.Ellipse,vm.IsFilled, vm.Key, (Color)Enum.Parse(typeof(Color), vm.Color), vm.BorderThickness,vm.BorderColor,vm.XCoordinate,vm.YCoordinate));
                    break;
                case ShapeType.Polygon:
                     await polygonBusiness.DrawShape(new Polygon(vm.LengthA, vm.LengthB,ShapeType.Polygon, vm.IsFilled, vm.Key, (Color)Enum.Parse(typeof(Color), vm.Color), vm.BorderThickness,vm.BorderColor,vm.XCoordinate,vm.YCoordinate));
                    break;
                case ShapeType.Square:
                    await squareBusiness.DrawShape(new Square(vm.LengthA, ShapeType.Square, vm.IsFilled, vm.Key, (Color)Enum.Parse(typeof(Color), vm.Color), vm.BorderThickness,vm.BorderColor,vm.XCoordinate,vm.YCoordinate));
                    break;
                default:
                    break;
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<JsonResult> Get_Shape(char key)
        {
            key = char.ToUpper(key);
            var result = await fileBusiness.GetShapeFromFile(key);
            return Json(result);
        }
    }
}
