using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int currentScore;
    public static int highscore;

    public static int currentLevel = 2;
    public static int unlockedLevel;
    public static int loadGUI = 0;
    public GameObject winFood = null;

    public bool showWinScreen = false;
    public int winScreenWidth, winScreenHeight;
    public string stringToEdit = "Hello World";

    //Spawn Object
    [SerializeField] private GameObject mObject;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private int maxObjects;

    private int numObjects;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (loadGUI == 1 && numObjects < maxObjects)
        {
            SpawnObject(numObjects);
            numObjects++;
        }  
    }

    void SpawnObject(int num)
    {
        GameObject mObjectClone = Instantiate(mObject, spawnPoint.position, Quaternion.identity) as GameObject;
        mObjectClone.SetActive(true);
    }

    public static void LoadNextLevel()
    {
        if (currentLevel < 4)
        {
            currentLevel += 1;
            Application.LoadLevel(currentLevel);
        }
        else
        {
            print("You win!");
            loadGUI = 1;
        }
    }



    void OnGUI()
    {
        if (loadGUI == 1)
        {
            Rect winScreenRect = new Rect(Screen.width/2 - (Screen.width * 0.5f/2), Screen.height/2 - (Screen.height * 0.5f/2), Screen.width * 0.5f, Screen.height * 0.2f);
            GUI.Box(winScreenRect, "Congratulation!");

            if (GUI.Button(new Rect(winScreenRect.x + winScreenRect.width - 170, winScreenRect.y + winScreenRect.height - 60, 150, 40), "Next Food"))
            {
                Application.LoadLevel("Select");
                loadGUI = 0;
            }
            if (GUI.Button(new Rect(winScreenRect.x + 20, winScreenRect.y + winScreenRect.height - 60, 100, 40), "Quit"))
            {
                Application.LoadLevel("Menu");
                loadGUI = 0;
            }
        }
    }
}
