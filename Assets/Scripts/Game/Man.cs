using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Man : MonoBehaviour
{
    public SpriteRenderer SelectedBeerType;
    Dispenser _selected;

    public void SetSelectedBeer(Dispenser dispenser)
    {
        _selected = dispenser;
        SelectedBeerType.gameObject.SetActive(true);
        SetColor(dispenser.BeerType);
    }

    void SetColor(e_Beer beerType)
    {
        switch (beerType)
        {
            case e_Beer.Red:
                SelectedBeerType.color = Color.red;
                break;
            case e_Beer.Green:
                SelectedBeerType.color = Color.green;
                break;
            case e_Beer.Blue:
                SelectedBeerType.color = Color.blue;
                break;
        }
    }
}
