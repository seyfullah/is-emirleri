using System;
using System.Collections.Generic;
using BusinessOrderService.Dto;

namespace BusinessOrderService.Controllers
{
    public static class BusinessOrdersData
    {
        public static List<BusinessOrder> GetBusinessOrders()
        {
            List<BusinessOrder> businessOrders = new List<BusinessOrder>();
            businessOrders.Add(new BusinessOrder(1001, new DateTime(2017, 1, 1, 8, 0, 0), new DateTime(2017, 1, 1, 16, 0, 0)));
            businessOrders.Add(new BusinessOrder(1002, new DateTime(2017, 1, 1, 16, 0, 0), new DateTime(2017, 1, 2, 0, 0, 0)));
            businessOrders.Add(new BusinessOrder(1003, new DateTime(2017, 1, 2, 0, 0, 0), new DateTime(2017, 1, 2, 8, 0, 0)));
            businessOrders.Add(new BusinessOrder(1004, new DateTime(2017, 1, 2, 8, 0, 0), new DateTime(2017, 1, 2, 16, 0, 0)));
            businessOrders.Add(new BusinessOrder(1005, new DateTime(2017, 1, 2, 16, 0, 0), new DateTime(2017, 1, 3, 0, 0, 0)));
            businessOrders.Add(new BusinessOrder(1006, new DateTime(2017, 1, 3, 0, 0, 0), new DateTime(2017, 1, 3, 8, 0, 0)));
            businessOrders.Add(new BusinessOrder(1007, new DateTime(2017, 1, 3, 8, 0, 0), new DateTime(2017, 1, 3, 16, 0, 0)));
            businessOrders.Add(new BusinessOrder(1008, new DateTime(2017, 1, 3, 16, 0, 0), new DateTime(2017, 1, 4, 0, 0, 0)));
            businessOrders.Add(new BusinessOrder(1009, new DateTime(2017, 1, 4, 0, 0, 0), new DateTime(2017, 1, 4, 8, 0, 0)));
            return businessOrders;
        }

        public static List<Stop> GetStops()
        {
            List<Stop> stops = new List<Stop>();
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 1, 10, 0, 0), new DateTime(2017, 1, 1, 10, 10, 0)));
            stops.Add(new Stop("Arıza", new DateTime(2017, 1, 1, 10, 30, 0), new DateTime(2017, 1, 1, 11, 0, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 1, 12, 0, 0), new DateTime(2017, 1, 1, 12, 30, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 1, 14, 0, 0), new DateTime(2017, 1, 1, 14, 10, 0)));
            stops.Add(new Stop("Setup", new DateTime(2017, 1, 1, 15, 0, 0), new DateTime(2017, 1, 1, 16, 30, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 1, 18, 0, 0), new DateTime(2017, 1, 1, 18, 10, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 1, 20, 0, 0), new DateTime(2017, 1, 1, 20, 30, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 1, 22, 0, 0), new DateTime(2017, 1, 1, 22, 10, 0)));
            stops.Add(new Stop("Arge", new DateTime(2017, 1, 1, 23, 0, 0), new DateTime(2017, 1, 2, 08, 30, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 2, 10, 0, 0), new DateTime(2017, 1, 2, 10, 10, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 2, 12, 0, 0), new DateTime(2017, 1, 2, 12, 30, 0)));
            stops.Add(new Stop("Arıza", new DateTime(2017, 1, 2, 13, 0, 0), new DateTime(2017, 1, 2, 13, 45, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 2, 14, 0, 0), new DateTime(2017, 1, 2, 14, 10, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 2, 18, 0, 0), new DateTime(2017, 1, 2, 18, 10, 0)));
            stops.Add(new Stop("Arge", new DateTime(2017, 1, 2, 20, 0, 0), new DateTime(2017, 1, 3, 02, 10, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 3, 04, 0, 0), new DateTime(2017, 1, 3, 04, 30, 0)));
            stops.Add(new Stop("Setup", new DateTime(2017, 1, 3, 06, 0, 0), new DateTime(2017, 1, 3, 09, 30, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 3, 10, 0, 0), new DateTime(2017, 1, 3, 10, 10, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 3, 12, 0, 0), new DateTime(2017, 1, 3, 12, 30, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 3, 14, 0, 0), new DateTime(2017, 1, 3, 14, 10, 0)));
            stops.Add(new Stop("Arıza", new DateTime(2017, 1, 3, 15, 0, 0), new DateTime(2017, 1, 3, 18, 45, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 3, 20, 0, 0), new DateTime(2017, 1, 3, 20, 30, 0)));
            stops.Add(new Stop("Mola", new DateTime(2017, 1, 3, 22, 0, 0), new DateTime(2017, 1, 3, 22, 10, 0)));
            return stops;
        }


    }
}
