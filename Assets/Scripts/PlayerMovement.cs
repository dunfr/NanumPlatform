using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float jumpPower;
    private Rigidbody2D playerRigidbody2D;
    private bool isground;
    public float rotatePoint;
    public Transform groundCheck;
    public LayerMask groundLayer;
   
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        move();
    }
    // Update is called once per frame
    void Update()
    {
        jump();
        rotate();
    }
    void move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x += horizontal * movementSpeed * Time.deltaTime;
        transform.position = position;
    }
    void jump()
    {
        isground = Physics2D.OverlapCapsule(groundCheck.position,new Vector2(0.1f,0.18f),CapsuleDirection2D.Horizontal,0,groundLayer);
        if (Input.GetKeyDown(KeyCode.UpArrow) && isground)
        {
            playerRigidbody2D.velocity = new Vector2(playerRigidbody2D.velocity.x, jumpPower);
        }
    }
    void rotate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (Singleton.Instance.isRight)
            {
                rotatePoint = +90;
                transform.Rotate(0, 0, rotatePoint);
            }
            if (Singleton.Instance.isLeft)
            {
                rotatePoint = -90;
                transform.Rotate(0, 0, rotatePoint);
            }
        }
    }
}
