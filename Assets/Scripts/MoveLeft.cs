using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float leftBound = -15;
    private float speed = 30;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
       playerControllerScript = GameObject.Find("White Farmer").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    { 
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

         if (transform.position.x < leftBound && gameObject.CompareTag("OB"))
         {
            Destroy(gameObject);
         }
           
           
    }
}
