using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using UnityEditor.AddressableAssets.HostingServices;
using UnityEngine;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.ResourceManagement.Util;
using UnityEngine.Serialization;

namespace UnityEditor.AddressableAssets.Settings.GroupSchemas
{
	[Serializable]
	public struct BundleDefinition
	{
		public string bundleName;
		public string bundleGuid;
	}

	public class BundleNameOverwriteSchema : AddressableAssetGroupSchema
	{
		public BundleDefinition[] packedTogether;

		public BundleDefinition[] packedByLabel;

		public BundleDefinition[] packedSeparately;
	}
}
