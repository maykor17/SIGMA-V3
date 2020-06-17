using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class LevelArray
{
    [System.Serializable]

    public struct levels
    {        
        public Level[] X;
    }
    public levels[] Y = new levels[25];
    
}
