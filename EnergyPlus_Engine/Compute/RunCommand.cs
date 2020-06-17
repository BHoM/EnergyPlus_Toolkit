using BH.oM.Reflection.Attributes;
using System;
using System.ComponentModel;

namespace BH.Engine.Radiance
{
    public static partial class Compute
    {
        [Description("Run a command line command from a string")]
        [Input("commandString", "The full command string to pass to command line")]
        [Output("success", "True if command has been run sucessfully (subject to program being called correctly returning an Exit Code)")]
        public static bool RunCommand(string commandString = null)
        {

            bool success = false;

            if (commandString == null)
            {
                Reflection.Compute.RecordError("No command given.");
                return false;
            }

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal; // Hidden
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = String.Format("/C {0}", commandString);
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            if (process.ExitCode == 0)
            {
                success = true;
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}
