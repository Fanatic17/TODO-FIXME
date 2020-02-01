using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatterySlot : MonoBehaviour
{

    public GameController controller;
    public bool status;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        status = true;
        controller.SetBattery();
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        status = false;
        controller.SetBattery();
    }

}
