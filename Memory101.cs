using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Memory101 : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject blanket;
    public int randomIndex;
    public float timer1, timer2;
    public Image canvasImage;
    public UnityEvent invokeFunction;
    private Vector2 newPosition;

    void Start()
    {
        objects[0].transform.position = new Vector3(Random.Range(600, 850), 855, 0);
        objects[1].transform.position = new Vector3(Random.Range(950, 1300), 710, 0);
        objects[2].transform.position = new Vector3(Random.Range(600, 850), 565, 0);
        objects[3].transform.position = new Vector3(Random.Range(950, 1300), 420, 0);
        objects[4].transform.position = new Vector3(Random.Range(600, 850), 275, 0);
        objects[5].transform.position = new Vector3(Random.Range(950, 1300), 130, 0);
    }

    void Update()
    {
        timer1 -= Time.deltaTime;

        if (timer1 <= 0)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(false);
            }

            blanket.SetActive(false);
            canvasImage.color = new Color(0, 0, 0);
        }

        timer2 -= Time.deltaTime;

        if(timer2 <= 0)
        {
            SceneManager.LoadScene("Memory1-2");
        }
    }
}
