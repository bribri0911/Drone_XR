using Oculus.Interaction.DebugTree;
using System.Collections;
using System.Collections.Generic;
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


        if(IndexActuelle > Index && !Stop)
        {

            RendererRenderer.materials[0].color = Color.black;

            BoxCollider temps = GetComponent<BoxCollider>();
            temps.enabled = false;
            Stop = true;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(Index == IndexActuelle)
        {
            RendererRenderer.materials[0].color = Color.black;
            BoxCollider temps = GetComponent<BoxCollider>();
            temps.enabled = false;
            droneIndex.AddIndex();
        }
    }

    private void Start()
    {

        Player = GameObject.FindGameObjectWithTag("Player");

        droneIndex = Player.GetComponent<DroneIndex>();

        RendererRenderer.materials[0].color = Color.white;



        BoxCollider temps = GetComponent<BoxCollider>();
        temps.enabled = false;


    }


}

