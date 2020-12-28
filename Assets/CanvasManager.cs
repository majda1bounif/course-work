using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CanvasManager : MonoBehaviour
{
    public GameObject pauseBtn;
    public GameObject pausePanel;
    public GameObject gameOverPanel;
    public GameObject panel;
    public GameObject coinPanelTxt;
    public GameObject gameOverCoinTxt;
    private bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameOver()
    {
        Time.timeScale = 0;
        coinPanelTxt.GetComponent<CoinAmount>().SaveCoin();
        gameOverCoinTxt.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinAmount") +"";

        gameOverPanel.SetActive(true);
        //gameOverCoinTxt.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinAmount") + "";
        pauseBtn.SetActive(false);
        panel.SetActive(false);

    }

    public void PausePlay()
    {
        if (isPause)
        {
            isPause = false;
            Time.timeScale = 1;
            pauseBtn.SetActive(true);
            pausePanel.SetActive(false);
        }
        else
        {
            isPause = true;
            Time.timeScale = 0;
            pauseBtn.SetActive(false);
            pausePanel.SetActive(true);
        }
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
}
