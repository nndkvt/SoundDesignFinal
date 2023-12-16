using UnityEngine;

public class Lightswitch : BasicInteractable
{
    [SerializeField] private Light[] _lights;

    private bool _isLightOn = true;

    public override void Interact()
    {
        base.Interact();
        ChangeLights();
    }

    private void ChangeLights()
    {
        _isLightOn = !_isLightOn;

        if (_isLightOn)
        {
            foreach (Light light in _lights)
            {
                light.gameObject.SetActive(true);
            }
        }
        else
        {
            foreach (Light light in _lights)
            {
                light.gameObject.SetActive(false);
            }
        }
    }
}
