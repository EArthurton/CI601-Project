using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Memory302 : MonoBehaviour
{
    private GameObject[] objects, buttons;
    private GameObject sidebar, shapes, blanket, time, score, question, gameOver;
    private Image[] oImages, bImages;
    private List<Sprite> loadedImages;
    private Sprite circle, crescent, heart, hexagon, octagon, pentagon, square, star, trapezium, triangle;
    private float countDownTimer, nextSceneTimer;
    public Text timeText, gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer = 40;
        nextSceneTimer = 5;

        loadedImages = new List<Sprite>();

        time = GameObject.Find("Time");
        score = GameObject.Find("Score");
        question = GameObject.Find("Question");
        gameOver = GameObject.Find("Game Over");
        sidebar = GameObject.Find("Sidebar");
        shapes = GameObject.Find("Objects");
        blanket = GameObject.Find("Picnic Blanket");

        timeText = time.GetComponent<Text>();
        gameOverText = gameOver.GetComponent<Text>();

        objects = new GameObject[9];
        objects[0] = GameObject.Find("Object_00");
        objects[1] = GameObject.Find("Object_01");
        objects[2] = GameObject.Find("Object_02");
        objects[3] = GameObject.Find("Object_03");
        objects[4] = GameObject.Find("Object_04");
        objects[5] = GameObject.Find("Object_05");
        objects[6] = GameObject.Find("Object_06");
        objects[7] = GameObject.Find("Object_07");
        objects[8] = GameObject.Find("Object_08");

        oImages = new Image[9];
        oImages[0] = objects[0].GetComponent<Image>();
        oImages[1] = objects[1].GetComponent<Image>();
        oImages[2] = objects[2].GetComponent<Image>();
        oImages[3] = objects[3].GetComponent<Image>();
        oImages[4] = objects[4].GetComponent<Image>();
        oImages[5] = objects[5].GetComponent<Image>();
        oImages[6] = objects[6].GetComponent<Image>();
        oImages[7] = objects[7].GetComponent<Image>();
        oImages[8] = objects[8].GetComponent<Image>();

        buttons = new GameObject[10];
        buttons[0] = GameObject.Find("Image_00");
        buttons[1] = GameObject.Find("Image_01");
        buttons[2] = GameObject.Find("Image_02");
        buttons[3] = GameObject.Find("Image_03");
        buttons[4] = GameObject.Find("Image_04");
        buttons[5] = GameObject.Find("Image_05");
        buttons[6] = GameObject.Find("Image_06");
        buttons[7] = GameObject.Find("Image_07");
        buttons[8] = GameObject.Find("Image_08");
        buttons[9] = GameObject.Find("Image_09");

        bImages = new Image[10];
        bImages[0] = buttons[0].GetComponent<Image>();
        bImages[1] = buttons[1].GetComponent<Image>();
        bImages[2] = buttons[2].GetComponent<Image>();
        bImages[3] = buttons[3].GetComponent<Image>();
        bImages[4] = buttons[4].GetComponent<Image>();
        bImages[5] = buttons[5].GetComponent<Image>();
        bImages[6] = buttons[6].GetComponent<Image>();
        bImages[7] = buttons[7].GetComponent<Image>();
        bImages[8] = buttons[8].GetComponent<Image>();
        bImages[9] = buttons[9].GetComponent<Image>();

        circle = Resources.Load<Sprite>("Sprites/Circle");
        crescent = Resources.Load<Sprite>("Sprites/Crescent");
        heart = Resources.Load<Sprite>("Sprites/Heart");
        hexagon = Resources.Load<Sprite>("Sprites/Hexagon");
        octagon = Resources.Load<Sprite>("Sprites/Octagon");
        pentagon = Resources.Load<Sprite>("Sprites/Pentagon");
        square = Resources.Load<Sprite>("Sprites/Square");
        star = Resources.Load<Sprite>("Sprites/Star");
        trapezium = Resources.Load<Sprite>("Sprites/Trapezium");
        triangle = Resources.Load<Sprite>("Sprites/Triangle");

        loadedImages.Add(circle);
        loadedImages.Add(crescent);
        loadedImages.Add(heart);
        loadedImages.Add(hexagon);
        loadedImages.Add(octagon);
        loadedImages.Add(pentagon);
        loadedImages.Add(square);
        loadedImages.Add(star);
        loadedImages.Add(trapezium);
        loadedImages.Add(triangle);

        oImages[0].sprite = loadedImages[Random.Range(0, loadedImages.Count)];
        loadedImages.Remove(oImages[0].sprite);
        oImages[1].sprite = loadedImages[Random.Range(0, loadedImages.Count)];
        loadedImages.Remove(oImages[1].sprite);
        oImages[2].sprite = loadedImages[Random.Range(0, loadedImages.Count)];
        loadedImages.Remove(oImages[2].sprite);
        oImages[3].sprite = loadedImages[Random.Range(0, loadedImages.Count)];
        loadedImages.Remove(oImages[3].sprite);
        oImages[4].sprite = loadedImages[Random.Range(0, loadedImages.Count)];
        loadedImages.Remove(oImages[4].sprite);
        oImages[5].sprite = loadedImages[Random.Range(0, loadedImages.Count)];
        loadedImages.Remove(oImages[5].sprite);
        oImages[6].sprite = loadedImages[Random.Range(0, loadedImages.Count)];
        loadedImages.Remove(oImages[6].sprite);
        oImages[7].sprite = loadedImages[Random.Range(0, loadedImages.Count)];
        loadedImages.Remove(oImages[7].sprite);
        oImages[8].sprite = loadedImages[Random.Range(0, loadedImages.Count)];
        loadedImages.Remove(oImages[8].sprite);

        objects[0].transform.position = new Vector3(Random.Range(275, 425), 125, 0);
        objects[1].transform.position = new Vector3(Random.Range(725, 875), 215, 0);
        objects[2].transform.position = new Vector3(Random.Range(500, 650), 305, 0);
        objects[3].transform.position = new Vector3(Random.Range(950, 1100), 395, 0);
        objects[4].transform.position = new Vector3(Random.Range(275, 425), 485, 0);
        objects[5].transform.position = new Vector3(Random.Range(725, 875), 575, 0);
        objects[6].transform.position = new Vector3(Random.Range(500, 650), 665, 0);
        objects[7].transform.position = new Vector3(Random.Range(950, 1100), 755, 0);
        objects[8].transform.position = new Vector3(Random.Range(275, 425), 845, 0);
    }

    public void Button00()
    {
        if (bImages[0].sprite.name != oImages[0].sprite.name && bImages[0].sprite.name != oImages[1].sprite.name && bImages[0].sprite.name != oImages[2].sprite.name && bImages[0].sprite.name != oImages[3].sprite.name && bImages[0].sprite.name != oImages[4].sprite.name && bImages[0].sprite.name != oImages[5].sprite.name && bImages[0].sprite.name != oImages[6].sprite.name && bImages[0].sprite.name != oImages[7].sprite.name && bImages[0].sprite.name != oImages[8].sprite.name)
        {
            Destroy(buttons[0]);
            Score.score += 5;
        }
        else
        {
            Score.score -= 5;
        }
    }

    public void Button01()
    {
        if (bImages[1].sprite.name != oImages[0].sprite.name && bImages[1].sprite.name != oImages[1].sprite.name && bImages[1].sprite.name != oImages[2].sprite.name && bImages[1].sprite.name != oImages[3].sprite.name && bImages[1].sprite.name != oImages[4].sprite.name && bImages[1].sprite.name != oImages[5].sprite.name && bImages[1].sprite.name != oImages[6].sprite.name && bImages[1].sprite.name != oImages[7].sprite.name && bImages[1].sprite.name != oImages[8].sprite.name)
        {
            Destroy(buttons[1]);
            Score.score += 5;
        }
        else
        {
            Score.score -= 5;
        }
    }

    public void Button02()
    {
        if (bImages[2].sprite.name != oImages[0].sprite.name && bImages[2].sprite.name != oImages[1].sprite.name && bImages[2].sprite.name != oImages[2].sprite.name && bImages[2].sprite.name != oImages[3].sprite.name && bImages[2].sprite.name != oImages[4].sprite.name && bImages[2].sprite.name != oImages[5].sprite.name && bImages[2].sprite.name != oImages[6].sprite.name && bImages[2].sprite.name != oImages[7].sprite.name && bImages[2].sprite.name != oImages[8].sprite.name)
        {
            Destroy(buttons[2]);
            Score.score += 5;
        }
        else
        {
            Score.score -= 5;
        }
    }

    public void Button03()
    {
        if (bImages[3].sprite.name != oImages[0].sprite.name && bImages[3].sprite.name != oImages[1].sprite.name && bImages[3].sprite.name != oImages[2].sprite.name && bImages[3].sprite.name != oImages[3].sprite.name && bImages[3].sprite.name != oImages[4].sprite.name && bImages[3].sprite.name != oImages[5].sprite.name && bImages[3].sprite.name != oImages[6].sprite.name && bImages[3].sprite.name != oImages[7].sprite.name && bImages[3].sprite.name != oImages[8].sprite.name)
        {
            Destroy(buttons[3]);
            Score.score += 5;
        }
        else
        {
            Score.score -= 5;
        }
    }

    public void Button04()
    {
        if (bImages[4].sprite.name != oImages[0].sprite.name && bImages[4].sprite.name != oImages[1].sprite.name && bImages[4].sprite.name != oImages[2].sprite.name && bImages[4].sprite.name != oImages[3].sprite.name && bImages[4].sprite.name != oImages[4].sprite.name && bImages[4].sprite.name != oImages[5].sprite.name && bImages[4].sprite.name != oImages[6].sprite.name && bImages[4].sprite.name != oImages[7].sprite.name && bImages[4].sprite.name != oImages[8].sprite.name)
        {
            Destroy(buttons[4]);
            Score.score += 5;
        }
        else
        {
            Score.score -= 5;
        }
    }

    public void Button05()
    {
        if (bImages[5].sprite.name != oImages[0].sprite.name && bImages[5].sprite.name != oImages[1].sprite.name && bImages[5].sprite.name != oImages[2].sprite.name && bImages[5].sprite.name != oImages[3].sprite.name && bImages[5].sprite.name != oImages[4].sprite.name && bImages[5].sprite.name != oImages[5].sprite.name && bImages[5].sprite.name != oImages[6].sprite.name && bImages[5].sprite.name != oImages[7].sprite.name && bImages[5].sprite.name != oImages[8].sprite.name)
        {
            Destroy(buttons[5]);
            Score.score += 5;
        }
        else
        {
            Score.score -= 5;
        }
    }

    public void Button06()
    {
        if (bImages[6].sprite.name != oImages[0].sprite.name && bImages[6].sprite.name != oImages[1].sprite.name && bImages[6].sprite.name != oImages[2].sprite.name && bImages[6].sprite.name != oImages[3].sprite.name && bImages[6].sprite.name != oImages[4].sprite.name && bImages[6].sprite.name != oImages[5].sprite.name && bImages[6].sprite.name != oImages[6].sprite.name && bImages[6].sprite.name != oImages[7].sprite.name && bImages[6].sprite.name != oImages[8].sprite.name)
        {
            Destroy(buttons[6]);
            Score.score += 5;
        }
        else
        {
            Score.score -= 5;
        }
    }

    public void Button07()
    {
        if (bImages[7].sprite.name != oImages[0].sprite.name && bImages[7].sprite.name != oImages[1].sprite.name && bImages[7].sprite.name != oImages[2].sprite.name && bImages[7].sprite.name != oImages[3].sprite.name && bImages[7].sprite.name != oImages[4].sprite.name && bImages[7].sprite.name != oImages[5].sprite.name && bImages[7].sprite.name != oImages[6].sprite.name && bImages[7].sprite.name != oImages[7].sprite.name && bImages[7].sprite.name != oImages[8].sprite.name)
        {
            Destroy(buttons[7]);
            Score.score += 5;
        }
        else
        {
            Score.score -= 5;
        }
    }

    public void Button08()
    {
        if (bImages[8].sprite.name != oImages[0].sprite.name && bImages[8].sprite.name != oImages[1].sprite.name && bImages[8].sprite.name != oImages[2].sprite.name && bImages[8].sprite.name != oImages[3].sprite.name && bImages[8].sprite.name != oImages[4].sprite.name && bImages[8].sprite.name != oImages[5].sprite.name && bImages[8].sprite.name != oImages[6].sprite.name && bImages[8].sprite.name != oImages[7].sprite.name && bImages[8].sprite.name != oImages[8].sprite.name)
        {
            Destroy(buttons[8]);
            Score.score += 5;
        }
        else
        {
            Score.score -= 5;
        }
    }

    public void Button09()
    {
        if (bImages[9].sprite.name != oImages[0].sprite.name && bImages[9].sprite.name != oImages[1].sprite.name && bImages[9].sprite.name != oImages[2].sprite.name && bImages[9].sprite.name != oImages[3].sprite.name && bImages[9].sprite.name != oImages[4].sprite.name && bImages[9].sprite.name != oImages[5].sprite.name && bImages[9].sprite.name != oImages[6].sprite.name && bImages[9].sprite.name != oImages[7].sprite.name && bImages[9].sprite.name != oImages[8].sprite.name)
        {
            Destroy(buttons[9]);
            Score.score += 5;
        }
        else
        {
            Score.score -= 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        countDownTimer -= Time.deltaTime;

        if(countDownTimer <= 0)
        {
            Destroy(shapes);
            Destroy(sidebar);
            Destroy(blanket);
            Destroy(time);
            Destroy(question);
            Destroy(score);

            gameOverText.text = string.Format("Game Over!");

            nextSceneTimer -= Time.deltaTime;
            if (nextSceneTimer <= 0)
            {
                SceneManager.LoadScene("MInstructions-v1");
            }
        }
        else
        {
            if (buttons[0] == null || buttons[1] == null || buttons[2] == null || buttons[3] == null || buttons[4] == null || buttons[5] == null || buttons[6] == null || buttons[7] == null || buttons[8] == null || buttons[9] == null)
            {
                nextSceneTimer -= Time.deltaTime;
                if (nextSceneTimer <= 0)
                {
                    SceneManager.LoadScene("Memory4-1");
                }
            }
        }
    }
}
