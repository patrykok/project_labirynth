public enum KeyColor
{
    Red,
    Green,
    Gold
}

public class Key : PickUp
{
    public KeyColor Color;

    public override void Picked()
    {
        GameManager.Instance.AddKey(Color);
        Destroy(gameObject);
    }
 
    // Update is called once per frame
    void Update()
    {
        Rotation();
    }
}