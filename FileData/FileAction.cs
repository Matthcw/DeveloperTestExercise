using System;
using System.Collections.Generic;
using ThirdPartyTools;

namespace FileData
{
	/// <summary>
	/// FileAction Class
	/// </summary>
	public class FileAction
	{
		private List<string> versionCommand = new List<string> { "-v", "--v", "/v", "--vesion" };
		private List<string> sizeCommand = new List<string> { "-s", "--s", "/s", "--size" };

		private FileVersion FileVersion { get; set; }
		private FileSize FileSize { get; set; }

		public List<string> VersionCommand
		{
			get { return versionCommand; }
		}

		public List<string> SizeCommand
		{
			get { return sizeCommand; }
		}

		/// <summary>
		/// Initialises the FileAction object
		/// </summary>
		/// <param name="fileVersion">FileVersion object</param>
		/// <param name="fileSize">FileSize object</param>
		public FileAction(FileVersion fileVersion, FileSize fileSize)
		{
			FileVersion = fileVersion;
			FileSize = fileSize;
		}

		/// <summary>
		/// Performs action
		/// </summary>
		/// <param name="action">Action to perform</param>
		/// <param name="filename">File to perform action on</param>
		/// <returns>String containing result after action taken</returns>
		public string PerformAction(string action, string filename)
		{
			IFile file = null;

			if (SizeCommand.Contains(action))
			{
				file = FileSize;
			}
			else if (VersionCommand.Contains(action))
			{
				file = FileVersion;
			}
			else
			{
				throw new ArgumentException("Invalid action: " + action);
			}

			return file.PerformAction(filename);
		}
	}
}
