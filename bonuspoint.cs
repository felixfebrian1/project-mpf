using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPoints : MonoBehaviour
{
    //make a container for the heads up display
    pancam hud;

    void OnTriggerEnter2D(Collider2D coll)
    {
		if (coll.tag != "Player")
        {
            hud = GameObject.Find("Main Camera").GetComponent<pancam>();
            hud.increaseScore(10);
            Destroy(this.gameObject);
        }

    }
}
