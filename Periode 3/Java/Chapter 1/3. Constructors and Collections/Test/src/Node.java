/*
 * Van Jurrian moest dit weg
*/
public class Node
{
    public boolean IsEmpty;
    public int Value;
    public Node Tail;

    public Node(int value, Node tail)
    {
        this.IsEmpty = false;
        this.Value = value;
        this.Tail = tail;

    }
}
