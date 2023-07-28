using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Text pickuptxt;

    public bool Copper;
    public bool Silver;
    public bool Gold;
    private void Awake()
    {
        pickuptxt.gameObject.SetActive(false);
    }
    private void OnMouseOver()
    {
        float dist = Vector3.Distance(player.transform.position, transform.position);

        if (dist < 5 )
        {
            pickuptxt.gameObject.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(Copper)
                    Settings.pickupCopperCoin = true;

                else if (Silver)
                    Settings.pickupSilverCoin = true;

                else if (Gold)
                    Settings.pickupGoldCoin = true;

                Settings.KeyItem += 1;

                pickuptxt.gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }        
    }

    private void OnMouseExit()
    {
        pickuptxt.gameObject.SetActive(false);
    }
}
