using System;
using System.Collections.Generic;
using UnityEngine;

public class TweenLetters : UITweener
{
	[DoNotObfuscateNGUI]
	public enum AnimationLetterOrder
	{
		Forward = 0,
		Reverse = 1,
		Random = 2
	}

	private struct LetterProperties
	{
		public float start;

		public float duration;

		public Vector3 pos;

		public Quaternion rot;

		public Vector3 scale;
	}

	[Serializable]
	public class AnimationProperties
	{
		[Tooltip("If set, overrides the tween's animation duration")]
		public float duration;

		public AnimationLetterOrder animationOrder;

		[Range(0f, 1f)]
		public float overlap;

		[Tooltip("If set, each letter will animate with a random duration")]
		public bool randomDurations;

		[MinMaxRange(0f, 1f)]
		public Vector2 randomness;

		[HideInInspector]
		public bool upgraded;

		[HideInInspector]
		public Vector2 offsetRange;

		[HideInInspector]
		public Vector3 pos;

		[HideInInspector]
		public Vector3 rot;

		[HideInInspector]
		public Vector3 scale;

		public Vector3 pos1;

		public Vector3 pos2;

		public Vector3 rot1;

		public Vector3 rot2;

		public Vector3 scale1;

		public Vector3 scale2;

		[Tooltip("Starting or finishing alpha")]
		[Range(0f, 1f)]
		public float alpha;

		public void Upgrade()
		{
		}
	}

	public AnimationProperties hoverOver;

	public AnimationProperties hoverOut;

	private UILabel mLabel;

	private int mVertexCount;

	private int[] mLetterOrder;

	private LetterProperties[] mLetter;

	private AnimationProperties mCurrent;

	protected void OnValidate()
	{
	}

	private void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public override void Play(bool forward)
	{
	}

	private void OnPostFill(UIWidget widget, int bufferOffset, List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
	{
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	private void SetLetterOrder(int letterCount)
	{
	}

	private void GetLetterDuration(int letterCount)
	{
	}

	private float ScaleRange(float value, float baseMax, float limitMax)
	{
		return 0f;
	}

	private static Vector3 GetCenter(List<Vector3> verts, int firstVert, int length)
	{
		return default(Vector3);
	}
}
