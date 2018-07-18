using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParser1
{
    class jsonPersonArray
    {
        public string firstname { get; set; }
        public string email { get; set; }
        public string nation { get; set; }
        public addr address { get; set; }
        public List<phoneNum> phoneNumbers { get; set; }

        public class addr
        {
            public string firstname { get; set; }
            public string email { get; set; }
            public string nation { get; set; }
        }

        public class phoneNum
        {
            public string type { get; set; }
            public string number { get; set; }
        }
    }
}
