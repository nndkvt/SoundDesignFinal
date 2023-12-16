using UnityEngine;

public class MainCameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _cameraHolder;

    private void Update()
    {
        transform.position = _cameraHolder.position;
    }
}
