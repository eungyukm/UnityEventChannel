using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/BoolEventChannel", fileName = "New BoolEventChannelSO")]
public class BoolEventChannelSO : DescriptionBaseSO
{
    UnityAction<bool> OnEventRaised;

    public void RaiseEvent(bool value)
    {
        if(OnEventRaised != null)
        {
            OnEventRaised.Invoke(value);
        }
        else
        {
            Debug.LogWarning("BoolEventChannelSO에 이벤트가 없습니다.");
        }
    }
}
