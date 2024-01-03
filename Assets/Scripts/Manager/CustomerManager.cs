using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerManager : MonoBehaviour
{
    public Transform[] PositionList;
    public GameObject[] CustomerObjList;

    private void Start() 
    {
        SetCustomers();
    }

    void SetCustomers()
    {
        for (int i = 0; i < PositionList.Length; i++)
        {
            var ran = Random.Range(0, CustomerObjList.Length);
            var item = Instantiate(CustomerObjList[ran], PositionList[i]);
            item.GetComponent<Customer>().SetCustomer(i);
        }
    }
}
