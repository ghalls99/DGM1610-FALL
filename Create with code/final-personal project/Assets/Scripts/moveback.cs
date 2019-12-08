using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveback : MonoBehaviour
{
    private float speed = 60;
    private playercontroller playerControllerScript;
    private float forwardBounds = -10000;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<playercontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);  
        }
        if(transform.position.z < forwardBounds && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}