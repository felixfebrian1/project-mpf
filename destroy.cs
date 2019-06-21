using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D other)
    {
        //if the object that triggered the event is tagged player
		if (other.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }

		if (other.gameObject.transform.parent)
        {
			Destroy(other.gameObject.transform.parent.gameObject);

        }
        else
        {
			Destroy(other.gameObject);
        }
    }

}
