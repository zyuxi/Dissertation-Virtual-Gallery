using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string loadLevel;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(loadLevel);
        DontDestroyOnLoad(transform.gameObject);
    }
}
