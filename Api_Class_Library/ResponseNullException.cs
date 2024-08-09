using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Class_Library {
    public class ResponseNullException(string msg) : Exception(msg) {}
}
