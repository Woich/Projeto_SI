using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AmbientController : MonoBehaviour
{
    public GameObject Montador;
    public GameObject Organizador;
    public GameObject Transportador;

    public GameObject CaixaTermica;
    public GameObject CaixaVacina;

    private List<GameObject> pallets = new List<GameObject>();

    private int side, row, collumn, verticalpos;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            while (true)
            {
                side = Random.Range(0, 2);
                row = Random.Range(0, 2);
                collumn = Random.Range(0, 6);
                verticalpos = Random.Range(0, 2);
                if (PalletExistsInPos(side, row, collumn, verticalpos) == false)
                {
                    break;
                }
            }
            

            GameObject newBox = Instantiate(CaixaVacina) as GameObject;
            float x = 2.5f + collumn + (side * 10);
            float y = verticalpos * 0.4f;
            float z = 9.5f - (row * 2);
            newBox.transform.position = new Vector3(x,y,z);
            newBox.GetComponent<CaixaVacina>().SetPosition(side, row, collumn, verticalpos);
            pallets.Add(newBox);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool PalletExistsInPos(int side, int row, int collumn, int verticalpos)
    {
        foreach(GameObject box in pallets)
        {
            CaixaVacina boxcomp = box.GetComponent<CaixaVacina>();
            if (ArrayUtility.ArrayEquals(boxcomp.GetPosition(), new int[4] {side, row, collumn, verticalpos}))
            {
                print("Box found");
                return true;
            }
        }
        return false;
    }
}
