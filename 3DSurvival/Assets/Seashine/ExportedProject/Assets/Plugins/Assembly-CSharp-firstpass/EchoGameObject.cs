using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("CORE/EchoGameObject")]
public class EchoGameObject : MonoBehaviour
{
	private static EchoGameObject egoFirst;

	private static EchoGameObject egoLast;

	private static int _echoOverride;

	public static bool _systemInitFlag;

	public static MaterialPropertyBlock echo_MatProperties;

	private bool _echoInit;

	private List<EchoShaderProperty> _shaderProperties;

	private EchoShaderProperty _Color;

	private EchoShaderProperty _echoScale;

	private EchoShaderProperty _echoRGBA;

	private EchoShaderProperty _echoAlpha;

	private EchoShaderProperty _echoMix;

	private EchoShaderProperty _echoHitMix0;

	private EchoShaderProperty _echoHitMix1;

	private EchoShaderProperty _echoHitMix2;

	private EchoShaderProperty _echoHitMix3;

	private EchoShaderProperty _echoUV;

	private EchoShaderProperty _echoHitVector0;

	private EchoShaderProperty _echoHitVector1;

	private EchoShaderProperty _echoHitVector2;

	private EchoShaderProperty _echoHitVector3;

	private EchoShaderProperty _MainTex_ST;

	private EchoGameObject _next;

	private EchoGameObject _prev;

	private Vector3 _originalScale;

	private List<Vector2[]> _echoUVSet;

	private bool _echoHasOutline;

	[HideInInspector]
	public bool echo_PoolActiveList;

	[HideInInspector]
	public EchoGameObject echoFxNext;

	[HideInInspector]
	public bool echoFxFlag;

	[HideInInspector]
	public EchoGameObject[] egoChildren;

	[HideInInspector]
	public int egoChildCount;

	[HideInInspector]
	public int echoUVSetCount;

	[HideInInspector]
	public Mesh echoOutlineMesh;

	[HideInInspector]
	public EchoGameObject egoRoot;

	[HideInInspector]
	public Material[] echo_Mat0;

	[HideInInspector]
	public Material[] echo_Mat1;

	[HideInInspector]
	public int echo_OutlineMatIndex;

	[HideInInspector]
	public int echo_OverlayMatIndex;

	[HideInInspector]
	public SkinnedMeshRenderer echo_skinnedMeshRenderer;

	[HideInInspector]
	public Renderer echo_Renderer;

	[HideInInspector]
	public GameObject echo_OutlineMeshObj;

	[HideInInspector]
	public EchoGameObject echoListNext;

	[HideInInspector]
	public EchoGameObject echoListPrev;

	[HideInInspector]
	public EchoPoolList echoPool;

	[HideInInspector]
	public int renderQueue;

	[HideInInspector]
	public Transform cachedTransform;

	[HideInInspector]
	public int meshVertCount;

	[HideInInspector]
	public MeshFilter meshFilter;

	[HideInInspector]
	public Mesh mesh;

	[HideInInspector]
	public int materialId;

	[HideInInspector]
	public Material[] mainMaterials;

	public Material[] alternateMaterials;

	public bool activeAtStart;

	public bool rendererEnabled;

	public bool fixScale;

	public bool addChildren;

	public Material outlineMaterial;

	public Color outlineColor;

	public Material outlineOverlayMaterial;

	public Color outlineOverlayColor;

	public bool outlineChildren;

	public bool outlineOn;

	public virtual void OnDestroy()
	{
	}

	public virtual void OnDisable()
	{
	}

	public virtual void Awake()
	{
	}

	public virtual void EchoPoolObjectInit()
	{
	}

	public void EchoPoolInit(EchoPoolList ipool = null)
	{
	}

	public static void InitAtStartup()
	{
	}

	public static void ListAddObject(EchoGameObject iego)
	{
	}

	public static void ListRemoveObject(EchoGameObject iego)
	{
	}

