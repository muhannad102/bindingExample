﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bindingExample.Model;

namespace bindingExample
{
    public interface IUIManager
    {

        void makeBusy(bool b);
        void showMessage(Department d);
        bool applicationStatus();

    }
}
