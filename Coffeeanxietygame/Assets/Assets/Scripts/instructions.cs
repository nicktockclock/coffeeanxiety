using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructions : MonoBehaviour
{
    public SpriteRenderer instructionsrenderer;
    public Sprite instructionssprite;
    // Start is called before the first frame update
    void Start()
    {
        if (LevelManager.Level=="tutorial"){
            instructionsrenderer.sprite = instructionssprite;
        }
    }
}
