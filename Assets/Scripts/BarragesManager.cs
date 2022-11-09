using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarragesManager : MonoBehaviour
{
    public enum type { Laser, Circle, Box };
    public type barragesType;
    public enum vectortype { X, Mx, Y, My }
    public vectortype Vector;

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
                position.y += -10 * Time.deltaTime;
            }
            transform.localPosition = position;
            Invoke("Destroy", 6f);
        }
        if (barragesType == type.Circle)
        {
            Invoke("Destroy", 3f);
        }
        if (barragesType == type.Laser)
        {
            Invoke("Destroy", 3f);
        }
    }
    void Destroy()
    {
        Destroy(this.gameObject);
    }
}
