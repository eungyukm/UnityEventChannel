using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ScriptableObject에 설명을 추가하는 BaseSO
/// </summary>
public class DescriptionBaseSO : ScriptableObject
{
    [TextArea] public string description;
}
