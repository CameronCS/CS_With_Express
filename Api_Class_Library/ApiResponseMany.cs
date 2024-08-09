using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Class_Library {
    public class ApiResponseMany {
        public int Code {
            get; set;
        }
        public List<User> Users {
            get; set;
        }

        public string Message {
            get; set; 
        }
    }
}
