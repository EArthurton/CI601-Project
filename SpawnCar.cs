using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SpawnCar : MonoBehaviour
{
    private GameObject corner, btn1, btn2, btn3, btn4;
    public GameObject[] firstCars, secondCars, thirdCars, fourthCars;
    private BoxCollider2D cornerCollider, btn1Collider, btn2Collider, btn3Collider, btn4Collider, blueCollider, greenCollider, orangeCollider, pinkCollider, purpleCollider;
    public BoxCollider2D[] firstCarsColl, secondCarsColl, thirdCarsColl, fourthCarsColl;

    // Start is called before the first frame update
    void Start()
    {
        corner = GameObject.Find("RoadTile (15)");
        btn1 = GameObject.Find("RoadTile (2)");
        btn2 = GameObject.Find("RoadTile (8)");
        btn3 = GameObject.Find("RoadTile (19)");
        btn4 = GameObject.Find("RoadTile (22)");

        cornerCollider = corner.GetComponent<BoxCollider2D>();
        btn1Collider = btn1.GetComponent<BoxCollider2D>();
        btn2Collider = btn2.GetComponent<BoxCollider2D>();
        btn3Collider = btn3.GetComponent<BoxCollider2D>();
        btn4Collider = btn4.GetComponent<BoxCollider2D>();

        blueCollider = GameObject.Find("Blue House").GetComponent<BoxCollider2D>();
        greenCollider = GameObject.Find("Green House").GetComponent<BoxCollider2D>();
        orangeCollider = GameObject.Find("Orange House").GetComponent<BoxCollider2D>();
        pinkCollider = GameObject.Find("Pink House").GetComponent<BoxCollider2D>();
        purpleCollider = GameObject.Find("Purple House").GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(spawn1());

        if(Timer.countUpTimer >= 35)
        {
            StartCoroutine(spawn2());

            if(Timer.countUpTimer >= 65)
            {
                StartCoroutine(spawn3());

                if(Timer.countUpTimer >= 90)
                {
                    StartCoroutine(spawn4());

                    if (firstCars[0] == null && firstCars[1] == null && firstCars[2] == null && firstCars[3] == null && firstCars[4] == null)
                    {
                        if (secondCars[0] == null && secondCars[1] == null && secondCars[2] == null && secondCars[3] == null && secondCars[4] == null)
                        {
                            if (thirdCars[0] == null && thirdCars[1] == null && thirdCars[2] == null && thirdCars[3] == null && thirdCars[4] == null)
                            {
                                if (fourthCars[0] == null && fourthCars[1] == null && fourthCars[2] == null && fourthCars[3] == null && fourthCars[4] == null)
                                {
                                    SceneManager.LoadScene("CComplete");
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    IEnumerator spawn1()
    {
        for (int i = 0; i <= 4; i++)
        {
            yield return new WaitForSeconds(7);
            if ((firstCars[i] != null) && (firstCarsColl[i] != null))
            {
                firstCars[i].transform.Translate(new Vector2(0, 60) * Time.deltaTime, Space.Self);

                if (firstCarsColl[i].bounds.Intersects(btn1Collider.bounds))
                {
                    if (btn1.GetComponent<Image>().sprite == Buttons.sprites[3])
                    {
                        firstCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                    else if (btn1.GetComponent<Image>().sprite == Buttons.sprites[4])
                    {
                        firstCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (firstCarsColl[i].bounds.Intersects(btn2Collider.bounds))
                {
                    if (btn2.GetComponent<Image>().sprite == Buttons.sprites[0])
                    {
                        firstCars[i].transform.rotation = Quaternion.Euler(0, 0, 180);
                    }
                    else if (btn2.GetComponent<Image>().sprite == Buttons.sprites[2])
                    {
                        firstCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (firstCarsColl[i].bounds.Intersects(btn3Collider.bounds))
                {
                    if (btn3.GetComponent<Image>().sprite == Buttons.sprites[1])
                    {
                        firstCars[i].transform.rotation = Quaternion.Euler(0, 0, 180);
                    }
                    else if (btn3.GetComponent<Image>().sprite == Buttons.sprites[2])
                    {
                        firstCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                }
                else if (firstCarsColl[i].bounds.Intersects(btn4Collider.bounds))
                {
                    if (btn4.GetComponent<Image>().sprite == Buttons.sprites[3])
                    {
                        firstCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                    else if (btn4.GetComponent<Image>().sprite == Buttons.sprites[4])
                    {
                        firstCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (firstCarsColl[i].bounds.Intersects(cornerCollider.bounds))
                {
                    firstCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                }

                if(firstCarsColl[i].bounds.Intersects(blueCollider.bounds))
                {
                    if(firstCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[0])
                    {
                        Destroy(firstCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(firstCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (firstCarsColl[i].bounds.Intersects(greenCollider.bounds))
                {
                    if (firstCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[1])
                    {
                        Destroy(firstCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(firstCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (firstCarsColl[i].bounds.Intersects(orangeCollider.bounds))
                {
                    if (firstCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[2])
                    {
                        Destroy(firstCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(firstCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (firstCarsColl[i].bounds.Intersects(pinkCollider.bounds))
                {
                    if (firstCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[3])
                    {
                        Destroy(firstCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(firstCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (firstCarsColl[i].bounds.Intersects(purpleCollider.bounds))
                {
                    if (firstCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[4])
                    {
                        Destroy(firstCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(firstCars[i]);
                        Score.score -= 1;
                    }
                }
            }
            else
            {
                Debug.Log("firstCars[" + i + "] is null");
            }
        }
    }

    IEnumerator spawn2()
    {
        for (int i = 0; i <= 4; i++)
        {
            yield return new WaitForSeconds(6);
            if ((secondCars[i] != null) && (secondCarsColl[i] != null))
            {
                secondCars[i].transform.Translate(new Vector2(0, 60) * Time.deltaTime, Space.Self);

                if (secondCarsColl[i].bounds.Intersects(btn1Collider.bounds))
                {
                    if (btn1.GetComponent<Image>().sprite == Buttons.sprites[3])
                    {
                        secondCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                    else if (btn1.GetComponent<Image>().sprite == Buttons.sprites[4])
                    {
                        secondCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (secondCarsColl[i].bounds.Intersects(btn2Collider.bounds))
                {
                    if (btn2.GetComponent<Image>().sprite == Buttons.sprites[0])
                    {
                        secondCars[i].transform.rotation = Quaternion.Euler(0, 0, 180);
                    }
                    else if (btn2.GetComponent<Image>().sprite == Buttons.sprites[2])
                    {
                        secondCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (secondCarsColl[i].bounds.Intersects(btn3Collider.bounds))
                {
                    if (btn3.GetComponent<Image>().sprite == Buttons.sprites[1])
                    {
                        secondCars[i].transform.rotation = Quaternion.Euler(0, 0, 180);
                    }
                    else if (btn3.GetComponent<Image>().sprite == Buttons.sprites[2])
                    {
                        secondCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                }
                else if (secondCarsColl[i].bounds.Intersects(btn4Collider.bounds))
                {
                    if (btn4.GetComponent<Image>().sprite == Buttons.sprites[3])
                    {
                        secondCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                    else if (btn4.GetComponent<Image>().sprite == Buttons.sprites[4])
                    {
                        secondCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (secondCarsColl[i].bounds.Intersects(cornerCollider.bounds))
                {
                    secondCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                }

                if (secondCarsColl[i].bounds.Intersects(blueCollider.bounds))
                {
                    if (secondCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[0])
                    {
                        Destroy(secondCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(secondCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (secondCarsColl[i].bounds.Intersects(greenCollider.bounds))
                {
                    if (secondCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[1])
                    {
                        Destroy(secondCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(secondCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (secondCarsColl[i].bounds.Intersects(orangeCollider.bounds))
                {
                    if (secondCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[2])
                    {
                        Destroy(secondCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(secondCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (secondCarsColl[i].bounds.Intersects(pinkCollider.bounds))
                {
                    if (secondCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[3])
                    {
                        Destroy(secondCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(secondCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (secondCarsColl[i].bounds.Intersects(purpleCollider.bounds))
                {
                    if (secondCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[4])
                    {
                        Destroy(secondCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(secondCars[i]);
                        Score.score -= 1;
                    }
                }
            }
            else
            {
                Debug.Log("secondCars[" + i +"] is null");
            }
        }
    }

    IEnumerator spawn3()
    {
        for(int i = 0; i <= 4; i++)
        {
            yield return new WaitForSeconds(5);
            if ((thirdCars[i] != null) && (thirdCarsColl[i] != null))
            {
                thirdCars[i].transform.Translate(new Vector2(0, 60) * Time.deltaTime, Space.Self);

                if (thirdCarsColl[i].bounds.Intersects(btn1Collider.bounds))
                {
                    if (btn1.GetComponent<Image>().sprite == Buttons.sprites[3])
                    {
                        thirdCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                    else if (btn1.GetComponent<Image>().sprite == Buttons.sprites[4])
                    {
                        thirdCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (thirdCarsColl[i].bounds.Intersects(btn2Collider.bounds))
                {
                    if (btn2.GetComponent<Image>().sprite == Buttons.sprites[0])
                    {
                        thirdCars[i].transform.rotation = Quaternion.Euler(0, 0, 180);
                    }
                    else if (btn2.GetComponent<Image>().sprite == Buttons.sprites[2])
                    {
                        thirdCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (thirdCarsColl[i].bounds.Intersects(btn3Collider.bounds))
                {
                    if (btn3.GetComponent<Image>().sprite == Buttons.sprites[1])
                    {
                        thirdCars[i].transform.rotation = Quaternion.Euler(0, 0, 180);
                    }
                    else if (btn3.GetComponent<Image>().sprite == Buttons.sprites[2])
                    {
                        thirdCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                }
                else if (thirdCarsColl[i].bounds.Intersects(btn4Collider.bounds))
                {
                    if (btn4.GetComponent<Image>().sprite == Buttons.sprites[3])
                    {
                        thirdCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                    else if (btn4.GetComponent<Image>().sprite == Buttons.sprites[4])
                    {
                        thirdCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (thirdCarsColl[i].bounds.Intersects(cornerCollider.bounds))
                {
                    thirdCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                }

                if (thirdCarsColl[i].bounds.Intersects(blueCollider.bounds))
                {
                    if (thirdCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[0])
                    {
                        Destroy(thirdCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(thirdCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (thirdCarsColl[i].bounds.Intersects(greenCollider.bounds))
                {
                    if (thirdCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[1])
                    {
                        Destroy(thirdCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(thirdCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (thirdCarsColl[i].bounds.Intersects(orangeCollider.bounds))
                {
                    if (thirdCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[2])
                    {
                        Destroy(thirdCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(thirdCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (thirdCarsColl[i].bounds.Intersects(pinkCollider.bounds))
                {
                    if (thirdCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[3])
                    {
                        Destroy(thirdCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(thirdCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (thirdCarsColl[i].bounds.Intersects(purpleCollider.bounds))
                {
                    if (thirdCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[4])
                    {
                        Destroy(thirdCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(thirdCars[i]);
                        Score.score -= 1;
                    }
                }
            }
            else
            {
                Debug.Log("thirdCars[" + i + "] is null");
            }
        }
    }

    IEnumerator spawn4()
    {
        for (int i = 0; i <= 4; i++)
        {
            yield return new WaitForSeconds(4);

            if ((fourthCars[i] != null) && (fourthCarsColl[i] != null))
            {
                fourthCars[i].transform.Translate(new Vector2(0, 60) * Time.deltaTime, Space.Self);

                if (fourthCarsColl[i].bounds.Intersects(btn1Collider.bounds))
                {
                    if (btn1.GetComponent<Image>().sprite == Buttons.sprites[3])
                    {
                        fourthCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                    else if (btn1.GetComponent<Image>().sprite == Buttons.sprites[4])
                    {
                        fourthCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (fourthCarsColl[i].bounds.Intersects(btn2Collider.bounds))
                {
                    if (btn2.GetComponent<Image>().sprite == Buttons.sprites[0])
                    {
                        fourthCars[i].transform.rotation = Quaternion.Euler(0, 0, 180);
                    }
                    else if (btn2.GetComponent<Image>().sprite == Buttons.sprites[2])
                    {
                        fourthCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (fourthCarsColl[i].bounds.Intersects(btn3Collider.bounds))
                {
                    if (btn3.GetComponent<Image>().sprite == Buttons.sprites[1])
                    {
                        fourthCars[i].transform.rotation = Quaternion.Euler(0, 0, 180);
                    }
                    else if (btn3.GetComponent<Image>().sprite == Buttons.sprites[2])
                    {
                        fourthCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                }
                else if (fourthCarsColl[i].bounds.Intersects(btn4Collider.bounds))
                {
                    if (btn4.GetComponent<Image>().sprite == Buttons.sprites[3])
                    {
                        fourthCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                    }
                    else if (btn4.GetComponent<Image>().sprite == Buttons.sprites[4])
                    {
                        fourthCars[i].transform.rotation = Quaternion.Euler(0, 0, 90);
                    }
                }
                else if (fourthCarsColl[i].bounds.Intersects(cornerCollider.bounds))
                {
                    fourthCars[i].transform.rotation = Quaternion.Euler(0, 0, 270);
                }

                if (fourthCarsColl[i].bounds.Intersects(blueCollider.bounds))
                {
                    if (fourthCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[0])
                    {
                        Destroy(fourthCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(fourthCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (fourthCarsColl[i].bounds.Intersects(greenCollider.bounds))
                {
                    if (fourthCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[1])
                    {
                        Destroy(fourthCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(fourthCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (fourthCarsColl[i].bounds.Intersects(orangeCollider.bounds))
                {
                    if (fourthCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[2])
                    {
                        Destroy(fourthCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(fourthCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (fourthCarsColl[i].bounds.Intersects(pinkCollider.bounds))
                {
                    if (fourthCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[3])
                    {
                        Destroy(fourthCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(fourthCars[i]);
                        Score.score -= 1;
                    }
                }
                else if (fourthCarsColl[i].bounds.Intersects(purpleCollider.bounds))
                {
                    if (fourthCars[i].GetComponent<Image>().sprite == SpriteGenerator.cars[4])
                    {
                        Destroy(fourthCars[i]);
                        Score.score += 1;
                    }
                    else
                    {
                        Destroy(fourthCars[i]);
                        Score.score -= 1;
                    }
                }
            }
            else
            {
                Debug.Log("fourthCars[" + i +"] is null");
            }
        }
    }
}
