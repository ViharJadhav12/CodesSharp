using System;
using System.Linq;
using System.Text;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {
                CommonFunction obj = new CommonFunction();
                string str = "MaDayM!1212123@#$%^&*()_+/?><.,      ";
                Console.WriteLine(obj.stringIsPallendrome(str).ToString());

        }
    }

    public  class CommonFunction 
    {
            public string stringIsPallendrome(string str)
            {

                 string retVal;
                 bool isPal = false;
                 string val = string.Join("", str.Where(char.IsLetter));
                 int lng = val.Length-1;
                #region logic 1
                 StringBuilder sb = new StringBuilder();
                 for(int i=val.Length-1;i>=0;i--)
                 {  
                     sb.Append(val[i]);
                 }
                    if(Convert.ToString(sb) == val)                    
                        retVal   = val + " Is Pallendrome..!";
                    else
                        retVal   = val + " Is Not Pallendrome..!";
                #endregion
               
                #region logic 2
      //  for(int i=0; i<=val.Length-1; i++)
                //  {
                //      if(Convert.ToString(val[i]) == Convert.ToString(val[lng]))
                //      {
                //          isPal = true;
                //          lng--;
                //          continue;                         
                //      }            
                //      else
                //      {
                //          isPal = false;   
                //          break;
                //      }         
                //  }
                //     if(isPal)
                //         retVal = val + " Is Pallendrome..!";
                //     else
                //         retVal = val + " Is Not Pallendrome..!";

#endregion          
                
                
                return retVal;
            }
    }





}
