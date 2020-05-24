using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// This is meant to make the game change scenes between levels. 
/// This happens when the player presses a corresponding button. 
/// </summary>
public class Scenetransition : MonoBehaviour
{
    public Animator sceneSition;
    public string sceneName;
    private int sceneIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {

        SceneSwap();
        
        

    }
    public void SceneSwap()
    {
        //Code snippet that determines what scene to load, but also prevents loading the same scene while you're still in it.
        if (Input.GetKeyDown(KeyCode.Alpha0) && sceneIndex != 1)
        {
            sceneName = "titlescreen";
            StartCoroutine(LoadScene());
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && sceneIndex != 0)
        {
            sceneName = "TestBattleScene";
            StartCoroutine(LoadScene());
        }
        if (Input.GetKeyDown(KeyCode.V) && sceneIndex != 2)
          {
            sceneName = "CoopScene";
            StartCoroutine(LoadScene());
        }
        if (Input.GetKeyDown(KeyCode.Escape)) //Quit function. Doesn't work while in Unity Editor.
        {
            Application.Quit();
        }
    }
    public void SceneReset()
    {
        //Public function called by both gamemodes in order to swap the scenes properly. 
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
     //Coroutine that loads the scene using the set scene name.    
        sceneSition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
        sceneSition.ResetTrigger("end");
        
        
    }
    
}
