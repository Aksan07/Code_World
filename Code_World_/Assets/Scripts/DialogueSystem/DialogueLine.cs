using System.Collections;
using UnityEngine.UI;
using UnityEngine;

namespace DialogueSystem{
public class DialogueLine : DialogueBaseClass
{
    private Text textHolder;
    [SerializeField]private string input;

    private void Awake(){
        textHolder=GetComponent<Text>();
        StartCoroutine(WriteText(input,textHolder));
    }
}

}


