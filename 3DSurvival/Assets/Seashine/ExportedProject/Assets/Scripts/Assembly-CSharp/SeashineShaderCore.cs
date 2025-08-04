using UnityEngine;

[ExecuteInEditMode]
public class SeashineShaderCore : MonoBehaviour
{
	public static RenderTexture seashineRT;

	private static SeashineLight _first;

	private static SeashineLight _last;

	private static bool _useLights;

	private static SeashineLight _mainPointLight;

	private static Vector4 _dirLightColor;

	private static Vector4 _seashinePointLightColor;

	private static Vector4 _seashinePointLightPos;

	private static float _seashinePointLightRange;

	private static float _seashinePointLightIntensity;

	private static Color _seashineAmbientLightColor;

	private static Vector3 _lookAhead;

	private static Transform _cameraTransform;

	private static SeashineLight[] _found;

	private static Light[] _lights;

	private static bool _initFlag;

	public bool UnityLights;

	public static bool useUnityLights;

	public bool DoubleLight;

	public bool AddBeastCode;

	public bool LightProbes;

	public float lightLookAhead;

	public float AmbientLightAdjust;

	public bool MainPointLight;

	public float MainPointAdjust;

	public bool MainPointBump;

	public bool MainPointSpec;

	public bool MainPointFalloff;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public static void AddList(SeashineLight isl)
	{
	}

	public static void RemoveList(SeashineLight isl)
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

	public static void TurnOffLight(SeashineLightType elt)
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
