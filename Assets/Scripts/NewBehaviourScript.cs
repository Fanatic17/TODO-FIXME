using UnityEngine;
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
        //Debug.Log("OnPointerDown");
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
            Vector3 pos = startPos + diff /22;
            transform.position = pos;
        }
    }

}