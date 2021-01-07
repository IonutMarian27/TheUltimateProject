using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class Health : MonoBehaviour
{

    public Image HP;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            HP.fillAmount = 1.0f * (PlayerHealthManager.currentHealth / PlayerHealthManager.startingHealth);
    }
}
