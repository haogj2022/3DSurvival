using System.Runtime.CompilerServices;
using UnityEngine;

public class EchoFXEvent : EchoLinkedList
{
	public delegate void EventStart();

	public delegate void EventDone(bool forcestop);

	public delegate bool EventCustom(EchoGameObject iego, float ipercentdone, float iratio, float itime);

	public delegate void EventProgress(float ipercentdone, int stage);

	private static int _ticks;

	public static int poolListID;

	private static float fxPer;

	private static float fxRatio;

	private static float fxNum1;

	private static float fxNum2;

	private static EchoGameObject listFirst;

	private static EchoGameObject listLast;

	public EchoET eventType;

	public EchoGameObject ego;

	private float fxStartDelay;

	private int fxStage;

	private Vector4 fxUVAdd;

	private Vector4 fxUVBase;

	private float fxTime;

	private float fxDuration;

	private float fxArg1;

	private float fxArg2;

	private float fxArg3;

	private int fxIArg1;

	private int fxIArg2;

	private Transform fxTransform;

	private Vector3 fxPosHold;

	private Vector4 fxScale1;

	private Vector4 fxScale2;

	private int fxShieldHitID;

	private Vector4 fxRGBA1;

	private Vector4 fxRGBA2;

	private Vector4 fxUV1;

	private Vector4 fxUV2;

	private Vector2 fxTile1;

	private Vector2 fxTile2;

	private Vector2 fxTileBase;

	private int fxAnimReps;

	private float fxAnimCurCell;

	private int fxAnimCurCellOld;

	private float fxAnimCurCellDir;

	private int fxAnimCellCount;

	private int fxAnimCellStart;

	private float fxAcc;

	private bool forceStop;

	private bool fxOver;

	private float fxPeriod;

	private float fxAmplitude;

	private float fxOffset;

	private int fxUse_MainTex_ST;

	private EchoFilter echoFilter;

	private int fxTempNum;

	private float fxSpeed;

	private float fxSpeedCur;

	private float fxDamp;

	private float fxFrameCur;

	private float fxFrameFirst;

	private float fxFrameLast;

	private int fxDirection;

	private bool _fxEventProgressFlag;

	public event EventStart fxEventStart
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

	public event EventDone fxEventDone
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

	public event EventCustom fxEventCustom
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

	public event EventProgress fxEventProgress
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

	public static void PoolAlloc(int iNumPoolObjs = 32, bool idynamicadd = false)
	{
	}

	public static void DynamicAddObj()
	{
	}

	public static void ProcessAllInUpdate()
	{
	}

	private void AddToEgoList()
	{
	}

	public void Use_MainTex_ST()
	{
	}

	public void AddFilter(EchoFilter ifilter, float iperiod = 0.25f, float iamplitude = 1f, float ioffset = 0f)
	{
	}

	public void StartDelay(float idelay, EventStart icallback = null)
	{
	}

	public void SetEventStart(EventStart icallback)
	{
	}

	public void SetEventDone(EventDone icallback)
	{
	}

	public void SetEventProgress(EventProgress icallback)
	{
	}

	public static EchoFXEvent StartEventCustom(EchoGameObject iego, float itime, float iduration, EventCustom icallback)
	{
		return null;
	}

	private void EventStartNull()
	{
	}

	private void EventDoneNull(bool forcestop)
	{
	}

	private void EventProgressNull(float ipercentdone, int stage)
	{
	}

	private bool EventCustomNull(EchoGameObject iego, float ipercentdone, float iratio, float itime)
	{
		return false;
	}

	public void UVSetSpeed(float ifps)
	{
	}

	public void UVSetDamp(float idamp)
	{
	}

	public void EventDuration(float iduration)
	{
	}

	public static EchoFXEvent CellAnimate_UVSet(EchoGameObject iego, int istartcell, int icellcount, float ifpsspeed = 32f, int ireps = 0, float ifxduration = 0f)
	{
		return null;
	}

	public static EchoFXEvent Blink_UVSet(EchoGameObject iego, int iuvset1, int iuvset2, float ifxduration)
	{
		return null;
	}

	public static EchoFXEvent Scroll_echoUV(EchoGameObject iego, Vector4 iuvAdd, float ifxduration = 0f)
	{
		return null;
	}

	public static EchoFXEvent ScrollSection_echoUV(EchoGameObject iego, Vector4 iuvstart, Vector4 iuvend, int ireps, float ifxduration = 1f)
	{
		return null;
	}

	public static EchoFXEvent CellAnimate_echoUV(EchoGameObject iego, float iuvcellwidth, float iuvcellheight, int icolumns, int istartcell, int icellcount, float itimepercell, int ireps = 1)
	{
		return null;
	}

	public static EchoFXEvent CellAnimateBlend_echoUV(EchoGameObject iego, float iuvcellwidth, float iuvcellheight, int icolumns, int istartcell, int icellcount, float itimepercell, int ireps = 1)
	{
		return null;
	}

	public static EchoFXEvent Blink_echoUV(EchoGameObject iego, Vector4 iuvoffset1, Vector4 iuvoffset2, float ifxduration)
	{
		return null;
	}

	public static EchoFXEvent Random_echoUV(EchoGameObject iego, float ifxduration = 0f)
	{
		return null;
	}

	public static EchoFXEvent Animate_ShaderTiling(EchoGameObject iego, Vector2 itilestart, Vector2 itileend, float ifxduration = 0f)
	{
		return null;
	}

	public static EchoFXEvent Animate_echoScale(EchoGameObject iego, Vector3 iscalestart, Vector3 iscaleend, float ifxduration = 0f)
	{
		return null;
	}

	public static EchoFXEvent Animate_echoAlpha(EchoGameObject iego, float ialphastart, float ialphaend, float ifxduration = 0f)
	{
		return null;
	}

	public static EchoFXEvent Animate_echoRGBA(EchoGameObject iego, Vector4 irgba1, Vector4 irgba2, float ifxduration = 1f)
	{
		return null;
	}

	public static EchoFXEvent ShieldHit_echoShader(EchoGameObject iego, int ihitid, Vector3 idirection, float iminalpha, float imaxalpha, float ifxduration = 0f)
	{
		return null;
	}

	public static EchoFXEvent ShieldOn_echoShader(EchoGameObject iego, float imaxalpha, float ifxduration = 1f)
	{
		return null;
	}

	public static EchoFXEvent ShieldOff_echoShader(EchoGameObject iego, float imaxalpha, float ifxduration = 1f)
	{
		return null;
	}

	public static EchoFXEvent ShieldDown_echoShader(EchoGameObject iego, float imaxalpha, float ifxduration = 2f)
	{
		return null;
	}

	public static EchoFXEvent Fusion_echoShader(EchoGameObject iego, float istart, float iend, float ijitter, float ifxduration = 1f)
	{
		return null;
	}

	public static EchoFXEvent Random_echoMix(EchoGameObject iego, float ifxduration = 0f)
	{
		return null;
	}

	public static EchoFXEvent Dissolve_echoShader(EchoGameObject iego, float imix1 = -0.5f, float imix2 = 1.5f, float ifxduration = 1f)
	{
		return null;
	}

	public static EchoFXEvent ShakeGameObject(Transform itransform, float istrength, float ifxduration)
	{
		return null;
	}

	public static void StopEvent(EchoFXEvent iefx)
	{
	}

	public static void StopAllEvents()
	{
	}

	private void ProcessAnimation()
	{
	}

	public override void ProcessInUpdate()
	{
	}
}
