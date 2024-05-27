﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketingSystem.Views
{
    public interface IModelDataView : IDataView
    {

        string ModelName { get; set; }
        int? SeatsCount { get; set; }

    }
}
