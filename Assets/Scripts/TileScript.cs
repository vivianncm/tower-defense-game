using UnityEngine;

public class TileScript : MonoBehaviour
{
    public Point GridPosition { get; set; }
    void Start()
    {
        
    }

    void Update()
    {
        
    }


    public void Setup(Point gridPos, Vector3 worldPos)
    {
        this.GridPosition = GridPosition;
        transform.position = worldPos;
    }

}
