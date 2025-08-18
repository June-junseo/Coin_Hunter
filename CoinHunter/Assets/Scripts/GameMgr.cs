using System.Threading;
using TMPro;
using UnityEngine;

public class GameMgr : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public int score = 0;

    public void AddScore(int amount)
    {
        score += amount;
        UpdateTextUi();
    }
    private void UpdateTextUi()
    {
        textScore.text = "Score: " + score.ToString();
    }
}
