using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    void Awake(){
        DontDestroyOnLoad(this);
    }
    
    private static string level;

    public static string Level 
    {
        get 
        {
            return level;
        }
        set 
        {
            level = value;
        }
    }
}
