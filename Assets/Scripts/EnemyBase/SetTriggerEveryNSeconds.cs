using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTriggerEveryNSeconds : MonoBehaviour
{
    public float Period = 7f;
    public Animator Animator;
    public string TriggerName = "Attack";

    private float _timer;

    private void Update()
    {
        _timer += Time.deltaTime;

        if(_timer > Period)
        {
            _timer= 0;
            Animator.SetTrigger(TriggerName);
        }
    }
}
