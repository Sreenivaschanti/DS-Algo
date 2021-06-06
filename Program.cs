using System;

namespace Linklist
{
    class Program
    {
        Link head = null;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var p = new Program();
            var head = p.addChild(null, 5);
            head = p.addChild(head, 3);
            head = p.addChild(head, 8);
            head = p.addChild(head, 2);
            head = p.addChild(head, 1);
            head = p.addChild(head, 6);
            head = p.addChild(head, 10);
            Console.WriteLine("In Order");
            p.printListInorder(head);
            Console.WriteLine("Post Order");
            p.printListPostorder(head);
            Console.WriteLine("Pree Order");
            p.printListPreeorder(head);
        }
Link getNewChild(int data)
{
return new Link(data);
}
        Link addChild(Link Node,int data)
        {
            if (Node == null)
            {
                return getNewChild(data);

            }
            else
            {
               if(data<Node.data)
               Node.left=addChild(Node.left,data);
               else
                Node.right=addChild(Node.right,data);
            
            }
            return Node;

        }
       Link printListInorder(Link temp)
        {
            if(temp==null) return null;

            printListInorder(temp.left);
            Console.Write(temp.data +'\t');
            printListInorder(temp.right);
            return temp;
            
        }
         Link printListPostorder(Link temp)
        {
            if(temp==null) return null;

            printListInorder(temp.left);
             printListInorder(temp.right);
            Console.WriteLine(temp.data+'\t');
            return temp;
            
        }
          Link printListPreeorder(Link temp)
        {
            if(temp==null) return null;
            Console.WriteLine(temp.data+'\t');
            printListInorder(temp.left);
            printListInorder(temp.right);
            return temp;
            
        }
    }

    class Link
    {
        public int data;
        public Link left;
        public Link right;

        public Link(int data)
        {
            this.data = data;
            this.left = null;
            this.left = null;
        }
    }
}
