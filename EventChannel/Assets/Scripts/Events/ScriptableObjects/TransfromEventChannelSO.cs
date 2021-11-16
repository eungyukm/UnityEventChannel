using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/TransfromEventChannel", fileName = "New TransfromEventChannelSO")]
public class TransfromEventChannelSO : DescriptionBaseSO
{
    public UnityAction<int> OnEventRaised;

    public void RaiseEvent(int value)
    {
        if (OnEventRaised != null)
        {
            OnEventRaised.Invoke(value);
        }
        else
        {
            Debug.LogWarning("TransfromEventChannelSO에 이벤트를 등록해주세요.");
        }
    }
}
