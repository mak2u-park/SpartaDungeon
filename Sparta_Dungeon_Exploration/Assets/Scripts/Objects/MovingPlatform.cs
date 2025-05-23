using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform startPosition;
    public Transform endPosition;
    
    public float speed = 3f;
    public float waitTime = 3f;
    public float stopDistance = 10f;
    
    private Transform player;
    private Vector3 targetPosition;
    private Coroutine moveCoroutine;
    private Vector3 startWorldPos;
    private Vector3 endWorldPos;

    private void Start()
    {
        player = CharacterManager.Instance.Player.transform;
        startWorldPos = startPosition.position;
        endWorldPos = endPosition.position;
    }

    private void Update()
    {
        float playerDistance = Vector3.Distance(transform.position, player.transform.position);

        if (playerDistance <= stopDistance)
        {
            if (moveCoroutine == null)
            {
                moveCoroutine = StartCoroutine(MovePosition());
            }
        }
        else
        {
            if (moveCoroutine != null)
            {
                StopCoroutine(moveCoroutine);
                moveCoroutine = null;
            }
        }
    }

    private IEnumerator MovePosition()
    {
        targetPosition = endPosition.position;
        
        while (true)
        {
            while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
                yield return null;
            }
            
            yield return new WaitForSeconds(waitTime);
            
            targetPosition = (targetPosition == endWorldPos) ? startWorldPos : endWorldPos;
        }
        
    }
}
