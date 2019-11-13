using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;

    //TODO: create a structure to contain a collection of bullets
    private Queue<GameObject> bullets;

    public int bullentNum = 20;

    // Start is called before the first frame update
    void Start()
    {

        bullets = new Queue<GameObject>(); // sets aside memory for the collection

        // TODO: add a series of bullets to the Bullet Pool
        for (int i = 0; i < bullentNum; i++)
        {
            var newBullet = Instantiate(this.bullet);
            newBullet.SetActive(false);
            bullets.Enqueue(newBullet);
        }
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        var returnedBullet = bullets.Dequeue();
        returnedBullet.SetActive(true);
        return returnedBullet;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        bullet.SetActive(false);
        bullets.Enqueue(bullet);
    }
}
