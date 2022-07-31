using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tube : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    [SerializeField] private float zBound;

    private void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if(transform.position.z <= zBound)
        {
            Destroy(gameObject);
        }
    }
}
