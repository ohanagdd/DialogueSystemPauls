using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField]
    private Dialogue dialogue;

    [SerializeField]
    private DialogueBox dialogueBox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueBox.Display(dialogue);
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueBox.Hide();
        }
    }


}
