using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneIndex : MonoBehaviour
{
    [SerializeField]
    public static uint index = 1;

    void Start()
    {
        index = 1;
    }

    public void AddIndex()
    {
        index++;
    }

    public static uint Index()
    {
        return index;
    }

}
