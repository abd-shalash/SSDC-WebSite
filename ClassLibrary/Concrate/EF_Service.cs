﻿using ClassLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSDC_WebSite.Models;

namespace ClassLibrary.Concrate
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    public class EF_Service : IService
    {
        /// <summary>
        /// The Context
        /// </summary>
        private readonly EF_DBContext Context = new EF_DBContext();
        public IEnumerable<Service> Services { get { return Context.Service; } }
    }
}
