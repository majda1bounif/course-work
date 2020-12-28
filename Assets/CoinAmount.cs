using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinAmount : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //gameObject.GetComponent<Text>().text = "0";
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("CoinAmount") + "";
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown("a"))
        //{
        //    Debug.Log("Your Coins Are Saved");
        //    PlayerPrefs.SetInt("CoinAmount", int.Parse(gameObject.GetComponent<Text>().text));
        //}
    }
    public void SaveCoin()
    {
        //int CoinAlreadyCollected = PlayerPrefs.GetInt("CoinAmount");
        PlayerPrefs.SetInt("CoinAmount" , int.Parse(gameObject.GetComponent<Text>().text));
    }

}
