using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAC : MonoBehaviour
{
    public bool AwareOfPlayer { get; private set; }

    public Vector2 DirectionToPlayer { get; private set; }

    [SerializeField] private float PlayerDistance;

    // Update is called once per frame
    void Update()
    {
        
    }
}
