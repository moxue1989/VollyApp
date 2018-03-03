using System.Collections.Generic;

namespace Volly.Models.DataModel
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Skills{get;set;}
        public List<string> Avalability { get; set; }
        
    }
}