	public static EchoGameObject Find(string igameobjectname)
	{
		return null;
	}

	public static EchoGameObject Add(GameObject igo, bool ifixScale = false, bool iaddchildren = false, Material ioutlinemat = null, Material ioverlaymat = null)
	{
		return null;
	}

	public void SetOutlineColor(Color icolor)
	{
	}

	public void SetOutlineOverlayColor(Color icolor)
	{
	}

	public bool Init(GameObject igo = null, bool ifixScale = false, bool iaddchildren = false, bool iactiveflag = true, bool irendererenabled = true)
	{
		return false;
	}

	private void GetMesh()
	{
	}

	private bool DoesParentTreeHaveFixScale(Transform itfrm)
	{
		return false;
	}

	private void ProcessNormalChildren(GameObject igo)
	{
	}

	public void MakeFullOutlineMesh()
	{
	}

	public void EchoActive(bool ionoff)
	{
	}

	public void RendererSet(bool ionoff, bool ichildrenflag = false)
	{
	}

	private void EchoBurnMeshScale()
	{
	}

	public GameObject Clone(bool iactiveflag)
	{
		return null;
	}

	private void SetMaterialsRenderQueueOutline(Material[] imats, int iqueue)
	{
	}

	private void SetMaterialsRenderQueue(Material[] imats, int irenderqueue)
	{
	}

	public void Outline(bool flag)
	{
	}

	public void SwapMaterial()
	{
	}

	public EchoGameObject AddShield(Material imat = null, float iscale = 1.2f)
	{
		return null;
	}

	public float Coord2UV(float pixelpos, float textsize)
	{
		return 0f;
	}

	public float X2U(float pixelpos, Material imat)
	{
		return 0f;
	}

	public float Y2U(float pixelpos, Material imat)
	{
		return 0f;
	}

	public void UVCellMake(float addu, float addv)
	{
	}

	public void UVSetMakeJustify(int iwidth, int iheight, float uvpadding)
	{
	}

	public void UVSetMake(float addu, float addv, int iwidth, int icount)
	{
	}

	public void UVSetMakeScrollH(float uwidth, int usteps)
	{
	}

	public void UVSetMakeScrollV(float vheight, int vsteps)
	{
	}

	public void UVSet(int index)
	{
	}

	private EchoShaderProperty AddShaderProperty(Material isharedMat, string sname)
	{
		return null;
	}

	public EchoShaderProperty AddShaderPropertyFloat(Material isharedMat, string sname)
	{
		return null;
	}

	public EchoShaderProperty AddShaderPropertyVector4(Material isharedMat, string sname)
	{
		return null;
	}

	public void InitShaderProperties(Material[] imats)
	{
	}

	public void ShaderPropertiesSubmit()
	{
	}

	public void ShaderSetTiling(Vector2 itile)
	{
	}

	public void ShaderSetOffset(Vector2 ioffset)
	{
	}

	public void ShaderSet_echoAlpha(float ialpha)
	{
	}

	public void ShaderSet_echoRGBA(Vector4 irgba)
	{
	}

	public Vector4 ShaderGet_echoRGBA()
	{
		return default(Vector4);
	}

	public void ShaderSet_Color(Color icolor)
	{
	}

	public void ShaderSet_echoScale(Vector4 iscale)
	{
	}

	public Vector4 ShaderSet_echoUV(Vector4 iuv, int itype)
	{
		return default(Vector4);
	}

	public void ShaderSetCell_echoUV(int cellnum, float iuvcellwidth, float iuvcellheight, int icolumns, int iuvset = 1)
	{
	}

	public void ShaderSet_echoMix(float imix)
	{
	}

	public void ShaderSet_echoHitMix(int ihitid, float imix)
	{
	}

	public void ShaderSet_echoHitVectorOn(Vector3 ivec, int ihitnum)
	{
	}

	public void ShaderSet_echoHitVectorOff(int ihitnum)
	{
	}
}
