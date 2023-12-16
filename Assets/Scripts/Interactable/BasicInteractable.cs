using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public abstract class BasicInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] protected string _name;

    protected AudioSource _audio;

    public string Name { get => _name; }

    protected void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    public virtual void Interact()
    {
        _audio.Play();
    }
}
