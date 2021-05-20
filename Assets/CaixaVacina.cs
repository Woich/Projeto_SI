using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaixaVacina : MonoBehaviour
{
    public int side, row, collumn, verticalpos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPosition(int side, int row, int collumn, int verticalpos)
    {
        this.side = side;
        this.row = row;
        this.collumn = collumn;
        this.verticalpos = verticalpos;
    }

    public int[] GetPosition()
    {
        return new int[4] {side, row, collumn, verticalpos};
    }
}
