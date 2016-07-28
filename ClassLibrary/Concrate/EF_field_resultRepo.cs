﻿using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSDC_WebSite.Models;

namespace ClassLibrary.Concrate
{
    public class EF_field_resultRepo : Ifield_resultRepo
    {
        private readonly EF_DBContext context = new EF_DBContext();
        public IEnumerable<field_result> field_results
        {
            get
            {
                return context.field_results;
            }
        }
    }
}
