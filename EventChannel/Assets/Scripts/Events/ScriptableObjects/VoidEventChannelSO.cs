using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/TransfromEventChannel", fileName = "New TransfromEventChannelSO")]
public class VoidEventChannel : ScriptableObject
{
    public UnityAction OnEventRaised;

    public void RaiseEvent()
    {
        if(OnEventRaised != null)
        {
            OnEventRaised.Invoke();
        }
        else
        {
            Debug.LogWarning("");
        }
    }
}
