using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Seashine.GameSaving;
using Seashine.NPC;
using UnityEngine;

public class ExplorationManager : MonoBehaviour
{
	public delegate void ExplorationManagerEvent();

	[Serializable]
	public class AnimalAtlases
	{
		public UIAtlas LetterA;

		public UIAtlas LetterB;

		public UIAtlas LetterD;

		public UIAtlas LetterF;

		public UIAtlas LetterG;

		public UIAtlas LetterH;

		public UIAtlas LetterI;

		public UIAtlas LetterK;

		public UIAtlas LetterM;

		public UIAtlas LetterN;

		public UIAtlas LetterO;

		public UIAtlas LetterP;

		public UIAtlas LetterR;

		public UIAtlas LetterS;

		public UIAtlas LetterT;

		public UIAtlas LetterU;

		public UIAtlas LetterV;

		public UIAtlas LetterW;
	}

	[CompilerGenerated]
	private sealed class _003CNotifyDiscoveries_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ExplorationManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CNotifyDiscoveries_003Ed__59(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[HideInInspector]
	public GameManager gameManager;

	private GameSaver gameSaver;

	[HideInInspector]
	public Localizer localizer;

	public GameDatabase gameDatabase;

	[Space(10f)]
	[SerializeField]
	private bool debugKohatora;

	[SerializeField]
	private bool debugNotifications;

	[HideInInspector]
	public bool remainingDiscoveries;

	private int realDiscoveryReward;

	[HideInInspector]
	public bool mutamaraDiscovered;

	public List<Discovery> currentlyEnabledDiscoveries;

	public Dictionary<string, int> discovered;

	public Dictionary<string, int> notDiscovered;

	[Header("NOTIFICATION")]
	[Space(5f)]
	public DiscoveryNotification discoveryNotification;

	public List<DiscoveryEvent> pendingNotifications;

	private Transform notificationTsfm;

	private bool notifyingDiscoveries;

	private Vector3 notificationNormalPosition;

	private Vector3 notificationBaseSize;

	public UIPanel nguiRoot;

	public HashSet<string> NewDiscoveriesToNotifyInEncyclopedia;

	public List<LifeformConfig> DiscoveredLifeforms;

	public int TotalDiscoveredLifeforms;

	public List<LifeformConfig> UndiscoveredLifeforms;

	public int TotalUndiscoveredLifeforms;

	public List<LifeformConfig> DiscoverableLifeforms;

	public int TotalDiscoverableLifeforms;

	[Space(10f)]
	public HashSet<string> DiscoveredV2KohatoraTypes;

	public Dictionary<string, List<string>> DiscoveredV2PiecesByLifeform;

	public Dictionary<string, Queue<string>> NotYetDiscoveredV2KohatoraTypesByLifeform;

	public List<string> discoverableLegacyKohatoraTypesAsLifeformNames;

	public List<string> RemainingLegacyKohatoraTypesToFind;

	public List<LifeformConfig> UnlockedLifeforms;

	public AnimalAtlases animalAtlases;

	public UIAtlas botanicaAtlas;

	public UIAtlas kohatoraAtlas;

	public int TotalLegacyKohatoraTypes => 0;

	public event ExplorationManagerEvent OnKohatoraDiscovered
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

	public event ExplorationManagerEvent OnKohatoraUnlock
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

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnNewGame()
	{
	}

	private void CheckSavedDiscoveries()
	{
	}

	private void AddRemainingKohatoraAndV2PiecesFor(string lifeformName)
	{
	}

	public void DiscoverLifeform(LifeformConfig lifeform, bool saveToCloud)
	{
	}

	public void DiscoverLifeformByName(string lifeformName)
	{
	}

	public void CloudUnlockLifeform(string lifeformName)
	{
	}

	public void DiscoverKohatora(string kohatoraName)
	{
	}

	public void KohatoraUnlock(string kohatoraName, bool saveToCloud)
	{
	}

	private void AddDiscoveryNotification(LifeformConfig lifeform)
	{
	}

	private void AddDiscoveryNotification(string kohatora)
	{
	}

	[IteratorStateMachine(typeof(_003CNotifyDiscoveries_003Ed__59))]
	private IEnumerator NotifyDiscoveries()
	{
		return null;
	}

	private void DisableDiscoveryNotification()
	{
	}

	public bool CheckIfDiscovered(LifeformConfig lifeform)
	{
		return false;
	}

	public bool IsLifeformDiscovered(string lifeformName)
	{
		return false;
	}

	public bool CheckIfUnlocked(LifeformConfig lifeform)
	{
		return false;
	}

	public LifeformConfig FindLifeform(string lifeformName)
	{
		return null;
	}

	public UIAtlas GetAtlas(string letterIndex)
	{
		return null;
	}
}
