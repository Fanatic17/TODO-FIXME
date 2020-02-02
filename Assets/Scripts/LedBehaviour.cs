using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedBehaviour : MonoBehaviour
{
    public LedScript l1;
    public LedScript l2;
    public LedScript l3;
    public bool switchButton=true;
    public Sprite spriteOn;
    public Sprite spriteOff;
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
        toggleSwitch();
        l1.toggle();
        l2.toggle();
        l3.toggle();
    }

    public void toggleSwitch()
    {
        if (switchButton == true)
        {
            switchButton = false;
            this.GetComponent<SpriteRenderer>().sprite = spriteOn;
        } else
        {
            switchButton = true;
            this.GetComponent<SpriteRenderer>().sprite = spriteOff;
        }
    }

}
