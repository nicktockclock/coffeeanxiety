using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    LevelManager level;
    public Animator sceneSition;
    // Start is called before the first frame update

    public void tutorial(){
        LevelManager.Level = "tutorial";
        StartCoroutine(LoadScene());
    }

    public void one(){
        LevelManager.Level = "one";
        StartCoroutine(LoadScene());
    }

    public void two(){
        LevelManager.Level = "two";
        StartCoroutine(LoadScene());
    }

    public void three(){
        LevelManager.Level = "three";
        StartCoroutine(LoadScene());
    }

    public void main(){
        SceneManager.LoadScene(0);
    }

    public void restart(){
        StartCoroutine(ReloadLoadScene());
    }
    IEnumerator LoadScene()
    {
        //Coroutine that loads the scene using the set scene name.    
        sceneSition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(1);
        sceneSition.ResetTrigger("end");

    }

    IEnumerator ReloadLoadScene()
    {
        //Coroutine that loads the scene using the set scene name.    
        sceneSition.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(2);
        sceneSition.ResetTrigger("end");

    }
    }
