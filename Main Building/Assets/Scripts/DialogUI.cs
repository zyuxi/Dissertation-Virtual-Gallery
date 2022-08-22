using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EasyUI.Dialogs
{
    public class Dialog
    {
        public string Title = "Pizza Margherita";
        public string Message = "Message goes here.";
    }
    public class DialogUI : MonoBehaviour
    {
        [SerializeField] GameObject canvas;
        [SerializeField] Text titleUIText;
        [SerializeField] Text messageUIText;
        [SerializeField] Button closeUIButton;

        Dialog dialog = new Dialog();

        //Singleton pattern
        public static DialogUI Instance;

        void Awake()
        {
            Instance = this;
            
            //Add close event listener
            closeUIButton.onClick.RemoveAllListeners();
            closeUIButton.onClick.AddListener(Hide);
        }

        //Set Dialog Title
        public DialogUI SetTitle(string title)
        {
            dialog.Title = title;
            return Instance;
        }

        //Set Dialog Message
        public DialogUI SetMessage(string message)
        {
            dialog.Message = message;
            return Instance;
        }

        //Show dialog
        public void Show()
        {
            titleUIText.text = dialog.Title;
            messageUIText.text = dialog.Message;

            canvas.SetActive(true);
        }

        //Hide dialog
        public void Hide()
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                canvas.SetActive(false);
            }
            
            //Reset Dialog
            dialog = new Dialog();
        }
    }
}

