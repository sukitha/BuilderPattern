using System;
using System.Collections.Generic;
using System.Text;

namespace Email
{
    public abstract class AbstractEmailBuilder
    {
        protected Email email;
        protected AbstractEmailBuilder() {
        }

        public static implicit operator Email(AbstractEmailBuilder builder) => builder.email;

        public EmailHeaderBuilder Header() => new EmailHeaderBuilder(email);
        public EmailBodyBuilder Body() => new EmailBodyBuilder(email);
        
    }
}
