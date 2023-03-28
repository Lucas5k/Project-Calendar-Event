namespace calendar_events;
#pragma warning disable CS8602

public class EventList<T>
{
    private class Node
    {
        public T Value;
        public Node? Next;

        public Node(T t)
        {
            Value = t;
            Next = null;
        }
    }

    private Node? Head;

    public void GenericList()
    {
        Head = null;
    }

    public void Add(T input)
    {
        if (Head == null)
        {
            Head = new Node(input);
        }
        else
        {
            //Encontra onde inserir o próximo nó na lista.
            Node? lastNode = Head;
            while(lastNode.Next != null)   lastNode = lastNode.Next;

            lastNode.Next = new Node(input);
        }
    }

    public void Print(string format)
    {
        Node? printNode = Head;
        while(printNode.Next != null)
        {
        }
    }

    public T? Index(int index)
    {
        Node? searchNode = Head;
        for(int i = 0; i < index; i++)
        {
            if(searchNode.Next != null)
            {
                searchNode = searchNode.Next;
                continue;
            }
            else
            {
                throw new InvalidOperationException("Não há elementos suficientes na lista");
            }
        }
        return searchNode.Value;
    }

    public int SearchByTitle(string title)
    {
        throw new NotImplementedException();
    }

    public int SearchByDate(string dateSearch)
    {
        throw new NotImplementedException();
    }
}