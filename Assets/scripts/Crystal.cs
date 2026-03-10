public class Crystal : PickUp
{
    public int Points = 5;

    public override void Picked()
    {
        GameManager.Instance.AddPoints(Points);
        Destroy(gameObject);
    }
 
    // Update is called once per frame
    void Update()
    {
        Rotation();
    }
}
