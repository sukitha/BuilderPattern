using System;
using System.Collections.Generic;
using System.Text;

namespace Email
{
    public class Email
    {
        internal Email() {
        }
        internal string from { get; set; }
        internal string to { get; set; }
        internal string subject { get; set; }
        internal string body { get; set; }
        internal string attachment { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"from: {from}")
                .AppendLine($"to: {to}")
                .AppendLine($"subject: {subject}")
                .AppendLine($"body: {body}")
                .AppendLine($"attachment: {attachment}")
                .ToString();
        }

        public static AbstractEmailBuilder Build() { return new EmailBuilder(); }
        
    }
}
