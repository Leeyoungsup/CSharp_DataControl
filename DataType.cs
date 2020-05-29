using System;

namespace DataType
{
    class DataType
    {
        static void Main(string[] args)
        {
            //byte[1바이트0~255], short[2바이트], int[4바이트], long[8바이트
            //bool(1byte)=true/false
            bool b;
            b = true;
            b = false;
            //소수
            float f;//4byte
            f = 3.14f;
            double d = 3.14;//8byte

            char c = '가';//2byte

            string str = "Hello world!"; //list

            Console.WriteLine(str);
            //Console.WriteLine("Hello Nunber! {0}",d);

        }
    }
}
