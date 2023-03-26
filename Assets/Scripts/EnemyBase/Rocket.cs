using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;

    private Transform _playerTransform;
    private Transform _finelTransform;

    private void Start()
    {
        _playerTransform = FindObjectOfType<PlayerMove>().transform;
//        _finelTransform.transform.position = new Vector3(_playerTransform.position.x, _playerTransform.position.y, 0);
    }

    private void Update()
    {
        transform.position += Time.deltaTime * transform.forward * Speed;

        Vector3 toPlayer = _playerTransform.position - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(toPlayer, Vector3.forward);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * RotationSpeed);
    }
}
