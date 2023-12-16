using TMPro;
using UnityEngine;

public class InteractableName : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _description;

    public static InteractableName Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateDescription(string description)
    {
        _description.text = description;
    }

    public void ClearDescription()
    {
        _description.text = "";
    }
}
