
using System;
using System.Diagnostics;


namespace PythonCaller;


class Program
{
    static void Main(string[] args)
    {
        Processor();
    }

/*  static void PyRunTime()
    {
        using (Py.GIL())
        {
            PythonEngine.Initialize();
            PythonEngine.Exec("print('Hello, Python!')"); //sample...
                                                          //your actual Python script content goes here...
            PythonEngine.Shutdown();
        }
    }
*/
    static void Processor()
    {
        // Path to the Python interpreter
        string pythonPath = @"/usr/bin/python3";

        // Path to your Python script
        string scriptPath = @"/home/onuralp/projects/BootcampVisualStudio/PythonCaller/test.py";

        // Create a new process to run the Python script
        ProcessStartInfo psi = new ProcessStartInfo();
        psi.FileName = pythonPath;
        psi.Arguments = scriptPath;
        psi.UseShellExecute = false;
        psi.RedirectStandardOutput = true;
        psi.RedirectStandardError = true;

        // Start the process
        Process process = Process.Start(psi);

        // Read the output
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        // Wait for the process to finish
        process.WaitForExit();

        // Display output and error
        Console.WriteLine("Output:");
        Console.WriteLine(output);
        Console.WriteLine("Error:");
        Console.WriteLine(error);
    }

}
