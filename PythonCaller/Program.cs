using Python.Runtime;

namespace PythonCaller;


class Program
{
    static void Main(string[] args)
    {

    }

    static PyRunTime()
    {
        using (Py.GIL())
        {
            PythonEngine.Initialize();
            PythonEngine.Exec("print('Hello, Python!')"); //sample...
                                                          //your actual Python script content goes here...
            PythonEngine.Shutdown();
        }
    }

    static void Processor()
    {
        // Path to the Python interpreter
        string pythonPath = @"C:\Path\To\Your\Python\Interpreter\python.exe";

        // Path to your Python script
        string scriptPath = @"C:\Path\To\Your\Python\Script\script.py";

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
