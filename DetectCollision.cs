using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectCollision : MonoBehaviour
{
    public static int playerScore = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Player") && !gameObject.CompareTag("Bone"))
        {
            Destroy(gameObject);
        }

        if (!other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            playerScore++;
        }

    }

}
