using DNNSelenium.Platform.Properties;
using NUnit.Framework;

namespace DNNSelenium.Platform.UpgradeTests
{
	[TestFixture]
	[Category("Upgrade")]
	public class BVTSuperUsers : Common.Tests.BVT.BVTSuperUsers
	{
		protected override string DataFileLocation
		{
			get { return @"UpgradeTests\" + Settings.Default.BVTDataFile; }
		}
	}
}