﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensatoClient.Contracts
{
    public interface IHiveView : IView
    {
        event EventHandler BackClick;

        event EventHandler ForwardClick;
    }
}