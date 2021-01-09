    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private float startingX = 23.2f;
    private float startingY = 13.2f;
    private float horizontalMove = 0f;
    private float verticalMove = 0f;
    private Rigidbody2D rb;
    public Transform player;
    private float startTimeBtwShots;
    public float timeBtwShots;

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.position = new Vector2(startingX, startingY); // set starting position
        rb.rotation = -90f;
        startTimeBtwShots = 2f;
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        rb.position = new Vector2(startingX, player.position.y);
        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        } else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
