using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuterServices.DTO
{
    public class Stop
    {
        public string District { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public string PlaceType { get; set; }
        public bool IsHub { get; set; }
        public string Line { get; set; }
        public string ShortName { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Zone { get; set; }
    }
}
