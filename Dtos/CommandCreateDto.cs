using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        // Created by DB
        //public int id { get; set; }

        public string HowTo { get; set; }

        public string Line { get; set; }

        public string Platform { get; set; }
    }
}
