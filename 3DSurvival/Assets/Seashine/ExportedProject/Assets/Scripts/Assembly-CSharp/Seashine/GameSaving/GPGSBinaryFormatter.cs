using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Seashine.GameSaving
{
	public class GPGSBinaryFormatter<T>
	{
		public static byte[] ToBytes(T data)
		{
			return null;
		}

		public static T FromBytes(byte[] data, BinaryFormatter formatter = null, SerializationBinder binder = null)
		{
			return default(T);
		}
	}
}
