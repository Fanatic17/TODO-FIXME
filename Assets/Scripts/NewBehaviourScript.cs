﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{

    private bool mouseDown = false;
    private Vector3 startMousePos;
    private Vector3 startPos;

    public void OnMouseDown()
    {
        mouseDown = true;
        startPos = transform.position;
        startMousePos = Input.mousePosition;
    }

    public void OnMouseUp()
    {
        mouseDown = false;
    }


    void Update()
    {
        if (mouseDown)
        {
            Vector3 currentPos = Input.mousePosition;
            Vector3 diff = currentPos - startMousePos;
            Vector3 pos = startPos + diff /100;
            transform.position = pos;
        }
    }

}