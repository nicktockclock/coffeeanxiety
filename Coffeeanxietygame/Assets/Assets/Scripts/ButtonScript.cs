using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    LevelManager level;
    // Start is called before the first frame update

    public void tutorial(){
        LevelManager.Level = "tutorial";
        SceneManager.LoadScene(1);
    }

    public void one(){
        LevelManager.Level = "one";
        SceneManager.LoadScene(1);
    }

    public void two(){
        LevelManager.Level = "two";
        SceneManager.LoadScene(1);
    }

    public void three(){
        LevelManager.Level = "three";
        SceneManager.LoadScene(1);
    }
}
