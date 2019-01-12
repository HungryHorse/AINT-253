using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAnim : MonoBehaviour {

    public TrapDoor trapDoor;

    public void KeyAnimDone()
    {
        trapDoor.OpenTrapDoor();
    }
}
