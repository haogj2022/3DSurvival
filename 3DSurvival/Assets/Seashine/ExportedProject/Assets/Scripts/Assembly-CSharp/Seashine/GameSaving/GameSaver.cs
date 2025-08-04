using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Seashine.GameSaving
{
	public class GameSaver : Singleton<GameSaver>
	{
		[CompilerGenerated]
		private sealed class _003CAutosave_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameSaver _003C_003E4__this;

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
			public _003CAutosave_003Ed__28(int _003C_003E1__state)
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

		[SerializeField]
		private bool debugMode;

		[SerializeField]
		private bool enableCloudSaving;

		[SerializeField]
		private bool deleteLocalLegacySaveData;

		[SerializeField]
		private bool deleteCloudLegacySaveData;

		[SerializeField]
		private GameDatabase gameDatabase;

		[SerializeField]
		[Tooltip("In seconds")]
		[Min(1f)]
		private float autosaveInterval;

		private WaitForSeconds autosaveWait;

		private int unsavedChanges;

		public bool Ready { get; private set; }

		public SavedGame CurrentSavedGame { get; private set; }

		public CloudSaver CloudSaver { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		public void InitializeCloudSaver()
		{
		}

		private void UpdateSaveGameVersion()
		{
		}

		public void LoadLocallySavedGame()
		{
		}

		public void SaveGame()
		{
		}

		private void SaveChanges()
		{
		}

		[IteratorStateMachine(typeof(_003CAutosave_003Ed__28))]
		private IEnumerator Autosave()
		{
			return null;
		}

		public void SaveGameLocally()
		{
		}

		public void AppendToCurrentSavedGame(SavedGame savedGameToAppend)
		{
		}

		public bool SaveScore(int score)
		{
			return false;
		}

		public bool SaveJellyfish(string jellyfishName)
		{
			return false;
		}

		public string SaveNewKohatora(string type)
		{
			return null;
		}

		public string SaveNewKohatoraWithUsage(string type, int usageType, string usedBy)
		{
			return null;
		}

		public bool SaveKohatoraUsage(string UID, int usageType, string usedBy)
		{
			return false;
		}

		public void SaveAbility(string abilityName, int level, int symbionts)
		{
		}

		public bool SaveUsableAbilitySlots(int slotCount)
		{
			return false;
		}

		public void SaveTutorial(string tutorial)
		{
		}

		public void DeleteSavedGame(bool deleteLocalData, bool deleteCloudData)
		{
		}

		public bool SaveDiscoveredLifeform(string lifeformName, bool saveNow)
		{
			return false;
		}

		public void OnCloudInitialization(string message)
		{
		}
	}
}
