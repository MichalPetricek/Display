using System;
using System.Collections.Generic;
using System.Text;

namespace Display
{
    class Screen
    {
        protected Element[] elements;
        protected Container[] covers;
        protected int _count = 0;
        protected int _maxcount;
       

        public Screen(int maxcount)
        {
            _maxcount = maxcount;
            elements = new Element[_maxcount];
            covers = new Container[_maxcount];
        }
        public void ClearScreen()
        {
            Console.Clear();
        }
        public void RepaintScreen()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.ReadKey();
                if (covers[i] != null)                                        
                {
                    covers[i].GetPosition();
                    Console.WriteLine(covers[i]);
                }
                if (elements[i] != null)
                {
                    elements[i].GetPosition();
                    Console.WriteLine(elements[i]);
                }

            }

        }
        public void ClearArray()
        {
            Array.Clear(elements, 0 , _maxcount);
            Array.Clear(covers, 0, _maxcount);
            _count = 0;

        }
        public bool AddElement(int x, int y, string text)
        {
            if (_count < _maxcount)
            {
                elements[_count] = new Element(x, y, text);
                _count++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddCover(int x, int y, object cover)
        {
            if (_count < _maxcount)
            {
                covers[_count] = new Container(x, y, cover);
                _count++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GetExtract()
        {
            for (int i = 0; i < _count; i++)
            {
                if (covers[i] != null)
                {
                    covers[i].GetPosition();
                    Console.WriteLine(covers[i]);
                }
                if (elements[i] != null)
                {
                    elements[i].GetPosition();
                    Console.WriteLine(elements[i]);
                }
               
            }
        }
       
        public void Rectangle(int size)
        {
            for (int i = 0; i <= size; i++)
            {
                AddElement(0, i, "1");
                AddElement(i*2 , 0, "1");
                AddElement(size*2, i, "1");
                AddElement(i*2 , size, "1");
            }

        }
        public void FullRectangle(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int y = 0; y  < size; y ++)
                {
                    AddElement(i*2, y, "1");
                }
            }
        }

       


        public void Cover(int size, int size2 , string text,int _x, int _y)
        {
            for (int i = 0; i <= size; i++)
            {

                AddCover(_x, i+_y, "|");
                AddCover(size+size2+_x , i+_y, "|");
            }
            for (int i = 0; i <= size2+size; i++)
            {
                AddCover(i+_x, _y, "-");
                AddCover(i+_x , size+_y, "-");
            }
            AddElement(_x+1,size/2+_y, text);

        }

       
            
        public void CoverText(string text, int x, int y)
        {
            if (text.Length <= 4)
            {
                for (int i = 0; i <= 4; i++)                 
                {
                    AddCover(x, i+y, "|");
                    AddCover(8+x, i+y, "|");
                }
                for (int i = 0; i <= 8; i++)
                {
                    AddCover(i+x, 0+y, "-");
                    AddCover(i+x, 4+y, "-");
                }
                AddElement(3+x, 2+y , text);
            }
            

            if (text.Length <= 6 && text.Length > 3)
            {
                for (int i = 0; i <= 4; i++)
                {
                    AddCover(x, i+y, "|");
                    AddCover(12+x, i+y, "|");                   
                }
                for (int i = 0; i <= 12; i++)
                {
                    AddCover(i+x, 0+y, "-");
                    AddCover(i+x, 4+y, "-");
                }
                AddElement(4+x, 2+y, text);
            }
                    
        }
        


    }
}
