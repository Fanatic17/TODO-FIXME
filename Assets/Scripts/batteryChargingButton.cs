using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryChargingButton : MonoBehaviour
{
    public GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        controller.Charge();
    }


}
