using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
	/// <summary>
	/// IFile Class
	/// </summary>
	interface IFile
	{
		string PerformAction(string filepath);
	}
}
