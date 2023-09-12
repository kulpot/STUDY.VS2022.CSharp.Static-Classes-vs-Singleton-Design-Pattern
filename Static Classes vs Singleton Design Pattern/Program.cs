//#include <fstream>
//#include <string>
//using namespace std;
//
////ref link:https://www.youtube.com/watch?v=f-Dv_EuNMfM&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=51
////C++     // defualt static
//
//ofstream outStream;
//int logNumber = 0;
//
//void initializeLogging()
//{
//    outStream.open("myLog.txt");
//}
//
//void shutdownLogging()
//{
//    outStream.close();
//}
//
//void logMessage(string message)
//{
//    outStream << (logNumber++) << ": " << message << endl;
//}
//
//void main()
//{
//    initilizeLogging();
//    logMessage("I love static data");
//    logMessage("static data exists before and after main()");
//    logMessage("When I think static, I think memory created by the compiler");
//    shutdownLogging();
//}


//C#        //explicit static

//Singlton Design Pattern -- creating one instance of a class

using System.IO;
using System;

class Logger    //Singlton Design Pattern 
{
    StreamWriter outStream;
    int logNumber = 0;
    //static Logger theInstance = new Logger();
    static Logger theInstance;
    Logger() { }

    public void initializeLogging()
    {
        outStream = new StreamWriter("myLog.txt");
    }

    public void ShutdownLogging()
    {
        outStream.Close();
    }

    public void logMessage(string message)
    {
        outStream.WriteLine((logNumber++) + ": " + message);
    }
    public static Logger TheInstance
    {
        //get { return theInstance; }
        get 
        {   // Lazy Loading
            if(theInstance == null)
                theInstance = new Logger();
            return theInstance; 
        }
    }
}


//static class Logger
////class Logger
//{
//    static StreamWriter outStream;
//    static int logNumber = 0;
//
//    static public void initializeLogging()
//    {
//        outStream = new StreamWriter("myLog.txt");
//    }
//
//    static public void ShutdownLogging()
//    {
//        outStream.Close();
//    }
//
//    static public void logMessage(string message)
//    {
//        outStream.WriteLine((logNumber++) + ": " + message);
//    }
//}



class MainClass
{
    static void Main()
    {
        //Logger logger = new Logger();
        
        Logger.TheInstance.initializeLogging(); //Singlton Design Pattern 
        Logger.TheInstance.logMessage("I love static data");
        Logger.TheInstance.logMessage("static data exists before and after main()");
        Logger.TheInstance.logMessage("When I think static, I think memory created by the compiler");
        Logger.TheInstance.ShutdownLogging();


        //Logger.meLogger = new Logger();
        //new Logger();

        //Console.WriteLine("me line");
        ////Console.meConsole = new Console();
        //
        //Logger.initializeLogging();
        //Logger.logMessage("I love static data");
        //Logger.logMessage("static data exists before and after main()");
        //Logger.logMessage("When I think static, I think memory created by the compiler");
        //Logger.ShutdownLogging();
    }
}