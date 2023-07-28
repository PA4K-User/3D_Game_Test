using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowItems : MonoBehaviour
{
    [SerializeField] private Image copper;
    [SerializeField] private Image silver;
    [SerializeField] private Image gold;

    [SerializeField] private GameObject keyitemDoor;

    private void Awake()
    {
        copper.gameObject.SetActive(false);
        silver.gameObject.SetActive(false);
        gold.gameObject.SetActive(false);

        keyitemDoor.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if(Settings.pickupCopperCoin)
            copper.gameObject.SetActive(true);

        if (Settings.pickupSilverCoin)
            silver.gameObject.SetActive(true);

        if (Settings.pickupGoldCoin)
            gold.gameObject.SetActive(true);

        if(Settings.KeyItem == 3)
            keyitemDoor.SetActive(false);
    }
}
