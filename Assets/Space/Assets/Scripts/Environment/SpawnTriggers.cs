using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum spawns { spawn1, spawn2, spawn3 }

public class SpawnTriggers : MonoBehaviour
{
    public spawns Spawners;
    public spawnPoints sp;

    private void OnTriggerEnter(Collider col)
    {
        switch (Spawners)
        {
            case spawns.spawn1:

                if (col.gameObject.tag == "player")
                {
                    sp.spawn1();
                }
                break;

            case spawns.spawn2:
                if (col.gameObject.tag == "player")
                {
                    sp.spawn2();
                }
                break;

            case spawns.spawn3:
                if (col.gameObject.tag == "player")
                {
                    sp.spawn3();
                }
                break;
        }
    }
}
