using System;
using ThirdPartyTools;

namespace FileData
{
	/// <summary>
	/// FileVersion Class gets file version
	/// </summary>
	public class FileVersion : IFile
	{
		FileDetails FileDetails { get; set; }

		public FileVersion(FileDetails fileDetails)
		{
			FileDetails = fileDetails;
		}

		public string PerformAction(string filepath)
		{
			return FileDetails.Version(filepath);
		}
	}
}
