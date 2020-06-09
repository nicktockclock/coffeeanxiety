using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordHolder : MonoBehaviour
{
    public Sprite[] sentences;
    public Sprite[] tutorialdamage;
    public Sprite[] levelonedamage;
    public Sprite[] leveltwodamage;
    public Sprite[] levelthreedamage;
    public Sprite[] tutorialcorrect;
    public Sprite[] levelonecorrect;
    public Sprite[] leveltwocorrect;
    public SpriteRenderer sentence;
    public SpriteRenderer[] construct;
    public GameObject confidence;
    private int max;
    private int current;
    private string level;
    // Start is called before the first frame update
    void Start()
    {
        level = LevelManager.Level;
        switch (level){
            case "tutorial":
                max = tutorialcorrect.Length;
                current = 0;
                break;
            case "one":
                max = levelonecorrect.Length;
                current = 0;
                break;
            case "two":
                max = leveltwocorrect.Length;
                current = 0;
                break;
            case "three":
                confidence.SetActive(true);
                break;
        }
        //sentence.sprite = sentences[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool checkwon(){
        if (current==max-1){
            return true;
        }
        return false;
    }

    public void generateConfidence(){
        confidence.transform.position = (new Vector3(Random.Range(-11, 11), Random.Range(-8, 2), 0));
    }

    public void incrementcurrent(string level){
        switch (level){
            case "tutorial":
                construct[current].sprite = tutorialcorrect[current];
                if (current!=tutorialcorrect.Length-1){
                    current++;
                }
                break;
            case "one":
                construct[current].sprite = levelonecorrect[current];
                if (current!=levelonecorrect.Length-1){
                    current++;
                }
                break;
            case "two":
                construct[current].sprite = leveltwocorrect[current];
                if (current!=leveltwocorrect.Length-1){
                    current++;
                }
                break;
        }
    }

    public Sprite retrieveDamageWord(string level){
        switch(level){
            case "tutorial":
            return tutorialdamage[Random.Range(0, levelonedamage.Length-1)];
            case "one":
            return levelonedamage[Random.Range(0, levelonedamage.Length-1)];
            case "two":
            return leveltwodamage[Random.Range(0, levelonedamage.Length-1)];
            case "three":
            return levelthreedamage[Random.Range(0, levelonedamage.Length-1)];
        }
        return null;
    }

    public Sprite retrieveCorrectWord(string level){
        switch (level){
            case "tutorial":
                return tutorialcorrect[current];
            case "one":
                return levelonecorrect[current];
            case "two":
                return leveltwocorrect[current];
        }
        return null;
    }
}
