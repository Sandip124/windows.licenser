using System;
using System.Diagnostics;

namespace windows.licenser
{
    public static class RenewHelper
    {
        public static void TryRenew(LicensePair pair)
        {
            var process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"slmgr /ipk {pair.Value.key}; slmgr /skms kms8.msguides.com; slmgr /ato";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();    
            var output = process.StandardOutput.ReadToEnd();
            var error = process.StandardError.ReadToEnd();
            process.WaitForExit();
            if (process.ExitCode != 0)
            {
                process.Close();
                throw new Exception("Error renewing license: " + error);
            }

            process.Close();
        }
    }
}