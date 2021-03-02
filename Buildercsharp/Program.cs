using System;

namespace Buildercsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Email.Email email = Email.Email.Build()
                            .Header()
                                .From("test1@example.com")
                                .to("test2.example.com")
                                .Subject("subject.com")
                            .Body()
                                .Body("This is sample body")
                                .Attachment("This is sample attachment") ;
            Console.WriteLine(email.ToString());
        }
    }
}
