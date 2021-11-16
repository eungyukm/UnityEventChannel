using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/IntEventChannel", fileName = "New IntEventChannelSO")]
public class IntEventChannelSO : DescriptionBaseSO
{
    public UnityAction<int> OnEventRaised;

    public void RaiseEvent(int value)
    {
        if(OnEventRaised != null)
        {
            OnEventRaised.Invoke(value);
        }
        else
        {
            Debug.LogWarning("IntEventChannelSO에 이벤트를 등록해주세요.");
        }
    }
}
