using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffe : MonoBehaviour
{
    [SerializeField] LayerMask coffe;
    [SerializeField] LayerMask coffeLayer;
    public bool serving;

    private void Awake()
    {
        serving = false;
    }

    private void OnMouseUpAsButton()
    {
       
        if (Dish.isCup == true)
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

        if (serving == true)
        {
            Destroy(gameObject);
        }

    }

    void Missed()
    {
        Debug.Log("1Missed");
    }

}
