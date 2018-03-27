using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bindingExample.Model
{
   public class Department
    {

        public int id { get; set; }
        public string name { get; set; }


        public int Id
        {

            get { return id; }
            set { id = value; }

        }


        public string Name
        {

            get { return name; }
            set { name = value; }

        }

    }

}
