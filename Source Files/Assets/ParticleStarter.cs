using UnityEngine;

public class ParticleStarter : MonoBehaviour
{
    public ParticleSystem particles;
    public BallMovement ball;
    private int flag = 0;
    // Start is called before the first frame update
    void Start()
    {

        flag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.ballDestroyed == true && flag==0)
        {
            Instantiate(particles, ball.lastPosition, particles.transform.rotation);
            flag = 1;
        }
    }
}
