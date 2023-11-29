using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    public class SingleLinkedList
    {
        public Node head;
        public int count = 0;

        // Yeni bir nesne oluşturulduğunda head'e direkt bir null ataması yapılacaktır. 
        public SingleLinkedList()
        {
            head = null;
        }

        //Aşağıda bir linked liste önden ekleme işleminin nasıl yapılacağı gösterildi.
        // 

        public void InsertFront(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
            count++;
        }
        //Problem çözüldü
        public void InsertBack(int data)
        {
            Node curr = head;
            while (curr.next!=null)
            {
                curr = curr.next;
            }
            curr.next = new Node(data);
            count++;
          
        }
        //hata veriyor
        //Çözüldü
        public void RemoveFront() {
            if(head != null)
            {
                Node toDelete = head;
                head=head.next;
            }
            
            count--;
        }
        public void RemoveBack()
        {
            Node curr = head;
            if(curr==null || curr.next == null)
            {
                head = null;
            }

            Node nextNode = curr.next;

            while(curr.next!=null)
            {
                if (nextNode.next == null)
                {
                    curr.next = null;
                }
                curr=nextNode;
                nextNode = nextNode.next;
            }
            count--;
        }

        //Aşağıda yapılan işlemde bir yürütücü belirleniyor. Bu yürütücüye nodedan türetilmiş bir nesne olan head atanıyor.
        // runner.next ile ise bir sonraki nesneyi işaret etmesi sağlanıyor. Böylece nesne değeri null olana kadar bu işlem
        //Devam ediyor. 
        public void PrintSingleLinkedList() {

            Node runner = head;
            while(runner != null) {
                Console.WriteLine(runner.data); 
                runner = runner.next;

            }
        
        }
        // LinkedList içerisinde tutulan bir sayıdan sonra eklenmesi istenilen
        //sayının eklenme işlemi aşağıdaki fonksiyon içerisinde yapılacaktır.
        public void AddAfter(int addAfter, int data)
        {
            Node curr = head;

            while(curr.next != null)
            {
                if (curr.data == addAfter)
                {
                    Node n= new Node(data);
                    n.next = curr.next;
                    curr.next = n;
                    break;
                }
                curr = curr.next;
            }
        }
        // LinkedList içerisinde tutulan bir sayıdan sonra silinmesi istenilen
        //sayının silinme işlemi aşağıdaki fonksiyon içerisinde yapılacaktır.
        public void DeleteAfter(int deleteAfter)
        {
            Node curr = head;
            Node toDelete = null;
            while(curr != null)
            {
                if(curr.data == deleteAfter)
                {
                    toDelete = curr.next;
                    curr.next = toDelete.next;
                    toDelete.next = null;
                }
                curr = curr.next;
            }

        }
    }
}
