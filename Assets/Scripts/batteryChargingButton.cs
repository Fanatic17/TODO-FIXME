using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteryChargingButton : MonoBehaviour
{
    public GameController controller;
    public Sprite spriteUp;
    public Sprite spriteDown;

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
        this.GetComponent<SpriteRenderer>().sprite = spriteDown;
        GetComponent<AudioSource>().Play();
    }

    void OnMouseUp()
    {
        this.GetComponent<SpriteRenderer>().sprite = spriteUp;
    }
}
