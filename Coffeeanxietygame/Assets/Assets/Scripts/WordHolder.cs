using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordHolder : MonoBehaviour
{
    public Sprite[] sentences;
    public Sprite[] levelonedamage;
    public Sprite[] levelonecorrect;
    public SpriteRenderer sentence;
    public SpriteRenderer[] construct;
    public GameObject confidence;
    private int max;
    private int current;
    private string level;
    // Start is called before the first frame update
    void Start()
    {
        level = "three";
        switch (level){
            case "tutorial":
                break;
            case "one":
                break;
            case "two":
                break;
            case "three":
                confidence.active=true;
                break;
        }
        max = levelonecorrect.Length;
        current = 0;
        sentence.sprite = sentences[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generateConfidence(){
        confidence.transform.position = (new Vector3(Random.Range(-11, 11), Random.Range(-8, 2), 0));
    }

    public void incrementcurrent(string level){
        switch(level){
            case "one":
            construct[current].sprite = levelonecorrect[current];
                if (current!=levelonecorrect.Length-1){
                    current++;
                }
                break;
        }
    }

    public Sprite retrieveDamageWord(string level){
        switch(level){
            case "tutorial":
            return levelonedamage[Random.Range(0, levelonedamage.Length-1)];
            case "one":
            return levelonedamage[Random.Range(0, levelonedamage.Length-1)];
            case "two":
            return levelonedamage[Random.Range(0, levelonedamage.Length-1)];
            case "three":
            return levelonedamage[Random.Range(0, levelonedamage.Length-1)];
        }
        return null;
    }

    public Sprite retrieveCorrectWord(string level){
        switch(level){
            case "one":
            return levelonecorrect[current];
        }
        return null;
    }
}
