using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnCollisionExit2D(Collision2D other) {
        Destroy(other.transform.parent.gameObject);
    }
}
