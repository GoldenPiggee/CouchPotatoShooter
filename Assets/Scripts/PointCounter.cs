using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    public int score;
    public GameObject enemy;
    void OnDestroy()
    {
        score++;
    }
}
