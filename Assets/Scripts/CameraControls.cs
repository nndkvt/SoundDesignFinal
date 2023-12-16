using UnityEngine;

public class CameraControls : MonoBehaviour
{
    [SerializeField] private float _sensX;
    [SerializeField] private float _sensY;

    [SerializeField] private Transform _playerOrientation;

    private float _xRotation;
    private float _yRotation;

    private bool _isCursorLocked = false;

    private void Start()
    {
        UpdateCursorInput();
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * _sensX;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * _sensY;

        _yRotation += mouseX;
        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90.0f, 90.0f);

        transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0);
        _playerOrientation.rotation = Quaternion.Euler(0, _yRotation, 0);
    }

    private void UpdateCursorInput()
    {
        _isCursorLocked = !_isCursorLocked;

        if (_isCursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
