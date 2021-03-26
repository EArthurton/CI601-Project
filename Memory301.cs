using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Memory301 : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject blanket;
    public int randomIndex;
    public float timer1, timer2;
    public Image canvasImage;
    public UnityEvent invokeFunction;

    void Start()
    {
        objects[0].transform.position = new Vector3(Random.Range(490, 630), 863, 0);
        objects[1].transform.position = new Vector3(Random.Range(890, 1030), 781, 0);
        objects[2].transform.position = new Vector3(Random.Range(1290, 1430), 699, 0);
        objects[3].transform.position = new Vector3(Random.Range(690, 830), 617, 0);
        objects[4].transform.position = new Vector3(Random.Range(1090, 1230), 535, 0);
        objects[5].transform.position = new Vector3(Random.Range(490, 630), 453, 0);
        objects[6].transform.position = new Vector3(Random.Range(890, 1030), 371, 0);
        objects[7].transform.position = new Vector3(Random.Range(1290, 1430), 289, 0);
        objects[8].transform.position = new Vector3(Random.Range(690, 830), 207, 0);
        objects[9].transform.position = new Vector3(Random.Range(1090, 1230), 125, 0);
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
            SceneManager.LoadScene("Memory3-2");
        }
    }
}
