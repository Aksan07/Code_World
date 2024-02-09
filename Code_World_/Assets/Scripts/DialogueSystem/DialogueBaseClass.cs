using Unity.Collections;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;
namespace DialogueSystem{
public class DialogueBaseClass : MonoBehaviour
{
    protected IEnumerator WriteText(string input,Text textHolder){
        for (int i=0;i<input.Length;i++){
            textHolder.text+=input[i];
            yield return new WaitForSeconds(0.1f);
        }

    }
   

}

}

