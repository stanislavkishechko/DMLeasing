﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Common.Interfaces
{
    public interface IEmailSender
    {
        void SendEmail(string name, string email, string message);
    }
}
