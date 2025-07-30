using System.Runtime.CompilerServices;

public class EchoListCallback
{
	public delegate void CreateNewObject();

	public bool dynamicAdd;

	public event CreateNewObject callback
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void AddCallback(CreateNewObject icallback)
	{
	}

	public void CallCreateNewObject()
	{
	}
}
