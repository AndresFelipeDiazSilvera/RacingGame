using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public float gasoline = 50f;
    public float gasolineConsumptionRate = 1f;
    public Text gasolineText;
    public float time = 20f;
    public float timeRest = 1f;
    public Text timeText;

    void Update()
    {
        gasoline -= gasolineConsumptionRate * Time.deltaTime;
        gasoline = Mathf.Clamp(gasoline, 0, 100);
        UpdateGasolineText();
        time -= timeRest * Time.deltaTime;
        time = Mathf.Clamp(time, 0, 100);
        UpdateTimeText();
        if (time <= 0 )
        {
            SceneManager.LoadScene("loseScene");
        }

    }

    void UpdateGasolineText()
    {
        gasolineText.text = "" + gasoline.ToString("F0");
    }

    public void RestGasoline(float RestGasoline)
    {
        gasoline -= RestGasoline;
    }


    public void AddGasoline(float AddGasoline)
    {
        gasoline += AddGasoline;
    }


    void UpdateTimeText()
    {
        timeText.text = "" + time.ToString("F0");

    }
}