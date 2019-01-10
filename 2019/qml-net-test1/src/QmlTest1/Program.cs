using System;
using Qml.Net;

namespace QmlTest1
{
    class Program
    {
        static int Main(string[] args)
        {
            using (var app = new QGuiApplication(args))
            {
                using (var engine = new QQmlApplicationEngine())
                {
                    // TODO: Register your .NET types.
                    // Qml.RegisterType<NetObject>("test");

                    engine.Load("Main.qml");
                    
                    return app.Exec();
                }
            }
        }
    }
}
