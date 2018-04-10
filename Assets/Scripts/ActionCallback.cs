using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionEventType : int { Started, Competeted }

public interface ActionCallback
{
    void ActionEvent(Action source, ActionEventType events = ActionEventType.Competeted,
                     int intParam = 0, string strParam = null, GameObject gameObjectParam = null);
}
