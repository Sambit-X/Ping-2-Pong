using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMovement : MonoBehaviour
{
    public GameObject barRight;
    public GameObject barLeft;
    public GameObject barUp;
    public GameObject barDown;
    public int moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && barRight.transform.position.y <= 2.6F)
        {
            barRight.transform.position += Vector3.up * moveSpeed *  Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) && barRight.transform.position.y >= -2.5F)
        {
            barRight.transform.position += Vector3.down * moveSpeed* Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.W) && barLeft.transform.position.y <= 2.6F)
        {
            barLeft.transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) && barLeft.transform.position.y >= -2.5F)
        {
            barLeft.transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.A) && barUp.transform.position.x >= -5.55F)
        {
            barUp.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) && barUp.transform.position.x <= 5.55F)
        {
            barUp.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && barDown.transform.position.x >= -5.55F)
        {
            barDown.transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) && barDown.transform.position.x <= 5.55F)
        {
            barDown.transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }
}
