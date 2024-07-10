using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class CirclePoint : MonoBehaviour
{
    public uint Point = 1;
    void Start()
    {

        if (Point < 1 || Point > 10)
        {
            Point = 1;
        }

        GameObject cirlce = this.gameObject;

        float temp = ((-0.055f) * (float)Point + 1f);

        cirlce.transform.localScale = new Vector3(temp, temp, temp);

        print($"<color=#FF0000>{temp}</color>");
    }

}
