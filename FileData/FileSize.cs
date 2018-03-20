using System;
using ThirdPartyTools;

namespace FileData
{
	/// <summary>
	/// FileSize Class gets file size
	/// </summary>
	public class FileSize : IFile
	{
		FileDetails FileDetails { get; set; }

		public FileSize(FileDetails fileDetails)
		{
			FileDetails = fileDetails;
		}

		public string PerformAction(string filepath)
		{
			return FileDetails.Size(filepath).ToString();
		}
	}
}
