using System.Collections.Generic;
using UnityEngine;

public class Localizer : MonoBehaviour
{
	public UIFont localizableFont;

	public AppLanguage selectedLanguage;

	private SystemLanguage actualSystemLanguage;

	private Dictionary<string, string> locDictionary;

	[HideInInspector]
	public AppLanguage activeLanguage;

	private void Awake()
	{
	}

	private void SetLanguage()
	{
	}

	private AppLanguage ConvertSystemLanguage()
	{
		return default(AppLanguage);
	}

	private void Load(TextAsset asset)
	{
	}

	private void SetFont()
	{
	}

	public string GetLocal(string key)
	{
		return null;
	}
}
