using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(menuName = "Playground/Gameplay/Data/" + nameof(TestData))]

public class TestData : ScriptableObject
{
    [PreviewField(65), HideLabel, HorizontalGroup("HorizontalSplit", 65), VerticalGroup("HorizontalSplit/left")]
    public Sprite Sprite;

    [VerticalGroup("HorizontalSplit/right")]
    public float FloatNumber;

    [VerticalGroup("HorizontalSplit/right")]
    [Range(0, 100)]
    public int IntNumber;

    [VerticalGroup("HorizontalSplit/right")]
    public bool IsEnabled;

    [ShowIf("IsEnabled")]
    public int XXXX;
}