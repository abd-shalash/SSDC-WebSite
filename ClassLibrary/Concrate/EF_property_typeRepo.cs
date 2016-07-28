﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Abstract;
using SSDC_WebSite.Models;
using System.Runtime.Remoting.Contexts;
using ClassLibrary.Entities;
namespace ClassLibrary.Concrate
{
   public class EF_property_typeRepo: Iproperty_typeRepo
    
    {
        private readonly EF_DBContext context = new EF_DBContext();

      public  IEnumerable<property_type> property_types
        {
            get
            {
                return context.property_types;
            }
        }
    }
}
