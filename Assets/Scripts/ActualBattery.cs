using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualBattery : MonoBehaviour
{
    public int charge;
    public bool discharging;
    public bool charging;
    public GameController controller;
    public Sprite battFull;
    public Sprite battYellow;
    public Sprite battOrange;
    public Sprite battRed;
    // Start is called before the first frame update
    void Start()
    {
        charge = 10;
        InvokeRepeating("DecrementCharge", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(charge < 15)
        this.GetComponent<SpriteRenderer>().sprite = battRed;
        return;

        if (charge < 30)
            this.GetComponent<SpriteRenderer>().sprite = battOrange;
        return;

        if (charge < 60)
            this.GetComponent<SpriteRenderer>().sprite = battYellow;
        return;
 
        this.GetComponent<SpriteRenderer>().sprite = battFull;
        return;

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
