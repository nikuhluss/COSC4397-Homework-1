using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : DefaultTrackableEventHandler
{
    public Rigidbody player;

    override protected void OnTrackingLost()
    {
        player.useGravity = false;
    }
    override protected void OnTrackingFound()
    {
        player.useGravity = true;
    }
}
