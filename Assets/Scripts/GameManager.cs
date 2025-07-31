using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score;
    int gold;
    int apple;

    [SerializeField] TextMeshProUGUI goldText;
    [SerializeField] TextMeshProUGUI appleText;

    public void AddScore()
    {
        score++;
        Debug.Log("Score: " + score);
        if(score >= 10)
        {
            Debug.Log("We won!");
        }
    }

    public void AddGold()
    {
        gold++;

        goldText.text = "Gold: " + gold.ToString();
    }

    public void BuyApple()
    {
        if (gold >= 5)
        {
            gold -= 5;
            apple++;

            appleText.text = "Apple: " + apple.ToString();
            goldText.text = "Gold: " + gold.ToString();
        }
        else
        {
            Debug.Log("Not enough gold");
        }
    }
}
