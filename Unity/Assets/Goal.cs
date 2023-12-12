using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    /*
    [Header("Player2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Text;
    public GameObject Player2Text;

    private int Player1Score;
    private int Player2Score;
    */

    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Goal)
            {
                //Player2Score++;
                //Player2Text.GetComponent<TMPro.TextMeshProUGUI>().text = Player2Score.ToString();
                //Player1Score++;
                //print(isPlayer1Goal);
                Debug.Log("Player 2 scored...");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player2Scored();
            }
            else
            {
                //Player2Score++;
                //Player2Text.GetComponent<TMPro.TextMeshProUGUI>().text = Player2Score.ToString();
                Debug.Log("Player 1 scored...");
                GameObject.Find("GameManager").GetComponent<GameManager>().Player1Scored();
            }
        }
    }
}
