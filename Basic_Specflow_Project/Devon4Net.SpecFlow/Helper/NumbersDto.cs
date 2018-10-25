using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devon4Net.SpecFlow.Helper
{
    public class NumbersDto
    {
        [JsonProperty(PropertyName = "number1")]
        public int Number1 { get; set; }

        [JsonProperty(PropertyName = "number2")]
        public int Number2 { get; set; }
    }
}
