using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyUI.Dialogs;

public class Demo : MonoBehaviour
{
    void Start()
    {
        //Show dialog
        DialogUI.Instance
        .SetTitle("Notification")
        .SetMessage("Hello World")
        .Show();
    }

}
