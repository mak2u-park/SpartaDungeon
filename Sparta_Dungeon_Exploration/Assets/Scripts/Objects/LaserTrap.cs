using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    public PlayerCondition _condition;
    public float laserdistance;
    public LayerMask playerLayer;

    
    private void Start()
    {
        _condition = CharacterManager.Instance.Player.condition;
    }
    private void Update()
    {
        RaycastHit hit;
        Vector3 LaserTrapPos = transform.position;
        Vector3 LaserDir = transform.up;
        if (Physics.Raycast(LaserTrapPos, LaserDir, out hit, laserdistance))
        {
            if (hit.collider.tag == "Player")
            {
                
            }
        }
    }
    
}
