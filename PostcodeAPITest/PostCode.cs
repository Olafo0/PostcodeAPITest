using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostcodeAPITest
{
    internal class PostCode
    {
        public class Rootobject
        {
            public Result result { get; set; }
        }

        public class Result
        {
            public string postCode { get; set; }
            public string postCodeTrimmed { get; set; }
            public string streetName { get; set; }
            public decimal longitude { get; set; }
            public decimal latitude { get; set; }
            public string plusCode { get; set; }
            public string region { get; set; }
            public string locality { get; set; }
            public string area { get; set; }
            public int numUPRNs { get; set; }
        }

        //public string postCode { get; set; }
        //public string postCodeTrimmed { get; set; }
        //public string streetName { get; set; }
        //public int longitude { get; set; }
        //public int latitude { get; set; }
        //public string plusCode { get; set; }
        //public string region { get; set; }
        //public string locality { get; set; }
        //public string area { get; set; }
        //public int numUPRNs { get; set; }

        //public PostCode(string postCode, string postCodeTrimmed, string streetName, int longitude, int latitude, string plusCode, string region, string locality, string area, int numUPRNs)
        //{
        //    this.postCode = postCode;
        //    this.postCodeTrimmed = postCodeTrimmed;
        //    this.streetName = streetName;
        //    this.longitude = longitude;
        //    this.latitude = latitude;
        //    this.plusCode = plusCode;
        //    this.region = region;
        //    this.locality = locality;
        //    this.area = area;
        //    this.numUPRNs = numUPRNs;
        //}
    }
}
