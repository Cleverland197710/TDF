using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffe : MonoBehaviour
{
    [SerializeField] LayerMask coffe;
    [SerializeField] LayerMask coffeLayer;
    public bool serving = false;
    public bool fail = false;

    private void OnMouseUpAsButton()
    {
        serving = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (serving == true)
        {
            Destroy(gameObject);
        }

        if (fail == true)
        {

        }

    }

}
