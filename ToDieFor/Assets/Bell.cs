using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
    public static bool inBell;
    public bool spawnCup;
    public bool spawnPan;
    public bool spawnEgg;

    private void Awake()
    {
        inBell = false;
        spawnCup = false;
        spawnPan = false;
        spawnEgg = false;
    }

    private void OnMouseUp()
    {
        inBell=true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inBell == true)
        {
            if(Input.GetKeyUp(KeyCode.Alpha1))
            {
                Cup(); 
            }

            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                Pan();
            }

            if (Input.GetKeyUp(KeyCode.Alpha3))
            {
                Egg();
            }
        }
    }

    void Cup()
    {
        spawnCup = true;
        inBell = false;
        Invoke("Off", 0.05f);
    }

    void Pan()
    {
        spawnPan = true;
        inBell = false;
        Invoke("Off", 0.05f);
    }

    void Egg()
    {
        spawnEgg = true;
        inBell = false;
        Invoke("Off", 0.05f);
    }

    void Off()
    {
        spawnCup = false;
        spawnPan = false;
        spawnEgg = false;
    }
}
