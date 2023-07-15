using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public GameObject ball;
    private int startSide;
    public float speed;
    private int rotationSpeed=200;
    private float i=-360;
    private int oldSide;
    public int Score=0;
    public bool ballDestroyed=false;
    public Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {
        Quaternion randomRotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
        ball.transform.rotation = randomRotation;
        startSide = Random.Range(1, 5);
        oldSide = startSide;
    }

    // Update is called once per frame
    void Update()
    {
        if(startSide==1)
        {
            ball.transform.position += new Vector3(Random.Range(1, 5) * speed, Random.Range(1, 5) * speed, 0) * Time.deltaTime;
        }
        else if(startSide==2)
        {
            ball.transform.position += new Vector3(-Random.Range(1, 5) * speed, Random.Range(1, 5) * speed, 0) * Time.deltaTime;
        }
        else if (startSide == 3)
        {
            ball.transform.position += new Vector3(Random.Range(1, 5) * speed, -Random.Range(1, 5) * speed, 0) * Time.deltaTime;
        }
        else if (startSide == 4)
        {
            ball.transform.position += new Vector3(-Random.Range(1, 5) * speed, -Random.Range(1, 5) * speed, 0) * Time.deltaTime;
        }
        
        i = i + rotationSpeed * Time.deltaTime;
        ball.transform.rotation = Quaternion.Euler(0, 0, i);
        if (i == 360)
        {
            i = -360;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (startSide == oldSide)
        {
            startSide = Random.Range(1, 5);
        }
        else
        {
            oldSide = startSide;
        }   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Score += 1;
        speed += 0.05F;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        lastPosition = ball.transform.position;
        gameObject.SetActive(false); 
        ballDestroyed = true;
    }
}
