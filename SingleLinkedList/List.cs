namespace libs
{
    public class SingleLinkedList
    {

        #region Private Members

        private Node mHeadNode = null;

        #endregion

        #region Public Methods

        public bool contains(object obj)
        {
            Node currentNode = mHeadNode;

            while (currentNode != null)
            {
                if (currentNode.getData().Equals(obj))
                {
                    return true;
                }
                currentNode = currentNode.getNextNode();
            }

            return false;
        }

        public object replace(int position, object obj)
        {
            if (position <= 0 || obj == null)
                return null;

            if (position == 1)
            {
                Node newNode = new Node(obj);
                object data = null;

                if (is_empty())
                {
                    data = mHeadNode.getData();
                    mHeadNode = newNode;
                }
                else
                {
                    data = mHeadNode.getData();
                    newNode.setNextNode(mHeadNode);
                    mHeadNode = newNode;
                }
                return data;
            }

            if (position > 1)
            {
                Node newNode = new Node(obj);
                Node currentNode = mHeadNode;
                object data = null;

                for (int i = 1; i < (position-1) && currentNode != null; i++)
                    currentNode = currentNode.getNextNode();

                if (currentNode != null)
                {
                    data = currentNode.getNextNode().getData();
                    newNode.setNextNode(currentNode.getNextNode().getNextNode());
                    currentNode.setNextNode(newNode);
                    return data;
                }
            }

            return null;
        }

        public object remove_at(int position)
        {
            if (position <= 0)
                return null;

            if (position == 1)
            {
                object data = mHeadNode.getData();
                Node currentNode = mHeadNode.getNextNode();
                mHeadNode = currentNode;
                return data;
            }

            if (position > 1)
            {
                Node currentNode = mHeadNode;

                for (int i = 1; i < (position-1) && currentNode != null; i++)
                    currentNode = currentNode.getNextNode();

                if (currentNode != null)
                {
                    object data = currentNode.getNextNode().getData();
                    currentNode.setNextNode(currentNode.getNextNode().getNextNode());
                    return data;
                }
            }

            return null;
        }

        public object get_data(int position)
        {
            object value = null;
            Node currentNode = mHeadNode;

            for (int i = 1; i <= (position - 1) && currentNode != null; i++)
                currentNode = currentNode.getNextNode();

            if (currentNode != null)
                value = currentNode.getData();

            return value;
        }

        public bool insert(object obj)
        {
            return insert_at(length() + 1, obj);
        }

        public bool insert_at(int position, object obj)
        {
            if (position <= 0 || obj == null)
                return false;

            if (position == 1)
            {
                Node newNode = new Node(obj);

                if (is_empty())
                    mHeadNode = newNode;
                else
                {
                    newNode.setNextNode(mHeadNode);
                    mHeadNode = newNode;
                }
                return true;
            }

            if (position > 1)
            {
                Node newNode = new Node(obj);
                Node currentNode = mHeadNode;

                for (int i = 1; i < (position-1) && currentNode != null; i++)
                    currentNode = currentNode.getNextNode();

                if (currentNode != null)
                {
                    newNode.setNextNode(currentNode.getNextNode());
                    currentNode.setNextNode(newNode);
                    return true;
                }
            }

            return false;
        }

        public bool add_head(object obj)
        {
            return insert_at(1, obj);
        }

        public bool add_tail(object obj)
        {
            return insert(obj);
        }

        public object rem_head()
        {
            if (!is_empty())
                return remove_at(1);
            else
                return null;
        }

        public object rem_tail()
        {
            if (!is_empty())
                return remove_at(length());
            else
                return null;
        }

        public bool is_empty()
        {
            return (mHeadNode == null);
        }

        public bool is_full()
        {
            return false;
        }

        public void clear()
        {
            mHeadNode = null;
        }

        public int length()
        {
            Node currentNode = mHeadNode;
            int count = 0;

            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.getNextNode();
            }

            return count;
        }

        #endregion

    }
}