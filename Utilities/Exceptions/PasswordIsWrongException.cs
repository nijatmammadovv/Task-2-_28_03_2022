using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Exceptions
{
    public class PasswordIsWrongException:Exception
    {
        public PasswordIsWrongException(string message) : base(message)
        {

        }
    }
}
