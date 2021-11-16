using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/GameObjectEventChannel", fileName = "New GameObjectEventChannelSO")]
public class GameObjectEventChannelSO : DescriptionBaseSO
{
    public UnityAction<GameObject> OnEventRaised;

    public void RaiseEvent(GameObject value)
    {
        if(OnEventRaised != null)
        {
            OnEventRaised.Invoke(value);
        }
        else
        {
            Debug.LogWarning("GameObjectEventChannelSO에 이벤트가 없습니다.");
        }
    }
}
