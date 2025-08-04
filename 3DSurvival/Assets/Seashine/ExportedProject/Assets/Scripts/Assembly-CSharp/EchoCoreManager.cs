using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class EchoCoreManager : MonoBehaviour
{
	public static RenderTexture echoRT;

	private static EchoLight _first;

	private static EchoLight _last;

	private static bool _use4ExtraPoint;

	private static bool _useLights;

	private static EchoLight _mainDirLight;

	private static EchoLight _mainPointLight;

	private static EchoLight[] _extraLights;

	private static int _extraLightCount;

	private static Vector4 _dirLightColor;

	private static Vector4 _echo4LightColorRH;

	private static Vector4 _echo4LightColorGH;

	private static Vector4 _echo4LightColorBH;

	private static Vector4 _echo4LightPosXH;

	private static Vector4 _echo4LightPosYH;

	private static Vector4 _echo4LightPosZH;

	private static Vector4 _echo4LightRangeH;

	private static Vector4 _echo4LightColorR;

	private static Vector4 _echo4LightColorG;

	private static Vector4 _echo4LightColorB;

	private static Vector4 _echo4LightPosX;

	private static Vector4 _echo4LightPosY;

	private static Vector4 _echo4LightPosZ;

	private static Vector4 _echo4LightRange;

	private static Vector4 _echoDirLightColor;

	private static Vector4 _echoDirLightPos;

	private static Vector4 _echoDirLightDir;

	private static Vector4 _echoPointLightColor;

	private static Vector4 _echoPointLightPos;

	private static float _echoPointLightRange;

	private static Color _echoAmbientLightColor;

	private static Vector3 _lookAhead;

	private static Transform _cameraTransform;

	private static EchoLight[] _found;

	private static Light[] _lights;

	private static bool _initFlag;

	public bool dynamicAdd;

	public int maxEchoFXEvents;

	public bool UnityLights;

	public static bool useUnityLights;

	public bool DoubleLight;

	public bool AddBeastCode;

	public bool LightProbes;

	public float lightLookAhead;

	public float AmbientLightAdjust;

	public bool MainDirLight;

	public float MainDirAdjust;

	public bool MainDirOnlyShadows;

	public bool MainDirBump;

	public bool MainDirSpec;

	public bool MainDirSpot;

	public float MainDirSpotSize;

	public bool MainDirShadowColorEnable;

	public Color MainDirShadowColor;

	public bool MainPointLight;

	public float MainPointAdjust;

	public bool MainPointBump;

	public bool MainPointSpec;

	public bool MainPointFalloff;

	public bool MainPointRampFade;

	public bool FourPointLights;

	public float FourPointAdjust;

	public bool FourPointSpec;

	private Color _mainDirShadowColor;

	private float _mainDirSpotSize;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public static void AddList(EchoLight iel)
	{
	}

	public static void RemoveList(EchoLight iel)
	{
	}

	private bool SetupLevelLoad()
	{
		return false;
	}

	private bool InitLights()
	{
		return false;
	}

	public static void Set4ExtraLightsBlack()
	{
	}

	public static void SetAllLightsBlack()
	{
	}

	public static void ResetShaderVariables()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public static void TurnOffLight(EchoLightType elt)
	{
	}

	public static bool Vector4NotEqual(Vector4 ivec1, Vector4 ivec2)
	{
		return false;
	}

	public void SetLightInfo()
	{
	}
}
