using System;
using System.Collections.Generic;
using System.Linq;
using BusinessOrderService.Dto;

namespace BusinessOrderService.Controllers
{
    public class BusinessOrdersService
    {
        public List<List<string>> GetBusinessOrderReports()
        {
            var businessOrders = BusinessOrdersData.GetBusinessOrders();
            var stops = BusinessOrdersData.GetStops();
            List<string> reasons = stops.Select(p => p.Reason).Distinct().OrderBy(p => p).ToList();
            var headers = new List<string>();
            headers.Add("İş Emri");
            headers.AddRange(reasons);
            headers.Add("Toplam");
            List<List<string>> table = new List<List<string>>();
            table.Add(headers);
            List<double> reasonTotal = new List<double>();
            foreach (var reason in reasons)
            {
                reasonTotal.Add(0);
            }
            foreach (var businessOrder in businessOrders)
            {
                Console.Write(businessOrder.Id + " ");
                var stopsForBusinessOrder = GetStopsByTime(stops, businessOrder.StartTime, businessOrder.EndTime);
                var row = new List<string>();
                row.Add(businessOrder.Id.ToString());
                int i = 0;
                foreach (var reason in reasons)
                {
                    double value = stopsForBusinessOrder.Where(p => p.Key == reason).Select(p => p.Value)
                        .FirstOrDefault();
                    row.Add(((int)value).ToString());
                    reasonTotal[i++] += value;
                }
                var sum = stopsForBusinessOrder.Select(p => p.Value).Sum();
                row.Add(sum.ToString());
                table.Add(row);
            }
            var total = new List<string>();
            total.Add("Toplam");
            int j = 0;
            foreach (var reason in reasons)
            {
                total.Add(reasonTotal[j++].ToString());
            }
            total.Add(reasonTotal.Sum().ToString());
            table.Add(total);
            return table;
        }

        public Dictionary<string, double> GetStopsByTime(
            List<Stop> stops, DateTime startTime, DateTime endTime)
        {
            var stopReasonsAndDurations = new Dictionary<string, double>();
            foreach (var stop in stops)
            {
                TimeSpan duration = GetDuration(startTime, endTime, stop.StartTime, stop.EndTime);
                if (duration.TotalMinutes > 0)
                {
                    if (!stopReasonsAndDurations.ContainsKey(stop.Reason))
                    {
                        stopReasonsAndDurations[stop.Reason] = duration.TotalMinutes;
                    }
                    else
                    {
                        stopReasonsAndDurations[stop.Reason] += duration.TotalMinutes;
                    }
                }
            }
            var dictionary = stopReasonsAndDurations.OrderBy(p => p.Key)
                .ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var item in dictionary)
            {
                Console.Write(item.Key + ":" + item.Value + " ");
            }
            Console.WriteLine();
            return dictionary;
        }

        public static TimeSpan GetDuration(
            DateTime boStartTime, DateTime boEndTime,
            DateTime stopStartTime, DateTime stopEndTime)
        {
            TimeSpan timeSpan = TimeSpan.Zero;
            // Tarihler kesişiyor mu? https://stackoverflow.com/a/325939 
            if (boStartTime <= stopEndTime && stopStartTime <= boEndTime)
            {
                //İş emri başlangıç tarihi diğerinden sonra geliyorsa o, değilse diğeri alınır.
                DateTime maxStartTime = (boStartTime > stopStartTime) ? boStartTime : stopStartTime;
                //İş emri bitiş tarihi diğerinden küçükse o, değilse diğeri alınır.
                DateTime minEndTime = (boEndTime < stopEndTime) ? boEndTime : stopEndTime;
                //İki tarihin bu iş emri içindeki farkı bulunur.
                timeSpan = minEndTime - maxStartTime;
            }
            return timeSpan;
        }

    }
}