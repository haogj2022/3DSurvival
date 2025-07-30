using UnityEngine;

namespace FSG.MeshAnimator
{
	public class AnimatorStateMachine : MonoBehaviour
	{
		public MeshAnimatorBase meshAnimator;

		public bool crossfade;

		public float crossfadeDuration;

		private void OnEnable()
		{
		}

		private void OnAnimationFinished(string anim)
		{
		}
	}
}
