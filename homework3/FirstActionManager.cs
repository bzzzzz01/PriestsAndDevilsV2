using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstActionManager : ActionManager, ActionCallback
{
    public float speed = 10;
    public FirstSceneController sceneController;
    public MoveToAction moveToLeft, moveToRight;

    protected new void Start()
    {
        sceneController = Director.getInstance().currentSceneController as FirstSceneController;
        sceneController.actionManager = this;
        moveToLeft = MoveToAction.GetAction(new Vector3(-1, 0.2f, 0), speed);
        moveToRight = MoveToAction.GetAction(new Vector3(1, 0.2f, 0), speed);
    }

    protected new void Update()
    {
        base.Update();
    }

    public void ActionEvent(Action source, ActionEventType events = ActionEventType.Competeted,
                            int intParam = 0, string strParam = null, GameObject gameObjectParam = null)
    {
        if (source == moveToLeft)
            this.RunAction(gameObjectParam, moveToLeft, this);
        if (source == moveToRight)
            this.RunAction(gameObjectParam, moveToRight, this);
    }

}