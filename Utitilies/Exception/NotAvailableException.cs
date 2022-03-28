using System;
using System.Collections.Generic;
using System.Text;

namespace Utitilies.Exceptions
{
    public class NotAvailableException:Exception
    {
        public NotAvailableException(string message) : base(message)
        {

        }
    }
}
