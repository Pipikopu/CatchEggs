using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerTransform;
    public Rigidbody2D playerRigid;
    public float speed;
    public float borderLeft;
    public float borderRight;
    private float newPosX;
    private float newOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            newOffset = speed * Time.deltaTime;
            newPosX = playerTransform.position.x + newOffset;
            if (newPosX >= borderRight)
            {
                return;
            }
            playerTransform.position += new Vector3(newOffset, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            newOffset = speed * Time.deltaTime;
            newPosX = playerTransform.position.x - newOffset;
            if (newPosX <= borderLeft)
            {
                return;
            }
            playerTransform.position -= new Vector3(newOffset, 0, 0);
        }
    }
}
