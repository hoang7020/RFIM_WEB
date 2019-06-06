using RFIM_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.ModelView
{
    public class RoleSelectModel
    {
        public List<Role> Data { get; set; }
        public int? Select { get; set; }
    }
}
