using System;
using System.Collections.Generic;
using System.Text;

namespace Countries.Model
{
    class Country
    {
        public string name { get; set; }
        public string capital { get; set; }
        public string region { get; set; }
        public int population { get; set; }
        public double[] latlng { get; set; }
        public string flag { get; set; }

    }
}
