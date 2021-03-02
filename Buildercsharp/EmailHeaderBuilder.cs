using System;
using System.Collections.Generic;
using System.Text;

namespace Email
{
    public class EmailHeaderBuilder : AbstractEmailBuilder
    {
        internal EmailHeaderBuilder(Email _email) {
            email = _email;
        }

        internal EmailHeaderBuilder From(string from){
            email.from = from;
            return this;
        }
        internal EmailHeaderBuilder To(string to)
        {
            email.to = to;
            return this;
        }

        internal EmailHeaderBuilder Subject(string subject)
        {
            email.subject = subject;
            return this;
        }

    }
}
