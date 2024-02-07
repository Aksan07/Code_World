
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
public class LevelSelection : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    public Text ProgressText;

    public void GoToScene(string sceneName){
       StartCoroutine(LoadAsynchronously(sceneName));
    }
    IEnumerator LoadAsynchronously(string sceneName){
         AsyncOperation operations =SceneManager.LoadSceneAsync(sceneName);
         loadingScreen.SetActive(true);
         while(!operations.isDone){
            float progress =Mathf.Clamp01(operations.progress/0.9f);
            slider.value=progress;
            ProgressText.text=progress*100f +"%";

            yield return null;
         }
         

    }

}
