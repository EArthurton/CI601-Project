using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Memory401 : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject blanket;
    public int randomIndex;
    public float timer1, timer2;
    public Image canvasImage;
    public UnityEvent invokeFunction;

    void Start()
    {

        objects[0].transform.position = new Vector3(Random.Range(490, 588), 868, 0);
        objects[1].transform.position = new Vector3(Random.Range(826, 924), 800, 0);
        objects[2].transform.position = new Vector3(Random.Range(1162, 1260), 732, 0);
        objects[3].transform.position = new Vector3(Random.Range(658, 756), 664, 0);
        objects[4].transform.position = new Vector3(Random.Range(994, 1092), 596, 0);
        objects[5].transform.position = new Vector3(Random.Range(1330, 1428), 528, 0);
        objects[6].transform.position = new Vector3(Random.Range(490, 588), 460, 0);
        objects[7].transform.position = new Vector3(Random.Range(826, 924), 392, 0);
        objects[8].transform.position = new Vector3(Random.Range(1162, 1260), 324, 0);
        objects[9].transform.position = new Vector3(Random.Range(658, 756), 256, 0);
        objects[10].transform.position = new Vector3(Random.Range(994, 1092), 188, 0);
        objects[11].transform.position = new Vector3(Random.Range(1330, 1428), 120, 0);
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
            SceneManager.LoadScene("Memory4-2");
        }
    }
}
