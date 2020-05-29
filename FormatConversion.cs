using System;

namespace part1_5
{
    class FormatConversion
    {
        static void Main(string[] args)
        {
            //1.바구니가 다른 경우
            int a = 0xFFFF;
            short b = (short)a;
            
            //2.바구니 크기가 같지만, 부호가 다른 경우
            byte c = 255;
            sbyte sb = (sbyte)c;
            //overflow,underflow
            //0xFF==0b11111111

            //3.소수
            float f = 3.14f;
            double d=f;
            //byte[1바이트0~255], short[2바이트], int[4바이트], long[8바이트
            //bool(1byte)=true/false
            
            //Console.WriteLine("Hello Nunber! {0}",d);
        }
    }
}
