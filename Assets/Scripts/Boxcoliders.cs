using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxcoliders : MonoBehaviour
{
    public enum type { Right,Left };
    public type direction;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.isRotate = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (direction == type.Right)
            {
                GameManager.Instance.isRight = true;
            }
            if (direction == type.Left)
            {
                GameManager.Instance.isLeft = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (direction == type.Right)
            {
                GameManager.Instance.isRight = false;
                GameManager.Instance.isRotate = true;

            }
            if (direction == type.Left)
            {
                GameManager.Instance.isLeft = false;
                GameManager.Instance.isRotate = true;
            }
        }
    }
}
