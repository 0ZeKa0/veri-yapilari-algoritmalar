using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class DoublyLinkedList
    {
        public Node head;


        public DoublyLinkedList() {
        
           this.head = head;    
        }

        //Öncelikle yeni oluşturulan nodeun referansının yani next değişkeninin önceki head'i göstermesi sağlanır
        //daha sonra yeni oluşturulan noda head ve data ataması yapılır. Bu ekleme işlemi listenin en başından yapıldığı için 
        //kaydırma işlemi başa yani head'e yapılacaktır.
        public void FrontAdd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }


        }
        // Öncelikle node adında yeni bir nesne oluşturulur ve head ona atanır.
        // daha sonra headin değerinin null olup olmadığı kontrol edilir. O durumda yapılacak herhangi bir şey yoktur.
        // node.next null değilse  node bir sonraki suruma atanır. nodeun bir sonraki değerinin null olduğu durumda
        // NODE U silme işlemi yapabilmek için önce ve sonrasındaki referans değerleri null yapılır. 
        public void DeleteNodeEnd()
        {
            Node node = head;

            if (head==null || head.next==null)
            {
                head = null;
            }
            while(node.next != null)
            {
                node = node.next;

            }

            node.prev.next = null;

        }

        public void DeleteNodeFront()
        {
            Node node = head;

            if(head==null || head.next == null)
            {
                head = null;
            }
            head = head.next;
            head.prev = null;

        }
        // Double Linked Listte Single Linked Listte olmayan bir şekilde sona da ekleme yapılabilmektedir.
        public void BackAdd(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node curr = head;
                while (curr.next != null)
                {
                    //sonuncu elemanı arama işlemini ileriye taşıyoruz.
                    curr=curr.next;
                }
                curr.next = newNode;
                newNode.prev = curr;
            }
       
        }

        public void PrintList()
        {
            Node curr = head;
            
                while (curr != null)
                {
                    Console.WriteLine(curr.data);
                    curr = curr.next;
                }
            
        }
       
    }
}
