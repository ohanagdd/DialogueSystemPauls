using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "Dialogue", menuName = "Scriptable Objects/Dialogue")]
// createassetmenu is a decorator
public class Dialogue : ScriptableObject
{
    [SerializeField]
    [Multiline]
    private string content;

    internal void Display(TMP_Text textBox)
    {
        textBox.text = content;
    }
}
