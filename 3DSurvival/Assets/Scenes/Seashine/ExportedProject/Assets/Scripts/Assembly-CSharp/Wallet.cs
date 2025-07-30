using System;
using CodeStage.AntiCheat.ObscuredTypes;

public class Wallet
{
	public static Action<int, int> onStarsChange;

	public static Action<int, int> onPearlsChange;

	public static ObscuredInt Stars => default(ObscuredInt);

	public static ObscuredInt Pearls => default(ObscuredInt);

	public static bool AddStars(ObscuredInt amount)
	{
		return false;
	}

	public static ObscuredBool ConsumeStars(ObscuredInt amount)
	{
		return default(ObscuredBool);
	}

	public static bool AddPearls(ObscuredInt amount)
	{
		return false;
	}

	public static ObscuredBool ConsumePearls(ObscuredInt amount)
	{
		return default(ObscuredBool);
	}
}
