using System;

namespace HW4_2
{
    public class TreeNode
    {
        private int _data;
        private TreeNode _right;
        private TreeNode _left;

        public int Data { get { return _data; } set { _data = value; } }
        public TreeNode Right { get { return _right; } set { _right = value; } }
        public TreeNode Left { get { return _left; } set { _left = value; } }
    }
    public class BinaryTree
    {
        protected TreeNode Root;

        public BinaryTree(int data)
        {
            Root = new TreeNode { Data = data };
        }

        /// <summary>
        /// Метод добавления узла в дерево
        /// </summary>
        /// <param name="data">Значение нового узла</param>
        public void AddNode(int data)
        {
            TreeNode current = Root;
            TreeNode newNode = new TreeNode { Data = data };


            while (current != null)
            {
                if (newNode.Data == current.Data)
                {
                    break;
                }
                if (newNode.Data > current.Data)
                {
                    if (current.Right != null)
                    {
                        current = current.Right;
                    }
                    else
                    {
                        current.Right = newNode;
                        break;
                    }
                }
                else if (newNode.Data < current.Data)
                {
                    if (current.Left != null)
                    {
                        current = current.Left;
                    }
                    else
                    {
                        current.Left = newNode;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Поиск элемента
        /// </summary>
        /// <param name="data">элемент</param>
        /// <returns>Возвращается true в случае нахождения, иначе false</returns>
        public bool SearchData(int data)
        {
            TreeNode current = Root;

            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                if (data > current.Data)
                {
                    current = current.Right;
                }
                else if (data < current.Data)
                {
                    current = current.Left;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод удаления
        /// </summary>
        /// <param name="data">Значение</param>
        /// <returns>Возвращает true в случае нахождения и удаления и false в ином случае </returns>
        public bool Delete(int data)
        {
            TreeNode current = Root;
            if (current.Data == data)
            {
                Root = null;
                return true;
            }
            while (current != null)
            {
                if (current.Right != null)
                {
                    if (current.Right.Data == data)
                    {
                        current.Right = null;
                        return true;
                    }
                }
                if ( current.Left !=null)
                {
                    if (current.Left.Data == data )
                    {
                        current.Left = null;
                        return true;
                    }
                    
                }
                if (data > current.Data)
                {
                    current = current.Right;
                }
                else if (data < current.Data)
                {
                    current = current.Left;
                }
            }
            return false;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [7] {3,5,2,4,7,1,6};
            Array.Sort(array);
            BinaryTree tree = new BinaryTree(array[array.Length / 2]);
            for (int i = 0; i < array.Length; i++) //Заполнение дерева
            {
                if (array.Length / 2 == i)
                {
                    continue;
                }
                tree.AddNode(array[i]);
            }
            bool a = tree.SearchData(6); //Поиск элемента
            tree.Delete(7); //Удаление элемента
        }
    }
}

