using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClarkNet.WebPortal.Services
{
	public static class ServiceHelper
	{
		public static (string stdout, string stderror) RunCommandExe(string command)
		{
			string cmd = "\""+command+"\"";

			System.Diagnostics.Process process = new System.Diagnostics.Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = $"/c {cmd}"; // Note the /c command (*)
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.Start();

			//* Read the output (or the error)
			string output = process.StandardOutput.ReadToEnd();
			Serilog.Log.Information(output);
			string err = process.StandardError.ReadToEnd();
			Serilog.Log.Error(err);
			process.WaitForExit();

			return (output, err);
		}
	}
}
