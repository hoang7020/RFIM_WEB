using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFIM_Web.Constants
{
    public static class ErrorMessage
    {
        public static string LoginFail => "The username or password that you've entered doesn't match any account.Please try again";

        public static string LoginDeactive => "The account is not actived";
    }
}
