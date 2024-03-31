
public class Fibonacci
{
    private static Dictionary<int,int> myDict = new Dictionary<int,int>();

    public static int GetFibbonacci(int n){
        
        if(n == 0){
            return 0;
        }
        else if(n == 1){
            return 1;
        }else if(myDict.ContainsKey(n)){
            return myDict[n];
        }else{
            int val = GetFibbonacci(n-1) + GetFibbonacci(n-2);
            
            myDict.Add(n,val);
            return val;
        }
    }
}