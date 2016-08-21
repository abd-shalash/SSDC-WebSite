using ClassLibrary.Abstract;
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
    public class EF_additional_serviceRepo : IServices
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly EF_DBContext context = new EF_DBContext();
        public IEnumerable<additional_service> AdditionalServices{get{return context.additional_services;}}
    }
}
