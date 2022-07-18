using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public int levelToLoad;

    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel("Level " + levelToLoad.ToString());
    }
}
