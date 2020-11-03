using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject end;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(1);
        end.SetActive(true);
    }

}
