using System;
using System.Collections.Generic;
using System.Linq;
using BusinessOrderService.Dto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessOrderService.Controllers
{
    [TestClass]

    public class BusinessOrdersServiceTest
    {
        List<BusinessOrder> businessOrders;
        List<Stop> stops;

        public BusinessOrdersServiceTest()
        {
            businessOrders = BusinessOrdersData.GetBusinessOrders();
            stops = BusinessOrdersData.GetStops();
        }

        [TestMethod]
        public void GetDuration1()
        {
            //İş emri sorunsuz başlamış, arada 10 dk bir kesinti olmuş.
            DateTime boStartTime = new DateTime(2017, 1, 1, 8, 0, 0);
            DateTime boEndTime = new DateTime(2017, 1, 1, 16, 0, 0);
            DateTime stopStartTime = new DateTime(2017, 1, 1, 10, 0, 0);
            DateTime stopEndTime = new DateTime(2017, 1, 1, 10, 10, 0);
            TimeSpan timeSpan = BusinessOrdersService.GetDuration(boStartTime, boEndTime, stopStartTime, stopEndTime);
            Assert.AreEqual(10, timeSpan.TotalMinutes);
        }


        [TestMethod]
        public void GetDuration2()
        {
            //İş emri sorunsuz başlamış, bir hata olmuş ve iş emri sonuna kadar devam etmiş
            DateTime boStartTime = new DateTime(2017, 1, 1, 8, 0, 0);
            DateTime boEndTime = new DateTime(2017, 1, 1, 16, 0, 0);
            DateTime stopStartTime = new DateTime(2017, 1, 1, 15, 0, 0);
            DateTime stopEndTime = new DateTime(2017, 1, 1, 16, 30, 0);
            TimeSpan timeSpan = BusinessOrdersService.GetDuration(boStartTime, boEndTime, stopStartTime, stopEndTime);
            Assert.AreEqual(60, timeSpan.TotalMinutes);
        }

        [TestMethod]
        public void GetDuration3()
        {
            //İş emri sorunlu başlamış, bu iş emri içinde çözülmüş
            DateTime boStartTime = new DateTime(2017, 1, 1, 16, 0, 0);
            DateTime boEndTime = new DateTime(2017, 1, 2, 0, 0, 0);
            DateTime stopStartTime = new DateTime(2017, 1, 1, 15, 0, 0);
            DateTime stopEndTime = new DateTime(2017, 1, 1, 16, 30, 0);
            TimeSpan timeSpan = BusinessOrdersService.GetDuration(boStartTime, boEndTime, stopStartTime, stopEndTime);
            Assert.AreEqual(30, timeSpan.TotalMinutes);
        }


        [TestMethod]
        public void GetDuration4()
        {
            //İş emri sorunlu başlamış, bu iş emri sonuna kadar devam etmiş
            DateTime boStartTime = new DateTime(2017, 1, 2, 0, 0, 0);
            DateTime boEndTime = new DateTime(2017, 1, 2, 8, 0, 0);
            DateTime stopStartTime = new DateTime(2017, 1, 1, 23, 0, 0);
            DateTime stopEndTime = new DateTime(2017, 1, 2, 8, 30, 0);
            TimeSpan timeSpan = BusinessOrdersService.GetDuration(boStartTime, boEndTime, stopStartTime, stopEndTime);
            Assert.AreEqual(60 * 8, timeSpan.TotalMinutes);
        }


    }
}