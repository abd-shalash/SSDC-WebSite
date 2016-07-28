using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    public interface Iadditional_serviceRepo
    {
        IEnumerable<additional_service> additional_services { get; }
    }
}
