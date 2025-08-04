using System;
using System.Runtime.Serialization;

namespace Seashine.GameSaving
{
	public class GPGSAutosaveV1ToV2SerializationBinding : SerializationBinder
	{
		public override Type BindToType(string assemblyName, string typeName)
		{
			return null;
		}
	}
}
