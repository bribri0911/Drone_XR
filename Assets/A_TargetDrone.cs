using Oculus.Interaction.DebugTree;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class A_TargetDrone : MonoBehaviour
{

    public MeshRenderer RendererRenderer;
    public uint Index = 1;
    public GameObject Player;

    private DroneIndex droneIndex;
    public uint IndexActuelle = 0;
    public bool Stop = false;

    public uint Point = 1;



    private void Update()
    {
        IndexActuelle = DroneIndex.Index();

        if (Index == IndexActuelle && !Stop)
        {
            RendererRenderer.materials[0].color = Color.yellow;

            BoxCollider temps = GetComponent<BoxCollider>();
            temps.enabled = true;
            Stop = true;
        }


        if(IndexActuelle > Index)
        {

            RendererRenderer.materials[0].color = Color.black;

            BoxCollider temps = GetComponent<BoxCollider>();
            temps.enabled = false;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(Index == IndexActuelle)
        {
            RendererRenderer.materials[0].color = Color.black;
            BoxCollider temps = GetComponent<BoxCollider>();
            temps.enabled = false;
            droneIndex.AddIndex(Point);

        }
    }

    private void Start()
    {
        
        if (Point < 1 || Point > 10)
        {
            Point = 1;
        }

        GameObject cirlce = this.gameObject;

        float temp = ((-0.055f) * (float)Point + 1f);

        cirlce.transform.localScale = new Vector3(temp, temp, temp);

        print($"<color=#FF0000>{temp}</color>");

        Player = GameObject.FindGameObjectWithTag("Player");

        droneIndex = Player.GetComponent<DroneIndex>();

        RendererRenderer.materials[0].color = Color.white;


        BoxCollider temps = GetComponent<BoxCollider>();
        temps.enabled = false;


    }


}

