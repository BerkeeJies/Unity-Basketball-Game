using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{
    void Update() {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
