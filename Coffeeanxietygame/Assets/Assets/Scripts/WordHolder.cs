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
    private int max;
    private int current;
    // Start is called before the first frame update
    void Start()
    {
        max = levelonecorrect.Length;
        current = 0;
        sentence.sprite = sentences[0];
    }

    // Update is called once per frame
    void Update()
    {
        
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
            case "one":
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
