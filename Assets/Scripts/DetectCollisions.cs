using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollisions : MonoBehaviour
{
    public int score = 0;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameObject.Find("HitPoints").GetComponent<HealthHandler>().SetPoint(1);
        }
        else if (other.gameObject.tag == "DVD")
        {
            SceneManager.LoadScene(3);
        }
    }

}
