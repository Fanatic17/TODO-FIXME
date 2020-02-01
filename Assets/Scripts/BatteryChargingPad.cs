using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryChargingPad : MonoBehaviour
{
    public ActualBattery battery1;
    public ActualBattery battery2;

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
        if (other.name == "Battery1")
        {
            battery1.charging = true;
            //battery1.SetCharging();
        }
        if (other.name == "Battery2")
        {
            battery2.charging = true;
            //battery2.SetCharging();
        }

    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Battery1")
        {
            battery1.charging = false;
            //battery1.SetCharging();
        }
        if (other.name == "Battery2")
        {
            battery2.charging = false;
            //battery1.SetCharging();
        }

    }
}
