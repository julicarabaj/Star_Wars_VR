using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NewBehaviourScript : MonoBehaviour
{
    /*
    public GameObject player;
    public NavMeshAgent navMeshAgent;
    public Transform[] destinations; //Array para los puntos target del enemy
    public float distanceToFollowPath = 2;
    private int i = 0;
    //[Heather(“follow player”)] //esta linea sirve para hacer comentarios en el inspector
    public bool folllowPlayer;
    private float distancePlayer;
    public float distanceToFollow = 5;
    
    void Start()
    {
        navMeshAgent.destination = destinations[0].transform.position; //si se quiere un target especifico sin moverse en el start esta bien
        //player = FindObjectOfType<InputActionManager>().GameObject;
    }
    void Update()
    {
        distancePlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distancePlayer <= distanceToFollow && FollowPlayer)
        {
            FollowPlayer();
        }
        else
        {
            EnemyPath();
        }


    }
    public void EnemyPath()
    {
        navMeshAgent.destination = destinations[i].position;

        if (Vector3.Distance(transform.position, destinations[i].position <= distanceToFollowPath))
        {
            if (destinations[i] != destinations[destinations.Lenght] - 1)
            {
                i++;
            }
            else
            {
                i = 0;
            }

        }

    }

    public void FollowPlayer()
    {
        navMeshAgent.destination = player.transform.position;
    }

    */
}