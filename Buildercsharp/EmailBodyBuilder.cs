using System;
using System.Collections.Generic;
using System.Text;

namespace Email
{
    public class EmailBodyBuilder : AbstractEmailBuilder
    {
        internal EmailBodyBuilder(Email _email)
        {
            email =  _email;
        }

        internal EmailBodyBuilder Body(string body)
        {
            email.body = body;
            return this;
        }
        internal EmailBodyBuilder Attachment(string attachment)
        {
            email.attachment = attachment;
            return this;
        }


    }
}
