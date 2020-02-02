using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedBehaviour : MonoBehaviour
{
    public LedScript l1;
    public LedScript l2;
    public LedScript l3;
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
        l1.toggle();
        l2.toggle();
        l3.toggle();
    }

}
