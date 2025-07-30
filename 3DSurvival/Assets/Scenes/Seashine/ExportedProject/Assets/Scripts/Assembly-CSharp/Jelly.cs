using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using HedgehogTeam.EasyTouch;
using Seashine.GameSaving;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Jelly : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDeplete_003Ed__137 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Jelly _003C_003E4__this;

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
		public _003CDeplete_003Ed__137(int _003C_003E1__state)
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
	private sealed class _003CBlink_003Ed__141 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Jelly _003C_003E4__this;

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
		public _003CBlink_003Ed__141(int _003C_003E1__state)
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
	private sealed class _003CDoSonar_003Ed__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Jelly _003C_003E4__this;

		private float _003CcurrentDegree_003E5__2;

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
		public _003CDoSonar_003Ed__145(int _003C_003E1__state)
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
	private sealed class _003CMakeBubbles_003Ed__148 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Jelly _003C_003E4__this;

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
		public _003CMakeBubbles_003Ed__148(int _003C_003E1__state)
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
	private sealed class _003CLoadCheckpoint_003Ed__154 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Jelly _003C_003E4__this;

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
		public _003CLoadCheckpoint_003Ed__154(int _003C_003E1__state)
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
	private sealed class _003CDetectCheating_003Ed__157 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Jelly _003C_003E4__this;

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
		public _003CDetectCheating_003Ed__157(int _003C_003E1__state)
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

	private GameSaver gameSaver;

	[SerializeField]
	private AbilityManager abilityManager;

	private EveryplayManager everyplayManager;

	private MusicController musicController;

	[HideInInspector]
	public Transform hoodTransform;

	[SerializeField]
	private bool debug;

	public Transform jellyfish;

	private Rigidbody2D thisRigidbody;

	[HideInInspector]
	public CircleCollider2D thisCircleCollider2D;

	[HideInInspector]
	public Renderer jellyfishRenderer;

	public Animator animator;

	public Light pointLight;

	private Camera mainCamera;

	private GameCamera gameCamera;

	public Egg Egg;

	[HideInInspector]
	public Transform thisTransform;

	private Vector3 startPosition;

	public GameObject starArrow;

	public StarButton starButton;

	private Checkpoint lastTutorialCheckpoint;

	public GameObject doubleTapHint;

	public LayerMask antiCheatLayers;

	private float swimSpeed;

	private float baseSpeed;

	private float jellyfishSpeed;

	private float baseResistanceFactor;

	private float jellyfishResistanceFactor;

	private float baseLightIntensity;

	private float jellyfishLightIntensity;

	private float baseLightRange;

	private float jellyfishLightRange;

	private float lightDepletionRate;

	private float baseLightDepletionRate;

	private float jellyfishLightDepletionRate;

	private float jellyfishPoisonLightDepletionRate;

	private bool poisonImmunity;

	private string selectedAbility1;

	private string selectedAbility2;

	private string selectedAbility3;

	private bool antiPoisonSelected;

	private bool speedBoostSelected;

	private bool magnetSelected;

	private bool shockwaveSelected;

	private bool stunSelected;

	private float lightBoost;

	private bool supersenseSelected;

	private bool antiparasiteSelected;

	public Supersense supersense;

	private float speedBoostTimer;

	private float speedBoostForce;

	private bool speedBoosting;

	public LayerMask magnetLayerMask;

	public LayerMask stunLayerMask;

	public LayerMask shockwaveLayerMask;

	public LayerMask shockwaveLayerMaskNoPrey;

	public LayerMask sonarLayerMask;

	private float magnetForce;

	private float shockwaveForce;

	private bool gameStarted;

	[HideInInspector]
	public ObscuredBool born;

	public ObscuredBool isDead;

	[HideInInspector]
	public ObscuredFloat curEnergy;

	private bool inLightZone;

	private bool exiting;

	private bool poisoned;

	private float poisonTime;

	private float depoisonTime;

	private bool isTeleporting;

	private Vector3 offsetDir;

	public List<Transform> parasites;

	public List<Transform> parasiteColliders;

	private float parasiteFactor;

	private bool usingTouch;

	public LayerMask NGUILayer;

	public Camera NGUICamera;

	private bool isPushing;

	private float lockTimer;

	private float additionalForce;

	private Vector3 exitPosition;

	private Vector3 previousDir;

	private Vector2 gestureVector;

	private bool deferSwipe;

	private Vector3 tempVector3;

	private float tempFloat;

	private float idleSmoothDampVel;

	private float targetIdleState;

	private float smoothedIdleState;

	private string eatSFX;

	private string damageSFX;

	public ObscuredBool emitGoldDustParticles;

	public ParticleSystem PushParticles;

	public ParticleSystem bubbles;

	public ParticleSystem FX_speedBoost;

	public ParticleSystem poisonEffect;

	public ParticleSystem poisonTrail;

	private string touchCrystalFX;

	private string deathFX;

	private string poisonDamageFX;

	public UISprite energyBar;

	public UISprite energyBarBgrd;

	public UISprite energyBarHint;

	private GameObject energyBarHintGO;

	private bool energyWarning;

	private int maxEnergyBarWidth;

	private int barMinWidth;

	private float screenshotDelay;

	[Header("EXPLORATION")]
	public ExplorationManager explorationManager;

	public LayerMask discoveryLayers;

	public float LightIntensity => 0f;

	public float LightRange => 0f;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void UnsubscribeEvent()
	{
	}

	private void Start()
	{
	}

	public void RefreshCharacteristics(Jellyfish selectedJellyfish)
	{
	}

	private void SetupEnergyBar()
	{
	}

	private int CalculateWidth()
	{
		return 0;
	}

	private int CalculateHeight()
	{
		return 0;
	}

	private void On_SwipeEnd(Gesture gesture)
	{
	}

	private void On_DoubleTap(Gesture gesture)
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateLifeBarAnchoring()
	{
	}

	private void FixedUpdate()
	{
	}

	private void Swim()
	{
	}

	private void AddGoldenStar()
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	private void OnCollisionExit2D(Collision2D other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerStay2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	private void Teleconnect()
	{
	}

	private void OnTeleconnectFinished()
	{
	}

	[IteratorStateMachine(typeof(_003CDeplete_003Ed__137))]
	private IEnumerator Deplete()
	{
		return null;
	}

	public void AddEnergy(float energyAdded)
	{
	}

	public void KnockBack(Vector2 knockBackDirection)
	{
	}

	public void Damage(ObscuredFloat damage, DeathType deathType)
	{
	}

	[IteratorStateMachine(typeof(_003CBlink_003Ed__141))]
	private IEnumerator Blink()
	{
		return null;
	}

	private void InitAbilities()
	{
	}

	private void CheckUnlockedAbilities()
	{
	}

	public void UseAbility()
	{
	}

	[IteratorStateMachine(typeof(_003CDoSonar_003Ed__145))]
	private IEnumerator DoSonar()
	{
		return null;
	}

	private void Poison(bool byContact, float contactDamage = 0f, Vector3 contactPosition = default(Vector3))
	{
	}

	private void Depoison()
	{
	}

	[IteratorStateMachine(typeof(_003CMakeBubbles_003Ed__148))]
	private IEnumerator MakeBubbles()
	{
		return null;
	}

	private void ExitLevel()
	{
	}

	private void ReportCauseOfDeath(DeathType causeOfDeath)
	{
	}

	private void Die()
	{
	}

	public void AddParasite(Transform parasite, Vector3 attachPoint, Vector3 parasiteSize)
	{
	}

	private void ClearParasites(bool despawnParasites)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadCheckpoint_003Ed__154))]
	private IEnumerator LoadCheckpoint()
	{
		return null;
	}

	public void Restart()
	{
	}

	private void ClearParticleEffects()
	{
	}

	[IteratorStateMachine(typeof(_003CDetectCheating_003Ed__157))]
	private IEnumerator DetectCheating()
	{
		return null;
	}
}
