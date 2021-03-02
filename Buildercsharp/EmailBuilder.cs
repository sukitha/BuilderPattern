using System;
using System.Collections.Generic;
using System.Text;

namespace Email
{
    public class EmailBuilder : AbstractEmailBuilder
    {
        public EmailBuilder() 
        {
            email = new Email();
        }
    }
}
