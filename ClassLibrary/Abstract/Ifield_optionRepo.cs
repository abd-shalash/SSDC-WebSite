using SSDC_WebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Abstract
{
    public interface Ifield_optionRepo
    {
        IEnumerable<field_option> field_options { get; }
    }
}
