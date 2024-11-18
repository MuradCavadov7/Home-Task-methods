using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.Exceptions;

public class UserNotFoundException : Exception
{
    public UserNotFoundException(string message) : base(message) { }

}

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(string message) : base(message) { }

}

