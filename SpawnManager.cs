using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public Button restartButton;
    public static bool gameOver = false;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", 2.0f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + DetectCollision.playerScore;
    }

    void SpawnAnimals()
    {
        if (gameOver == false)
        {
            Vector3 spawnRange = new Vector3(Random.Range(-12, 12), 0, 20);
            Vector3 spawnRange2 = new Vector3(0, 0, 10);
            Quaternion spawnRotation = Quaternion.Euler(0f, 180f, 0f);
            Instantiate(animalPrefabs[Random.Range(0, animalPrefabs.Length)], spawnRange, spawnRotation);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
