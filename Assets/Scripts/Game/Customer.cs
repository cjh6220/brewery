using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    public SpriteRenderer sr;
    int _idx = -1;
    e_Beer _wantBeer = e_Beer.None;
    public void SetCustomer(int i)
    {
        _idx = i;
        _wantBeer = (e_Beer)Random.Range(1, (int)e_Beer.Max);
        sr.color = GetBeerColor(_wantBeer);
    }

    Color GetBeerColor(e_Beer beerType)
    {
        Color color = Color.white;

        switch (beerType)
        {
            case e_Beer.Red:
                color = Color.red;
                break;
            case e_Beer.Green:
                color = Color.green;
                break;
            case e_Beer.Blue:
                color = Color.blue;
                break;
        }

        return color;
    }
}
