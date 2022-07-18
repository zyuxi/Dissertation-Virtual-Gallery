using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string loadLevel;
    public GameObject player;

    private void OnMouseDown()
    {
        Application.LoadLevel (loadLevel);
        PlayerPrefs.SetFloat("playerPosX", player.transform.position.x);
        PlayerPrefs.SetFloat("playerPosY", player.transform.position.y);
        PlayerPrefs.SetFloat("playerPosZ", player.transform.position.z);
    }
}
