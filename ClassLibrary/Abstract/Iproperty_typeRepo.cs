using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    public interface Iproperty_typeRepo
    {
        IEnumerable<property_type> property_types { get; }
    }
}
