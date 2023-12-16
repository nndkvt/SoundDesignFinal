using UnityEngine;

enum MouseButton
{
    Left = 0,
    Right = 1,
    Middle = 2,
}

public class Interactor : MonoBehaviour
{
    [SerializeField] private float _interactRange;
    [SerializeField] private MouseButton _interactButton;

    private void Update()
    {
        Ray r = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(r, out RaycastHit hitInfo, _interactRange))
        {
            if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactable))
            {
                InteractableName.Instance.UpdateDescription(interactable.Name);

                if (Input.GetMouseButtonDown((int)_interactButton))
                {
                    interactable.Interact();
                }
            }
            else
            {
                InteractableName.Instance.ClearDescription();
            }
        }
        else
        {
            InteractableName.Instance.ClearDescription();
        }
    }
}
