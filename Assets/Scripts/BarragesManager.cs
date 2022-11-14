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
    private IObjectPool<BarragesManager> _ManagedPool;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        if (barragesType == type.Box)
        {
            Vector2 position = transform.localPosition;
            if (Vector == vectortype.X)
            { 
                position.x += 10 * Time.deltaTime;
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
    public void SetManagedPool(IObjectPool<BarragesManager> pool)
    {
        _ManagedPool = pool;
    }
    public void Release()
    {
        Invoke("Destroy", 3f);
    }
    void Destroy()
    {
        _ManagedPool.Release(this);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("die");
        }
    }
}
