using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAnimateMainMenu_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CAnimateMainMenu_003Ed__34(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CAnimateTitle_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenu _003C_003E4__this;

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
		public _003CAnimateTitle_003Ed__37(int _003C_003E1__state)
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
	private UserInterfaceController userInterfaceController;

	private Vector3 vector3AlmostZero;

	private bool ctrlLocked;

	public Transform MainTitle;

	private Tween mainTitleTween;

	private Vector3 titleStartPos;

	public Transform[] Letters;

	public TweenAlpha[] letterTweens;

	private GameObject[] lettersGO;

	private Vector3[] lettersStartLocPos;

	private int totalLetters;

	public GameObject NavBar;

	private Vector3 NavBarStartPos;

	public GameObject ShopButton;

	private Vector3 ShopButtonStartPos;

	private Tween shopButtonTween;

	public GameObject abilitiesButton;

	private Vector3 abilitiesButtonStartPos;

	private Tween abilitiesButtonTween;

	public GameObject ScoreButton;

	private Vector3 ScoreButtonStartPos;

	private Tween scoreButtonTween;

	public GameObject SecretsButton;

	private Vector3 SecretsButtonStartPos;

	private Tween achievementsButtonTween;

	public GameObject OptionsButton;

	private Vector3 OptionsButtonStartPos;

	private Tween optionsButtonTween;

	private float buttonStartYPos;

	private float buttonYFromAnim;

	private Vector3 buttonStartScale;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateMainMenu_003Ed__34))]
	private IEnumerator AnimateMainMenu()
	{
		return null;
	}

	private void UnlockUI()
	{
	}

	public void StopButtonTweens()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimateTitle_003Ed__37))]
	private IEnumerator AnimateTitle()
	{
		return null;
	}

	private void ResetElements()
	{
	}

	private void ResetLetters()
	{
	}

	public void DisableMainMenu(bool popAnimation)
	{
	}

	private void OnCloseAnimationPlay()
	{
	}

	private void OnCloseAnimationFinished()
	{
	}
}
