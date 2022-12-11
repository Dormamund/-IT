﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    public class DbInitializer
    {
        public static void Initialize(EmployeeDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
