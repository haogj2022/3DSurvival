using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MusicController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayTitleMusic_003Ed__15 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public MusicController _003C_003E4__this;

		float IEnumerator<float>.Current
		{
			[DebuggerHidden]
			get
			{
				return 0f;
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
		public _003CPlayTitleMusic_003Ed__15(int _003C_003E1__state)
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
	private sealed class _003CPlayOceanMusic_003Ed__16 : IEnumerator<float>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private float _003C_003E2__current;

		public MusicController _003C_003E4__this;

		private int _003CrandomAmount_003E5__2;

		private int _003Ci_003E5__3;

		float IEnumerator<float>.Current
		{
			[DebuggerHidden]
			get
			{
				return 0f;
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
		public _003CPlayOceanMusic_003Ed__16(int _003C_003E1__state)
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
	private GameManager gameManager;

	[HideInInspector]
	public AudioMood audioMood;

	[HideInInspector]
	public string wanderAudioItem;

	[HideInInspector]
	public string escapeAudioItem;

	[HideInInspector]
	public int remainingNotes;

	private List<AudioMood> activeAudioMoodZones;

	private List<int> activeAudioMoodZonesCount;

	private string selectedAudioItem;

	private int lastWanderAudioItem;

	private int lastEscapeAudioItem;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnNewGame()
	{
	}

	public void PlaySwimNote()
	{
	}

	public void ChangeAudioMood(AudioMood newAudioMood)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayTitleMusic_003Ed__15))]
	private IEnumerator<float> PlayTitleMusic()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayOceanMusic_003Ed__16))]
	private IEnumerator<float> PlayOceanMusic()
	{
		return null;
	}

	public void AddAudioMoodZone(AudioMood zoneAudioMood)
	{
	}

	public void RemoveAudioMoodZone(AudioMood zoneAudioMood)
	{
	}
}
