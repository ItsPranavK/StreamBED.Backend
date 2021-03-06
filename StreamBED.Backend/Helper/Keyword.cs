﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamBED.Backend.Helper
{
    public class Keyword : Attribute
    {
        private readonly string Content;

        internal Keyword(string Content)
        {
            this.Content = Content;
        }

        public string GetContent()
        {
            return Content;
        }
    }
}
