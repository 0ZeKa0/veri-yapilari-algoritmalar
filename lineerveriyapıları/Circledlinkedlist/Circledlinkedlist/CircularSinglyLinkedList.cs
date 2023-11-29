using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Circledlinkedlist
{
    public class CircularSinglyLinkedList
    {
        SingledNode last;

        //yapıcıyı oluşturduk. Yapıcı direkt circled işlemini yapacak.
        public CircularSinglyLinkedList()
        {
            this.last = last;
            if(this.last != null)
            {
                this.last.next = last;
            }
        }

        public void addToEnd(int data)
        {
            SingledNode singledNode= new SingledNode(data);
            
            if(last == null)
            {
                singledNode.next = singledNode;
            }
            else
            {
                singledNode.next = last.next;
                last.next = singledNode;
            }
            last = singledNode;
        }

        public void addToStart(int data)
        {
            SingledNode singledNode = new SingledNode(data);
            if (last == null)
            {
                singledNode.next= singledNode;
                last = singledNode;
            }
            else
            {
                singledNode.next = last.next;
                last.next= singledNode;
            }
        }

        public void deleteLast(int data)
        {
            SingledNode toDelete = last;

            if(toDelete.next == null || last == null)
            {
                last = null;
            }

            SingledNode prev = last.next;

            while (prev.next!=null)
            {
                prev = prev.next;
            }
            prev.next = last.next;
            prev = last;
        }

        public void deleteStart(int data)
        {
            SingledNode toDelete = last;

            if (last == null || last.next == null)
            {
                last = null;
            }

            toDelete = last.next;
            last.next = toDelete.next;
        }

        public void Print()
        {
            SingledNode curr = last;

            while (curr != null)
            {
                Console.WriteLine(curr.data);
                curr = curr.next;
            }
        }
        public void AddAfter(int InsertAfter, int data)
        {
            if (last != null)
            {
                SingledNode curr = last;
                do
                {
                    if (curr.data == InsertAfter)
                    {
                        SingledNode x = new SingledNode(data);
                        x.next = curr.next;
                        curr.next = x;
                        break;
                    }
                    curr=curr.next;

                } while (curr != null);
            }
        }

        //öncelikle iki node oluşturulur. Nodelardan birincisi silinecek nodeu bilmek için ikincisi ise
        //ilerleme ve verilen sayıyı bulabilmek için kullanılır. curr null olmadığında yani sonsuza kadar bu arama işlemi
        //devam edecektir. while döngüsünün içine baktığımızda işaretlenmiş nodeun verisi aranan veriye eşit olduğu takdirde
        //silenecek öğe bulunmuş nodeun bir sonraki nodeuna eşit olacaktır. curr.next==curr ise zaten yalnızca bir node kalıştır. O silinir.
        //aksi durumda toDelete ile işaretlenen nodeu silme işlemi gerçekleştirilir.
        
        public void RemoveAfter(int data) 
        {
            if (last == null)
            {
                return;
            }
            SingledNode toDelete = null;
            SingledNode curr = last;

            do
            {
                if (curr.data == data)
                {
                    toDelete = curr.next;
                    if(curr.next==curr)
                    {
                        last = null;
                    }
                    else
                    {
                        curr.next = toDelete.next;
                        if (toDelete == last)
                            last = curr;
                    }
                    break;
                }
                curr = curr.next;
            } while (curr != null);
        }

    }
}
