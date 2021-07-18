using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    playersMovement playersMovement;
    // Start is called before the first frame update
    void Start()
    {
        playersMovement = GameObject.FindObjectOfType<playersMovement>(); 
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playersMovement.Die();
        }
        // Oyuncuyu öldür
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
