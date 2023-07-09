using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    public float money;
    public Text score;
    public GameObject button1, button2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        money += 1 * Time.deltaTime;
        if (money <= 0)
        {
            button1.SetActive(false);
            button2.SetActive(false);
        }
        else if(money > 0)
        {   
            button1.SetActive(true);
            button2.SetActive(true);
        }
        score.text = money.ToString();
    }
    
    public void SpendMoney(int price)
    {
        
        if(money - price > 0)
        {
            money = money - price;
            score.text = money.ToString();
        }
        else
        {
            score.text = money.ToString();
        }
        
    }
}
