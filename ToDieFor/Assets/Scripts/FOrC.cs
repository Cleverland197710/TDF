using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FOrC : MonoBehaviour
{
    public int maxNumberOfMissedCustomers = 5;
    public int numberOfMissedCustomers = 0;
    public static bool levelFailed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(numberOfMissedCustomers);
        if (numberOfMissedCustomers >= maxNumberOfMissedCustomers)
        {
            numberOfMissedCustomers = 0;
            levelFailed = true;
        }

        if (Coffe.cupBah == true)
        {
            numberOfMissedCustomers++;
            Coffe.cupBah = false;
        }

        if (Pancake.panBah == true)
        {
            numberOfMissedCustomers++;
            Pancake.panBah = false;
        }

        if (levelFailed == true)
        {
            ReloadLevel();
            LoadFired();
        }
    }

    void LoadFired()
    {

    }

    void ReloadLevel()
    {
        levelFailed = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
