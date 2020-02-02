using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    public BatterySlot batterySlot1;
    public BatterySlot batterySlot2;
    public ActualBattery battery1;
    public ActualBattery battery2;
    public bool puzzleActive;
    public LedScript led1;
    public LedScript led2;
    public LedScript led3;
    public LedScript led4;
    public LedScript led5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(led1.colore && led2.colore && led3.colore && led4.colore && led5.colore)
        {
            GetComponent<AudioSource>().Play();
            Invoke("ChangeScene", 5);
        }

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

    public void ChangeScene()
    {
        //SceneManager.LoadScene("Credits");

    }

}
