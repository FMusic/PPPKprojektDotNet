using PPPKprojektDotNet.Datebase.I7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPPKprojektDotNet.Datebase
{
    public static class Ishod7
    {
        public static IList<Vehicle> GetVehicles()
        {
            var context = new pppk1dbEntities1();
            IList<Vehicle> toRet = context.Vehicles.ToList();
            return toRet;
        }

        public static int CreateService(CarService cs)
        {
            var context = new pppk1dbEntities1();
            context.CarServices.Add(cs);
            return context.SaveChanges();
        }

        public static IList<CarService> GetAllServices(Vehicle v)
        {
            var context = new pppk1dbEntities1();
            IList<CarService> toRet = context.CarServices.Where(x => x.Vehicle.Equals(v)).ToList();
            return toRet;
        }

        public static int UpdateCarService(CarService cs)
        {
            var context = new pppk1dbEntities1();
            CarService carService = context.CarServices.Single(x => x.IDService == cs.IDService);
            carService.Vehicle = cs.Vehicle;
            carService.Date = cs.Date;
            carService.VehicleID = cs.VehicleID;
            return context.SaveChanges();
        }

        public static int DeleteCarService(CarService cs)
        {
            var context = new pppk1dbEntities1();
            CarService cs1 = context.CarServices.Single(x => x.IDService == cs.IDService);
            context.CarServices.Remove(cs1);
            return context.SaveChanges();
        }


    }
}
