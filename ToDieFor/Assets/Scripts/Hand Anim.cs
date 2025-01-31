using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandAnim : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Movement.hasPlate);

        if (Movement.hasCup == false)
        {
            anim.SetBool("Cup", false);
        }

        if (Movement.hasPlate == false)
        {
            anim.SetBool("No Plate", true);
        }

        if (Movement.hasCup == true)
        {
            anim.SetBool("Cup", true);
            anim.SetBool("No Plate", false);
        }

        if (Movement.hasPan == true)
        {
            anim.SetTrigger("Pan");
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            anim.SetTrigger("Throw");
            anim.SetBool("Cup", false);
            anim.SetBool("No Plate", true);
        }

        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            anim.SetTrigger("Punch");
            anim.SetBool("Cup", false);
            anim.SetBool("No Plate", true);
        }
    }
}
