using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float range = 10.0f;
    public float speed = 1.0f;
    public GameObject bone;
    public GameObject player;
    public Canvas myCanvas;

    // Start is called before the first frame update
    void Start()
    {
        myCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -range)
        {
            transform.position = new Vector3(-range, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > range)
        {
            transform.position = new Vector3(range, transform.position.y, transform.position.z);
        }
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bone, player.transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Bone"))
        {
            myCanvas.gameObject.SetActive(true);
            SpawnManager.gameOver = true;
        }

    }
}
