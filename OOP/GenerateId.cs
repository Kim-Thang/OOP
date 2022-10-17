using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class GenerateId
    {
        public string generateId()
        {
            int length = 8;
            string[] ingredients = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,1,2,3,4,5,6,7,8,9,0".Split(',');
            string result = "";
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                string rndIngr = ingredients[rnd.Next(ingredients.Length)];
                result += rndIngr;
            }
            return result;
        }
    }
}
    