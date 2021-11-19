using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;

    void Update ()
    {
        if (player.position.y > transform.position.y)
        {
            transform.position = new Vector3(player.position.x, player.position.y, player.position.z);
        }
    }



}