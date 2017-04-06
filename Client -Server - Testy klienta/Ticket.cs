using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client__Server___Testy_klienta
{
    class Ticket
    {
        string temat;
        String Temat {
                        get { return temat; }
                        set { temat = value; }
                     }
        DateTime creationTime;
        DateTime CreationTime { get { return creationTime; } set { creationTime = value; } }
        bool status;
        bool Status { get { return status; } set { status = value; } }


        public Ticket( string Temat, String CreationTime, bool Status)
        {
            this.Temat = Temat;
            this.CreationTime = DateTime.Parse(CreationTime);
            this.Status = Status;
        }
    }
}
