using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickConvoStarter : MonoBehaviour
{

    [SerializeField] private NPCConversation myConversation;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        // When the C key is pressed, start the conversation by calling the StartConversation method of the ConversationManager,
        // and passing the NPCConversation object stored in the myConversation field.
        {
            ConversationManager.Instance.StartConversation(myConversation);

        }
    }
}