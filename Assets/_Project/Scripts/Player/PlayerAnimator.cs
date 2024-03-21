using UnityEngine;
public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    private Animator _animator;
    private readonly int _horizontal = Animator.StringToHash("Horizontal");
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        _animator.SetFloat(_horizontal, Mathf.Abs(_playerMovement.Horizontal));
    }
}