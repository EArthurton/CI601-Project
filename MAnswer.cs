using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MAnswer : MonoBehaviour
{
    private GameObject time, question, gameOver, inputField, aButton, fButton, nButton, yButton, ready, emptyAnswer;
    private float countDownTimer, nextSceneTimer;
    private Text timeText, gameOverText, inputText, answerText;
    private string[] shapeNames;
    private List<string> userInput;
    public InputField input;
    public Button answerButton, finishedButton, yesButton, noButton;

    // Start is called before the first frame update
    void Start()
    {
        nextSceneTimer = 5;

        userInput = new List<string>();

        time = GameObject.Find("Time");
        question = GameObject.Find("Question");
        gameOver = GameObject.Find("Game Over");
        inputField = GameObject.Find("InputField");
        aButton = GameObject.Find("Answer Button");
        fButton = GameObject.Find("Finish Button");
        nButton = GameObject.Find("No Button");
        yButton = GameObject.Find("Yes Button");
        ready = GameObject.Find("Ready");
        emptyAnswer = GameObject.Find("Empty Answer");

        inputText = GameObject.Find("User Input").GetComponent<Text>();
        answerText = GameObject.Find("Correct Answers").GetComponent<Text>();
        timeText = time.GetComponent<Text>();
        gameOverText = gameOver.GetComponent<Text>();

        shapeNames = new string[6];
        shapeNames[0] = "Circle";
        shapeNames[1] = "Heart";
        shapeNames[2] = "Hexagon";
        shapeNames[3] = "Pentagon";
        shapeNames[4] = "Star";
        shapeNames[5] = "Triangle";

        ready.SetActive(false);
        nButton.SetActive(false);
        yButton.SetActive(false);
        emptyAnswer.SetActive(false);

        if (SceneName.previousLevel == "MLevel1")
        {
            countDownTimer = 60;
        }
        else if (SceneName.previousLevel == "MLevel2")
        {
            countDownTimer = 50;

            inputText.fontSize = 70;
            answerText.fontSize = 70;
        }
        else if (SceneName.previousLevel == "MLevel3")
        {
            countDownTimer = 40;

            inputText.fontSize = 60;
            answerText.fontSize = 60;

        }
        else if (SceneName.previousLevel == "MLevel4")
        {
            countDownTimer = 30;

            inputText.fontSize = 50;
            answerText.fontSize = 50;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timeText != null)
        {
            countDownTimer -= Time.deltaTime;
            DisplayTime(countDownTimer);
        }

        if(countDownTimer <= 0)
        {
            time.SetActive(false);
            question.SetActive(false);
            inputField.SetActive(false);
            aButton.SetActive(false);

            gameOverText.text = string.Format("Game Over!");

            nextSceneTimer -= Time.deltaTime;
            if (nextSceneTimer <= 0)
            {
                SceneManager.LoadScene("MInstructions");
            }
        }
    }

    private void OnEnable()
    {
        answerButton.onClick.AddListener(StoreAnswers);
        finishedButton.onClick.AddListener(FinishGame);
        noButton.onClick.AddListener(BackToGame);
        yesButton.onClick.AddListener(ShowAnswers);
    }

    private void OnDisable()
    {
        answerButton.onClick.RemoveListener(StoreAnswers);
        finishedButton.onClick.RemoveListener(FinishGame);
        noButton.onClick.RemoveListener(BackToGame);
        yesButton.onClick.RemoveListener(ShowAnswers);
    }

    public void StoreAnswers()
    {
        if (input.text != "")
        {
            emptyAnswer.SetActive(false);
            Debug.Log(input.text);
            userInput.Add(input.text);
            input.text = "";
        }
        else
        {
            emptyAnswer.SetActive(true);
        }
    }

    public void FinishGame()
    {
        if(gameOverText.text == "")
        {
            if (question.activeSelf == true && inputField.activeSelf == true && aButton.activeSelf == true)
            {
                ready.SetActive(true);
                nButton.SetActive(true);
                yButton.SetActive(true);
                fButton.SetActive(false);
            }
            else
            {
                if (SceneName.previousLevel == "MLevel1")
                {
                    SceneManager.LoadScene("MLevel2");
                }
                else if (SceneName.previousLevel == "MLevel2")
                {
                    SceneManager.LoadScene("MLevel3");
                }
                else if (SceneName.previousLevel == "MLevel3")
                {
                    SceneManager.LoadScene("MLevel4");
                }
                else if (SceneName.previousLevel == "MLevel4")
                {
                    SceneManager.LoadScene("Complete");
                }
            }
        }
        else
        {
            SceneManager.LoadScene("MInstructions-v1");
        }
    }

    public void BackToGame()
    {
        ready.SetActive(false);
        nButton.SetActive(false);
        yButton.SetActive(false);
        fButton.SetActive(true);
    }

    public void ShowAnswers()
    {
        question.SetActive(false);
        inputField.SetActive(false);
        time.SetActive(false);
        aButton.SetActive(false);
        ready.SetActive(false);
        nButton.SetActive(false);
        yButton.SetActive(false);
        fButton.SetActive(true);

        inputText.text = "Your answers:\n";

        foreach(var item in userInput)
        {
            inputText.text += item + "\n";
        }

        answerText.text = "Correct answers:\n";

        foreach(var item in MLevels.objectNames)
        {
            answerText.text += item + "\n";
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(countDownTimer / 60);
        float seconds = Mathf.FloorToInt(countDownTimer % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
