using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class Tiki : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCheckDistance_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Tiki _003C_003E4__this;

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
		public _003CCheckDistance_003Ed__39(int _003C_003E1__state)
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

	private GameManager gameManager;

	private Transform thisTransform;

	private Jelly playerScript;

	[SerializeField]
	private Transform mouthPoint;

	[Header("TRIGGER")]
	[Range(0.5f, 2f)]
	[SerializeField]
	private float distanceCheckInterval;

	[Range(1f, 15f)]
	[SerializeField]
	private float distanceTrigger;

	[SerializeField]
	private bool checkPlayerVisibility;

	[SerializeField]
	private LayerMask obstacleLayers;

	private bool playerVisible;

	[SerializeField]
	private bool onlyReactOnce;

	private bool interact;

	private Transform player;

	private float distanceMagnitude;

	private Vector3 distanceOffset;

	private float distanceTriggerSqr;

	private float distanceDisableSqr;

	private bool tikiTriggered;

	private Transform tikiTalkFx;

	[Header("TALK")]
	public Transform labelAnchor;

	private bool talking;

	private bool talkingTiki;

	[Range(0f, 2f)]
	public int tikiIndex;

	public string localizationKey;

	[SerializeField]
	private bool inGameTutorial;

	private string localizedText;

	private UILabel correspondingTikiLabel;

	private GameObject correspondingTikiLabelGO;

	private Transform correspondingTikiLabelTfm;

	private Tween labelFadeTween;

	private Tween punchTween;

	private Vector3 startEuler;

	private Vector3 punchVector;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void SetupDistanceCheck()
	{
	}

	private void SetupLayer()
	{
	}

	private void SetupTalk()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckDistance_003Ed__39))]
	private IEnumerator CheckDistance()
	{
		return null;
	}

	private void ShowText()
	{
	}

	private void HideText()
	{
	}

	private void UpdateTikiLabelOpacity(float _opacity)
	{
	}

	private void OnTikiLabelHidden()
	{
	}

	private void ResetLabelFadeTween()
	{
	}

	private void ResetPunchTween()
	{
	}
}
