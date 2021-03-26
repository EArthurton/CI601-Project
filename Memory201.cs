using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Memory201 : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject blanket;
    public int randomIndex;
    public float timer1, timer2;
    public Image canvasImage;
    public UnityEvent invokeFunction;

    void Start()
    {
        objects[0].transform.position = new Vector3(Random.Range(500, 870), Random.Range(120, 145), 0);
        objects[1].transform.position = new Vector3(Random.Range(930, 1400), Random.Range(215, 240), 0);
        objects[2].transform.position = new Vector3(Random.Range(500, 870), Random.Range(310, 335), 0);
        objects[3].transform.position = new Vector3(Random.Range(930, 1400), Random.Range(405, 430), 0);
        objects[4].transform.position = new Vector3(Random.Range(500, 870), Random.Range(500, 525), 0);
        objects[5].transform.position = new Vector3(Random.Range(930, 1400), Random.Range(595, 620), 0);
        objects[6].transform.position = new Vector3(Random.Range(500, 870), Random.Range(690, 715), 0);
        objects[7].transform.position = new Vector3(Random.Range(930, 1400), Random.Range(785, 810), 0);
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
            SceneManager.LoadScene("Memory2-2");
        }
    }
}
