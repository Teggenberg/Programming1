﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7A
{
    public class TextCodec
    {

        sbyte _offset;

        public TextCodec(sbyte offset)
        {
            _offset = offset;
        }

        public sbyte GetOffset()
        {
            return _offset;
        }

        public void SetOffset(sbyte set)
        {
            _offset = set;  
        }

        public string Encode(string message)
        {
            StringBuilder sb = new StringBuilder(message);
            for (int i = 0; i < message.Length; i++)
            {
                sb[i] = (char)(sb[i] + _offset);
;           }

            return sb.ToString();
                       
        }

        public string Decode(string message)
        {

            StringBuilder sb = new StringBuilder(message);
            for (int i = 0; i < message.Length; i++)
            {
                sb[i] = (char)(sb[i] - _offset);
                ;
            }

            return sb.ToString();




        }




    }
}
