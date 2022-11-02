using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }
    void FixedUpdate()
    {
        move();
    }
    // Update is called once per frame
    void Update()
    {
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

    }
}
