﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loopc.Service.IServiceProvider
{
    public interface IConfigurationService
    {
        string Get(string name);
    }
}
