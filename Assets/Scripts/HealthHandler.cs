using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HealthHandler : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;
    [SerializeField]
    private int PointsLeft;
    private int PointsNeeded = 50;

    public Text TotalCounter;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TotalCounter.text = PointsNeeded.ToString();
        if (PointsNeeded == 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void SetPoint(int pointvariable)
    {
        PointsNeeded -= pointvariable;
    }
}
