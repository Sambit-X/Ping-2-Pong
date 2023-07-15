using UnityEngine;
using UnityEngine.UI;

public class ScoreShower : MonoBehaviour
{
    public Text scoreText;
    public BallMovement ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        addScore();
    }

    public void addScore()
    {
        scoreText.text = ball.Score.ToString();
    }
}
