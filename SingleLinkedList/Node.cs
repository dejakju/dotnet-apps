namespace libs
{
    public class Node
    {
        #region Private Members

        private object data;
        private Node next;

        #endregion

        #region Constructors

        public Node()
        {
            data = default;
            next = null;
        }

        public Node(object o)
        {
            data = o;
            next = null;
        }

        public Node(object o, Node n)
        {
            data = o;
            next = n;
        }

        #endregion

        #region Public Getters and Setters

        public object getData()
        {
            return data;
        }

        public Node getNextNode()
        {
            return next;
        }
        
        public void setData(object o)
        {
            data = o;
        }

        public void setNextNode(Node n)
        {
            next = n;
        }

        #endregion
    }
}