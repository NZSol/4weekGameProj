using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{

    GameObject playerClone;

    public screenFade canvs;
    public keyCardPickup[] kcp;

    public GameObject player;
    public GameObject CanvasGroup;

    // Use this for initialization
    void Start()
    {
        playerClone = Instantiate(player, transform.position, Quaternion.identity) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playerDeath()
    {
        canvs.fadeOut();
    }

    public void playerRespawn()
    {
        CanvasGroup.GetComponent<screenFade>().fadeIn();
    }
}
