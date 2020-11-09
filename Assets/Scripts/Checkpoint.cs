using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Transform playerspawn;

    private void Awake()
    {
        playerspawn = GameObject.FindGameObjectWithTag("PlayerSpawn").transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerspawn.position = transform.position;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
