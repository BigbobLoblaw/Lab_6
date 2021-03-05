using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public enum CollectibleType
    {
        POWERUP,
        COLLECTIBLE,
        LIVES,
        KEY
    }

    public CollectibleType currentCollectible;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            switch (currentCollectible)
            {
                case CollectibleType.POWERUP:
                    Debug.Log("POWERUP GET!");
                    collision.GetComponent<PlayerMovement>().StartJumpForceChange();
                    Destroy(this.gameObject);
                    break;

                case CollectibleType.COLLECTIBLE:
                    Debug.Log("MONEY GET!");
                    collision.GetComponent<PlayerMovement>().score++;
                    Destroy(this.gameObject);
                    break;

                case CollectibleType.LIVES:
                    Debug.Log("LIFE GET!");
                    collision.GetComponent<PlayerMovement>().lives++;
                    Destroy(this.gameObject);
                    break;

            }

        }
    }

}
