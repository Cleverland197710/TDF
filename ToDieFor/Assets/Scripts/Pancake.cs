using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pancake : MonoBehaviour
{

    Animator anim;

    [SerializeField] LayerMask coffe;
    [SerializeField] LayerMask coffeLayer;
    public bool serving;
    public static bool panBah;

    private void Awake()
    {
        serving = false;
        panBah = false;
    }

    private void OnMouseUpAsButton()
    {

        if (Movement.hasPan == true)
        {
            serving = true;
            Movement.hasPan = false;
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
            //Movement.hasEgg = false;
            Destroy(gameObject);
        }

    }


    void Missed()
    {
        anim.SetTrigger("Missed");
        Debug.Log("1Missed");
        panBah = true;
        Invoke("Delete", 2.5f);

    }

    void Flashing()
    {
        anim.SetTrigger("Flash");
    }

    void Delete()
    {
        panBah = false;
        Destroy(gameObject);
    }

}
