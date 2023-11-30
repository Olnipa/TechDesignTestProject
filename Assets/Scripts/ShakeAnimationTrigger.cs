using UnityEngine;

[RequireComponent(typeof(Animator))]
public class ShakeAnimationTrigger : MonoBehaviour
{
    private Animator _animator;

    private const string ShakeTriggerName = "Shaking";

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        _animator.SetTrigger(ShakeTriggerName);
    }
}