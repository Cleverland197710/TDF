using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FnafTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ShiftClock;
    float elapsedTime;
    public static bool levelComplete;

    // Start is called before the first frame update
    void Start()
    {
        levelComplete = false;
    }

    private void Awake()
    {
        levelComplete = false;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += 2 * Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        ShiftClock.text = string.Format("{0:00}:{1:00}PM",minutes ,seconds);

        if (elapsedTime == 360)
        {
            elapsedTime = 360;
            levelComplete = true;
        }

    }
}
