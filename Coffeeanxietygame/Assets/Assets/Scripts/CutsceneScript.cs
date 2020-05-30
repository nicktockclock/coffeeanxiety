using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneScript : MonoBehaviour
{
    public Sprite[] tutorial;
    public Sprite[] levelone;
    public Sprite[] leveltwo;
    public Sprite[] levelthree;
    public GameObject frame;
    int current;
    int end;
    // Start is called before the first frame update
    void Start()
    {
        current = 0;
        switch (LevelManager.Level){
            case "tutorial":
                SceneManager.LoadScene(2);
                break;
            case "one":
                end = levelone.Length-1;
                frame.GetComponent<SpriteRenderer>().sprite = levelone[current];
                break;
            case "two":
                SceneManager.LoadScene(2);
                break;
            case "three":
                SceneManager.LoadScene(2);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            if (current==end){
                SceneManager.LoadScene(2);
            }
            else{
                switch (LevelManager.Level){
            case "tutorial":
                SceneManager.LoadScene(2);
                break;
            case "one":
                current++;
                frame.GetComponent<SpriteRenderer>().sprite = levelone[current];
                break;
            case "two":
                SceneManager.LoadScene(2);
                break;
            case "three":
                SceneManager.LoadScene(2);
                break;
                }  
            }            
        }
    }
}
