using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float _speed;
    [SerializeField] private float _groundDrag;

    [Header("Game Objects")]
    [SerializeField] private Transform _playerOrientation;

    private float _horizontalInput;
    private float _verticalInput;

    private Vector3 _direction;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.freezeRotation = true;
        _rigidbody.drag = _groundDrag;
    }

    private void Update()
    {
        PlayerInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void PlayerInput()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void MovePlayer()
    {
        _direction = _playerOrientation.forward * _verticalInput + _playerOrientation.right * _horizontalInput;

        _rigidbody.AddForce(_direction.normalized * _speed * 10f, ForceMode.Force);
    }
}
