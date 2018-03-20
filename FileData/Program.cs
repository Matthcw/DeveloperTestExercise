using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
			try
			{
				if (args.Length != 2) throw new ArgumentException("Invalid args");

				FileDetails fileDetails = new FileDetails();

				FileAction fileAction = new FileAction(
					new FileVersion(fileDetails),
					new FileSize(fileDetails)
					);
				
				Console.WriteLine(fileAction.PerformAction(args[0], args[1]));
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
			}

			Console.ReadKey();
		}
	}
}
