using System;
namespace BusinessOrderService.Dto
{
    public class Stop
    {
        public Stop(string reason, DateTime startTime, DateTime endTime)
        {
          this.Reason = reason;
          this.StartTime = startTime;
          this.EndTime = endTime;
        }

        public int BusinessOrderId { get; set; }
        public String Reason { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}