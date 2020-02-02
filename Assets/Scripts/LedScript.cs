using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedScript : MonoBehaviour
{
    public GameController controller;
    public bool colore = false;
    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void toggle()
    {
        if (true)//controller.puzzleActive)
        {
            if (colore==false)
            {
                colore = true;
                
            } else { 
            colore=false;
            }
        }
    }
}
