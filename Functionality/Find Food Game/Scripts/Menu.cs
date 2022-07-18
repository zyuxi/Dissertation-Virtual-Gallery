using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GUISkin skin;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    void OnGUI()
    {
        GUI.skin = skin;
        GUI.Label (new Rect(10, 10, 400, 75), "Menu");
        if (GUI.Button(new Rect(10, 150, 100, 45), "Play"))
        {
            Application.LoadLevel(6);
        }
        if (GUI.Button(new Rect(10, 205, 100, 45), "Quit"))
        {
            Application.LoadLevel(0);
        }
    }
}
