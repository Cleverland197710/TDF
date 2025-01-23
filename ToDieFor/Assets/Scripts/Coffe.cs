using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffe : MonoBehaviour
{
    [SerializeField] LayerMask coffe;
    [SerializeField] LayerMask coffeLayer;
    public bool serving;
    public static bool cupBah;

    private void Awake()
    {
        serving = false;
        cupBah = false;
    }

    private void OnMouseUpAsButton()
    {
       
        if (Movement.hasCup == true)
        {
            serving = true;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Missed", 10f);
        Invoke("Destroy", 11f);

        if (serving == true)
        {
            Destroy(gameObject);
        }

    }


    void Missed()
    {
        Debug.Log("1Missed");
        cupBah = true;
        Invoke("Delete", 0.5f);

    }

    void Delete()
    {
        cupBah = false;
        Destroy(gameObject);
    }

}
