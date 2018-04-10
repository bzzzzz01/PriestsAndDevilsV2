using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToAction : Action {
    public Vector3 target;
    public float speed;

    public static MoveToAction GetAction(Vector3 target, float speed)
    {
        MoveToAction action = CreateInstance<MoveToAction>();
        action.target = target;
        action.speed = speed;
        return action;
    }

    public override void Start() { }

    public override void Update()
    {
        this.GameObject.transform.position = Vector3.MoveTowards(this.GameObject.transform.position, target, speed * Time.deltaTime);
        if (this.GameObject.transform.position == target)
        {
            this.destroy = true;
            this.Callback.ActionEvent(this);
        }
    }
}
