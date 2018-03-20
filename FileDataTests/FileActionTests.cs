using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThirdPartyTools;

namespace FileData.Tests
{
	[TestClass()]
	public class FileActionTests
	{
		[TestMethod()]
		public void PerformAction_Version_Test()
		{
			//Arrange
			FileDetails fileDetails = new FileDetails();

			FileAction fileAction = new FileAction(
				new FileVersion(fileDetails),
				new FileSize(fileDetails)
				);
			//Act
			var version = fileAction.PerformAction("-v", "C:/file.txt");

			//Assert
			Assert.IsTrue(version.Contains("."));
		}

		[TestMethod()]
		public void PerformAction_Size_Test()
		{
			//Arrange
			FileDetails fileDetails = new FileDetails();

			FileAction fileAction = new FileAction(
				new FileVersion(fileDetails),
				new FileSize(fileDetails)
				);
			//Act
			var version = fileAction.PerformAction("-s", "C:/file.txt");

			//Assert
			Assert.IsFalse(version.Contains("."));
		}

		[TestMethod()]
		[ExpectedException(typeof(ArgumentException),
			"Invalid action")]
		public void PerformAction_InvalidAction_Test()
		{
			//Arrange
			FileDetails fileDetails = new FileDetails();

			FileAction fileAction = new FileAction(
				new FileVersion(fileDetails),
				new FileSize(fileDetails)
				);
			//Act
			var version = fileAction.PerformAction("-wassup", "C:/file.txt");
		}
	}
}