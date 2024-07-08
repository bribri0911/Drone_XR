using Oculus.Interaction.DebugTree;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_TargetDrone : MonoBehaviour
{

    public MeshRenderer RendererRenderer;

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Passez dans le cerceau");

        RendererRenderer.materials[0].color = Color.green;
        



        BoxCollider temps = GetComponent<BoxCollider>();

        temps.enabled = false;
    }

    private void Start()
    {
        RendererRenderer.materials[0].color = Color.red;
    }


}
