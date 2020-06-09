using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneAudio : MonoBehaviour
{
    public AudioClip tutorial;
    public AudioClip levelone;
    public AudioClip leveltwo;
    public AudioClip levelthree;
    public AudioClip levelonewin;
    public AudioClip leveltwowin;
    public AudioClip levelthreewin;
    public AudioClip loser;
    // Start is called before the first frame update
    void Start()
    {
        switch (LevelManager.Level){
            case "tutorial":
                gameObject.GetComponent<AudioSource>().clip = tutorial;
                break;
            case "one":
                gameObject.GetComponent<AudioSource>().clip = levelone;
                break;
            case "two":
                gameObject.GetComponent<AudioSource>().clip = leveltwo;
                break;
            case "three":
                gameObject.GetComponent<AudioSource>().clip = levelthree;
                break;
            case "tutorialwin":
                gameObject.GetComponent<AudioSource>().clip = tutorial;
                break;
            case "onewin":
                gameObject.GetComponent<AudioSource>().clip = levelonewin;
                break;
            case "twowin":
                gameObject.GetComponent<AudioSource>().clip = leveltwowin;
                break;
            case "threewin":
                gameObject.GetComponent<AudioSource>().clip = levelthreewin;
            break;
            case "loser":
                gameObject.GetComponent<AudioSource>().clip = loser;
                break;
        }
        gameObject.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
