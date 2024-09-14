using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;
    public float direction = 180.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.up, direction * Time.deltaTime);
        if (transform.position.z < -10 || transform.position.z > 40)
        {
            Destroy(gameObject);
        }
    }

}
