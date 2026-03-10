public class Freeze : PickUp
{
    public int FreezeTime = 10;

    public override void Picked()
    {
        GameManager.Instance.FreezeTime(FreezeTime);
        Destroy(gameObject);
    }
 
    // Update is called once per frame
    void Update()
    {
        Rotation();
    }
}