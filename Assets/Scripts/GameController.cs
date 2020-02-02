using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public BatterySlot batterySlot1;
    public BatterySlot batterySlot2;
    public ActualBattery battery1;
    public ActualBattery battery2;
    public bool puzzleActive;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetBattery()
    {
        if (batterySlot1.status && batterySlot2.status && battery1.charge > 0 && battery2.charge > 0)
        {
            puzzleActive = true;
        } else
        {
            puzzleActive = false;
        }
    }

    public void Charge()
    {
        if (battery1.charging && battery1.charge < 100)
        {
            battery1.charge += 5;
        }
        else
        {
            if (battery2.charging && battery2.charge < 100)
            {
                battery2.charge += 5;
            }
        }
    }

}
