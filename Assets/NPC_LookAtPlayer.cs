using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_LookAtPlayer : MonoBehaviour
{
    public Transform targetPlayer;
    public float rotationSpeed;

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(targetPlayer.position - transform.position), rotationSpeed * Time.deltaTime);
    }
}
