﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class User
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public List<string> Permissions { get; set; }
    }
}
