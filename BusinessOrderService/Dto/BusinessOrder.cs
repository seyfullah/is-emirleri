using System;

namespace BusinessOrderService.Dto
{

    public class BusinessOrder
    {

        public BusinessOrder(int id, DateTime startTime, DateTime endTime)
        {
            this.Id = id;
            this.StartTime = startTime;
            this.EndTime = endTime;
        }

        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}