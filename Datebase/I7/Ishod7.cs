using PPPKprojektDotNet.Datebase.I7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace PPPKprojektDotNet.Datebase
{
    public static class Ishod7
    {
        public static IList<Vehicle> GetVehicles()
        {
            IList<Vehicle> toRet;
            using (var context = new pppk1dbEntities1())
            {
                toRet = context.Vehicles.ToList();
            }
            return toRet;
        }

        public static int CreateService(CarService cs)
        {
            using (var context = new pppk1dbEntities1())
            {
                context.CarServices.Add(cs);
                return context.SaveChanges();
            }
        }

        public static IList<CarService> GetAllServices(Vehicle v)
        {
            using (var context = new pppk1dbEntities1())
            {
                System.Data.Entity.DbSet<CarService> cs = context.CarServices;
                IList<CarService> toRet = cs.Where(x => x.VehicleID == v.IDVehicle).ToList();
                return toRet;
            }
        }

        public static int UpdateCarService(CarService cs)
        {
            using (var context = new pppk1dbEntities1())
            {
                CarService carService = context.CarServices.Single(x => x.IDService == cs.IDService);
                carService.Vehicle = cs.Vehicle;
                carService.Date = cs.Date;
                carService.VehicleID = cs.VehicleID;
                return context.SaveChanges();
            }
        }

        public static int DeleteCarService(CarService cs)
        {
            using (var context = new pppk1dbEntities1())
            {
                CarService cs1 = context.CarServices.Single(x => x.IDService == cs.IDService);
                context.CarServices.Remove(cs1);
                return context.SaveChanges();
            }
        }

        public static IList<ServiceItem> GetItemsForService(CarService cs) => cs.ServiceItems.ToList();

        public static int SaveItem(CarService cs, ServiceItem si)
        {
            using (var context = new pppk1dbEntities1())
            {
                si.CarService = cs;
                context.ServiceItems.Add(si);
                return context.SaveChanges();
            }
        }

        public static int DeleteItem(ServiceItem si)
        {
            using (var context = new pppk1dbEntities1())
            {
                ServiceItem si2 = context.ServiceItems.Single(x => x.IDItem == si.IDItem);
                context.ServiceItems.Remove(si2);
                return context.SaveChanges();
            }
        }

        public static int UpdateItem(ServiceItem si)
        {
            using(var context = new pppk1dbEntities1())
            {
                ServiceItem serviceItem = context.ServiceItems.Find(si.IDItem);
                serviceItem.Name = si.Name;
                serviceItem.CarServiceID = si.CarServiceID;
                serviceItem.TotalPrice = si.TotalPrice;
                return context.SaveChanges();
            }
        }

        public static string GetHtmlForVehicle(Vehicle v)
        {
            // TODO: Finish export to HTML
            StringBuilder sb = new StringBuilder();
            sb.Append("<!DOCTYPE html>");
            sb.Append("<html>");
            sb.Append("<body>");

            sb.Append("</body>");
            sb.Append("</html>");
            return sb.ToString();
        }
    }
}
