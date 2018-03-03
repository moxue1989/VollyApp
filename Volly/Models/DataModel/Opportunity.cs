using System;

namespace Volly.Models.DataModel
{
    public class Opportunity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}