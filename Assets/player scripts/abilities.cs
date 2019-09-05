using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class abilities : MonoBehaviour
{
    [SerializeField] public List<Image> abDisplay;
    [SerializeField] public List<Sprite> abSprites;
    [SerializeField] public List<int> abOrder;
    [SerializeField] public List<bool> abIsSet;
    [SerializeField] int chance;
    // Update is called once per frame
    void Update()
    {
        if(Random.RandomRange(0,chance) == 1)
        {
            int i;
            List<int> temp = new List<int>();
            while (abOrder.Count > 0)
            {
                i = Random.RandomRange(0, abOrder.Count);
                temp.Add(abOrder[i]);
                abOrder.RemoveAt(i);
            }
            abOrder = temp;
        }
        int ii = 0;
        foreach(Image Imag in abDisplay)
        {
            Imag.sprite = abSprites[abOrder[ii]];
            ii++;
        }
    }
}
