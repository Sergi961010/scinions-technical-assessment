using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private float _horizontal;
    private bool _isFacingRight = true;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        Flip();
    }

    private void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(_horizontal * _speed * Time.deltaTime, 0, 0);
    }

    private void Flip()
    {
        if (_isFacingRight && _horizontal < 0 || !_isFacingRight && _horizontal > 0)
        {
            _isFacingRight = !_isFacingRight;
            _spriteRenderer.flipX = !_spriteRenderer.flipX;
        }
    }
}