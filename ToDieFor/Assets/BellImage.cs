using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class BellImage : MonoBehaviour
{
    Image Vis;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        Vis = GetComponent<Image>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Bell.inBell == true)
        {
            //Vis.gameObject.SetActive(true);
            anim.SetTrigger("FadeBack");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            //Vis.gameObject.SetActive(false);
            anim.SetTrigger("Fade");
        }
    }
}
