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
        if (Movement.hasPlate == true && !Movement.hasCup == true && !Movement.hasPan == true && !ProjectileGunTutorial.blasting == true)
        {
            anim.SetTrigger("No Plate");
            anim.SetBool("Back to Plate", false);
        }

        if (Movement.hasCup == true)
        {
            anim.SetTrigger("Cup");
        }

        if (Movement.hasPan == true)
        {
            anim.SetTrigger("Pan");
        }

        if (ProjectileGunTutorial.blasting == true)
        {
            anim.SetTrigger("Throw");
            anim.SetBool("Back to Plate", true);
        }
    }
}
