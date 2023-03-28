using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Camera.main.transform.position = new Vector3(0,4,-10);

            player.transform.position = new Vector3(0,1,0);
        }
    }

}
