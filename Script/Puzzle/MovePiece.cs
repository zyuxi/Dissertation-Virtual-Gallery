using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
        transform.position = objPosition;
    }
}
