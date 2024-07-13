using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DroneIndex : MonoBehaviour
{
    [SerializeField]
    public static uint index = 1;



    public TMP_Text txtScore;

    void Start()
    {
        index = 1;
    }

    public void AddIndex(uint point)
    {
        index++;
        uint _temps = uint.Parse(txtScore.text.Split('/')[0]) + point;
        txtScore.text = _temps.ToString() + "/160";
    }

    public static uint Index()
    {
        return index;
    }

}
