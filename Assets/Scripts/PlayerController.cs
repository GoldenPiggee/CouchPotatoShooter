using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int health = 3;
    public float speed = 1.0f;
    public GameObject laserPrefab;
    public GameObject enemyPrefab;

    void Start()
    {
        transform.position = Vector3.zero;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        transform.Translate(verticalInput * speed * Time.deltaTime * Vector3.up);

        if (transform.position.y > 6)
        {
            transform.position = new Vector3(transform.position.x, 6, 0f);
        }
        else if (transform.position.y < -7)
        {
            transform.position = new Vector3(transform.position.x, -7, 0f);
        }

        if (transform.position.x > 15)
        {
            transform.position = new Vector3(15, transform.position.y, 0f);
        }
        if (transform.position.x < -15)
        {
            transform.position = new Vector3(-15, transform.position.y, 0f);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserPrefab, transform.position, Quaternion.identity);
        }
        //if (Input.GetButtonDown("Fire2"))
        //{
        //    Instantiate(enemyPrefab, new Vector3(0, 6, 0f), Quaternion.identity);
        //}
    }
}