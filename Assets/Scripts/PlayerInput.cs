using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private Animator animator;
    private bool isPlayerCouch = false;
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        animator = GetComponentInChildren<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        if(playerMovement != null)
        {
            if (Input.GetKey(KeyCode.LeftShift) && isPlayerCouch == false)
            {
                Settings.state = PlayerState.Run;
                animator.SetTrigger("Run");
                playerMovement.speed = 5;
            }

            else if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) ||
                Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
                && isPlayerCouch == false)
            {
                Settings.state = PlayerState.Walk;
                animator.SetTrigger("Walk");
                playerMovement.speed = 2;
            }
            
            else
            {
                Settings.state = PlayerState.Idle;
                animator.SetTrigger("Idle");
                playerMovement.speed = 0;
            }

            if (Input.GetKeyDown(KeyCode.C))
            {                    
                if(isPlayerCouch == false)
                {
                    isPlayerCouch = true;
                    Settings.state = PlayerState.Couch;
                    animator.SetBool("Couch", true);                    
                    playerMovement.speed = 0;
                 
                }
                else
                {
                    Settings.state = PlayerState.Idle;
                    animator.SetBool("Couch", false);
                    playerMovement.speed = 2;
                    isPlayerCouch = false;
                }
            }
            
        }        
    }
}
