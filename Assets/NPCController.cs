using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using MathUtil;

public class NPCController : MonoBehaviour
{
    GameObject player;
    public NavMeshAgent enemy;
    public Transform Player;
    private bool sawIt; 

   


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        bool sawIt = false;
    }
    void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        

        if (Util.CanSeeObj(player, gameObject, 0.9f))
        {
            Debug.Log("I can see the player!");
            
            enemy.SetDestination(Player.position);

        }



        
    }
}
