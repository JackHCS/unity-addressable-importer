using System;
using System.Collections.Generic;

namespace com.littlebigfun.addressable_importer.Editor
{
	/// <summary>
	/// Rules scoped to a specific Directory/Folder.
	/// Saves unnecessarily checking potentially more expensive rules for directories/folders they don't apply to.
	/// </summary>
	[Serializable]
	public class AddressableImportRuleFolder
	{
		/// <summary>
		/// Directory/Folder to scope the rules to.
		/// </summary>
		public string folderPath;

		/// <summary>
		/// List of rules for this specifc folder.
		/// </summary>
		public List<AddressableImportRule> rules = new List<AddressableImportRule>();
	}
}
