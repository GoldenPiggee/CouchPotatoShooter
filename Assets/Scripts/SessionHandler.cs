using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionHandler : MonoBehaviour
{
    [SerializeField] private GameObject gameOverUI;

    public static bool gameStarted = false;
    public static bool gameOver = false;
    void Start()
    {
        gameOverUI.SetActive(false);
        if (!gameStarted)
        {
            ProcessCommon();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStarted && gameOver)
        {
            //ProcessEnd();
            gameOver = false;
        }
    }

    public void ProcessCommon()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        //DetectCollisions.stopCam = true;
    }

    //private void ProcessEnd()
    //{
        //if(PlayerController.GetHealth() == 0)
        //{
          //  gameOverUI.SetActive(true);
            //ProcessCommon();
        //}
        
        //else if (LaserController.GetShot() == 1)
        //{
          //  gameObject.SetActive(true);
            //ProcessCommon();
        //}
    //}
}
