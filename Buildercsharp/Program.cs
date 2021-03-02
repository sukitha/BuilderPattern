using System;

namespace Buildercsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Email.Email email = Email.Email.Build()
                            .Header
                                .From("test1@example.com")
                                .To("test2.example.com")
                                .Subject("this is sample subject")
                            .Body
                                .Body("This is sample body")
                                .Attachment("This is sample attachment") ;
            Console.WriteLine(email.ToString());
        }
    }
}
