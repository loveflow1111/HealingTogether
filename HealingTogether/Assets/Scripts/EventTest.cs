
using UnityEngine;

public class EventTest : MonoBehaviour
{
    public void OnFirstHoverEntered()
    {
        Debug.Log($"{gameObject.name} - OnFirstHoverEntered");
    }

    public void OnLastHoverExited()
    {
        Debug.Log($"{gameObject.name} - OnLasttHoverEntered");
    }

    public void OnHoverEntered()
    {
        Debug.Log($"{gameObject.name} - OnHoverEntered");
    }

    public void OnHoverExited()
    {
        Debug.Log($"{gameObject.name} - OnHoverExited");
    }

    public void OnFirstSelectEntered()
    {
        Debug.Log($"{gameObject.name} - OnFirstSelectEntered");
    }

    public void OnLastSelectExited()
    {
        Debug.Log($"{gameObject.name} - OnLastSelectExited");
    }

    public void OnSelectEntered()
    {
        Debug.Log($"{gameObject.name} - OnSelectEntered");
    }

    public void OnSelectExited()
    {
        Debug.Log($"{gameObject.name} - OnSelectExited");
    }

    public void OnActivated()
    {
        Debug.Log($"{gameObject.name} - OnActivated");
    }

    public void OnDeActivated()
    {
        Debug.Log($"{gameObject.name} - OnDeActivated");
    }

}
