using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
        // Camera follows the player with specified offset position
        if (transform.position != newPos)
        {
            new Vector3(player.position.x + offset.x, player.position.y + offset.y, offset.z);
        }
        transform.position = newPos;
    }
}
