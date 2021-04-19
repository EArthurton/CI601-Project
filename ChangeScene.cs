using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public Button menuButton, cInstructions, mInstructions, sInstructions, cStart, mStart, sStart, cont, paused;

    public void StartConcentration()
    {
        SceneManager.LoadScene("ConcentrationGame");
    }

    public void StartMemory()
    {
        SceneManager.LoadScene("MLevel1");
    }

    public void StartSpeed()
    {
        SceneManager.LoadScene("SpeedGame");
    }

    public void ConcentrationInstructions()
    {
        SceneManager.LoadScene("CInstructions");
    }

    public void MemoryInstructions()
    {
        SceneManager.LoadScene("MInstructions");
    }

    public void SpeedInstructions()
    {
        SceneManager.LoadScene("SInstructions");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Navigation");
    }


    public void OnEnable()
    {
        menuButton.onClick.AddListener(BackToMenu);
        cInstructions.onClick.AddListener(ConcentrationInstructions);
        mInstructions.onClick.AddListener(MemoryInstructions);
        sInstructions.onClick.AddListener(SpeedInstructions);
        cStart.onClick.AddListener(StartConcentration);
        mStart.onClick.AddListener(StartMemory);
        sStart.onClick.AddListener(StartSpeed);
    }

    public void OnDisable()
    {
        menuButton.onClick.RemoveListener(BackToMenu);
        cInstructions.onClick.RemoveListener(ConcentrationInstructions);
        mInstructions.onClick.RemoveListener(MemoryInstructions);
        sInstructions.onClick.RemoveListener(SpeedInstructions);
        cStart.onClick.RemoveListener(StartConcentration);
        mStart.onClick.RemoveListener(StartMemory);
        sStart.onClick.RemoveListener(StartSpeed);
    }
}
