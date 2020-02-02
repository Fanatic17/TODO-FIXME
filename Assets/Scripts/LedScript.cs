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
 
        if (true)//controller.puzzleActive)
        {
            if (colore)
            {
                GetComponent<SpriteRenderer>().color = Color.green;
            }
            else
            {
                GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.grey;
        }

    }

    public void toggle()
    {
        Debug.log("prova");
        if (true)//controller.puzzleActive)
        {
            colore = !colore;
            
        }
    }
}
