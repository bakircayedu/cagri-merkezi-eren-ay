using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkeziUyg
{
    public class BagList : LinkedListADT
    {
        public override void InsertFirst(Cagri value)
        {
            Node tmpHead = new Node
            {
                Data = value
            };
            if (Head == null)
                Head = tmpHead;
            else
            {
                tmpHead.Next = Head;
                Head = tmpHead;
            }
            Size++;

        }



        public override void InsertLast(Cagri value)
        {

            Node temp = Head;
            Node tmpLast = new Node
            {
                Data = value
            };
            if (Head == null)
            {
                Head = tmpLast;
                Size++;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.Next != null)
                        temp = temp.Next;
                    else
                    {
                        temp.Next = tmpLast;
                        Size++;
                        break;
                    }
                }

            }

        }


        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data;
                item = item.Next;
            }
            return temp;
        }


        public override void InsertPos(int position, Cagri value)
        {
            Node temp = Head;
            Node tmpEkle = new Node
            {
                Data = value
            };
            for (int i = 0; i <= position; i++)
            {
                if (temp.Next != null)
                {
                    if (i == position - 1)
                    {
                        tmpEkle.Next = temp.Next;
                        temp.Next = tmpEkle;
                        Size++;
                    }
                    else
                    {
                        temp = temp.Next;
                    }
                }
            }

        }

        public override void DeleteFirst()
        {

            if (Head != null)
            {
                Head = Head.Next;
                Size--;
            }
        }

        public override void DeleteLast()
        {
            Node temp = Head;

            while (temp.Next != null)
            {
                if (temp.Next.Next != null)
                    temp = temp.Next;
                else
                {
                    temp.Next = null;
                    Size--;
                    break;
                }
            }
            

        }

        //dizi {1,2,3,4} position 2=2.elemani  dizi{1,3,4}
        public override void DeletePos(int position)
        {
            Node temp = Head;

            if (1<position)
            {
                for (int i = 0; i <= position; i++)
                {
                    if (temp.Next != null)
                    {
                        if (i == position - 1)//silecegimiz node dan onceki node un next'ini sonraki node'un next ine esitleyerek listeden cikardim  
                        {
                            temp.Next = temp.Next.Next;
                            Size--;
                        }
                        else
                        {
                            temp = temp.Next;
                        }
                    }
                }
            }
            else if (1==position) //head' i sil
            {
                Head = Head.Next;
            }
            else
            {
                MessageBox.Show("Hatali sayi girdiniz");
            }

        }

        public override Node GetElement(int position)
        {
            Node temp = Head;

            for (int i = 1; i <= position; i++)
            {

                if (i == position)
                {
                    return temp;
                }
                else if (temp.Next != null)
                {
                    temp = temp.Next;
                }
            }
            return null;
        }

        public override Node GetElementById(int id)
        {
            Node temp = Head;

            for (int i = 1; i <= Size; i++)
            {

                if (temp.Data.CagriTanimlayici == id)
                {
                    return temp;
                }
                else if (temp.Next != null)
                {
                    temp = temp.Next;
                }
            }
            return null;
        }

        public override int GetPositionById(int id)
        {
            Node temp = Head;

            for (int i = 1; i <= Size; i++)
            {

                if (temp.Data.CagriTanimlayici == id)
                {
                    return i;
                }
                else if (temp.Next != null)
                {
                    temp = temp.Next;
                }
            }
            return 0;
        }
    }

}
