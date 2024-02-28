using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAC : MonoBehaviour
{
    public bool AwareOfPlayer { get; private set; }

    public Vector2 DirectionToPlayer { get; private set; }

    [SerializeField] private float PlayerDistance;

    private Transform player;


    private void Awake()
    {
        player = FindObjectOfType<Player>().transform;
    }
    void Update()
    {
        Vector2 enemyToPlayerVector = player.position - transform.position;
        DirectionToPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= PlayerDistance)
        {
            AwareOfPlayer = true;
        }
        else
        {
            AwareOfPlayer = false;
        }
    }
}
