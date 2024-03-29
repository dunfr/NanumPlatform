using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class BarragesManager : MonoBehaviour
{
    public enum type { Laser, Circle, Box };
    public type barragesType;
    public enum vectortype { X, Mx, Y, My }
    public vectortype Vector;
    public float cooolTime;
    //private IObjectPool<BarragesManager> _ManagedPool;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (barragesType == type.Box)
        {
            Vector2 position = transform.localPosition;
            if (Vector == vectortype.X)
            { 
                position.x += 5f * Time.deltaTime;
            }
            if (Vector == vectortype.Mx)
            {
                position.x += -10 * Time.deltaTime;
            }
            if (Vector == vectortype.Y)
            {
                position.y += 10 * Time.deltaTime;
            }
            if (Vector == vectortype.My)
            {
                position.y += - 10 * Time.deltaTime;
            }
            transform.localPosition = position;
        }
    }
    public void Release()
    {
        Invoke("Destroy", cooolTime);
    }
    void Destroy()
    {
       this.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("die");
        }
    }
}
