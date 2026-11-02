using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogueBox : MonoBehaviour
{
    [SerializeField]
    private TMP_Text content;

    [SerializeField]
    private Image portrait;

    private void Start();

    internal void Display(Dialogue dialogue)
    {
        dialogue.Display(content);
    }
}
