using UnityEngine;

public class BombController : MonoBehaviour
{
    [SerializeField] private float explosionTime = 5;
    [SerializeField] private GameObject explosionEffect;

    private float explosionTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        explosionTimer = explosionTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(explosionTimer > 0)
        {
            explosionTimer-= Time.deltaTime;
        }
        else
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
