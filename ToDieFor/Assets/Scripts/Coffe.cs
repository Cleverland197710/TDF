using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffe : MonoBehaviour
{

    Animator anim;

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
        anim = GetComponent<Animator>();
        anim.SetTrigger("Order");
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Missed", 10f);
        Invoke("Flashing", 6f);
        Invoke("Destroy", 11f);

        if (serving == true)
        {
            Movement.hasCup = false;
            Movement.hasPan = false;
            Destroy(gameObject);
        }

    }


    void Missed()
    {
        anim.SetTrigger("Missed");
        Debug.Log("1Missed");
        cupBah = true;
        Invoke("Delete", 2.5f);

    }

    void Flashing()
    {
        anim.SetTrigger("Flash");
    }

    void Delete()
    {
        cupBah = false;
        Destroy(gameObject);
    }

}
