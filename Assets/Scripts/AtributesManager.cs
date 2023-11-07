using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtributesManager : MonoBehaviour
{
    public float health;
    public float attack;
    bool inStealth;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Debug.Log("Game Over");
            Restart();
        }
    }
    public void StealthKillOn()
    {
        inStealth = false;
    }
     
    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AtributesManager>();
        if(atm != null)
        {
            atm.TakeDamage(attack);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
