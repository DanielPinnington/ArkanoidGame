using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    bool Collided; //Has it collided?

    IEnumerator OnTriggerEnter2D(Collider2D collision) //IEnumator used for WaitForSeconds
    {
        Collided = true;
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Game Over"); //Hard coded at the moment, change if needed.
    }
}
