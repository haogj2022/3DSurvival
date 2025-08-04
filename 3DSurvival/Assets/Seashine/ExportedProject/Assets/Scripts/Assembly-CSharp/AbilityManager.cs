using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Seashine.GameSaving;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
	public delegate void AbilityManagerEvent();

	[CompilerGenerated]
	private sealed class _003CReportSelectedAbilities_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AbilityManager _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CReportSelectedAbilities_003Ed__29(int _003C_003E1__state)
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

	private PGM PGM_Instance;

	private GameManager gameManager;

	private GameSaver gameSaver;

	public GameDatabase gameDatabase;

	[NonSerialized]
	public Ability[] Abilities;

	[NonSerialized]
	public ObscuredInt totalAbilities;

	public AbilitySlot[] abilitySlots;

	public GameObject abilitySlotHint;

	public List<Ability> activeAbilities;

	public List<Ability> inactiveAbilities;

	private int totalGamesPlayed;

	private bool reportingSelectedAbilities;

	public event Action<Ability> OnAbilityUnlocked
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

	public event AbilityManagerEvent OnThirdSlotUnlocked
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void InitAbilities()
	{
	}

	public bool IsAbilityUnlocked(Ability ability)
	{
		return false;
	}

	public Ability GetAbilityByName(string abilityName)
	{
		return null;
	}

	public void UnlockThirdSlot(bool saveToCloud)
	{
	}

	public void UnlockAbility(Ability unlockedAbility, bool saveToCloud)
	{
	}

	private void ReportUnlockedAbility(Ability unlockedAbility)
	{
	}

	private void OnNewGame()
	{
	}

	[IteratorStateMachine(typeof(_003CReportSelectedAbilities_003Ed__29))]
	private IEnumerator ReportSelectedAbilities()
	{
		return null;
	}
}
