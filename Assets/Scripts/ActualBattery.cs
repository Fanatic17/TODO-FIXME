using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualBattery : MonoBehaviour
{
    public int charge;
    public bool discharging;
    public bool charging;
    public GameController controller;
    // Start is called before the first frame update
    void Start()
    {
        charge = 10;
        InvokeRepeating("DecrementCharge", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(charge + this.ToString());
    }

    private void DecrementCharge()
    {
        if (charge > 0)
        {
            charge--;
            return;
        }
        discharging = false;
        controller.SetBattery();
        return;
    }

}
